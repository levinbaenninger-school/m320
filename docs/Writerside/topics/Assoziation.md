# Assoziation

Assoziation
: An association describes a set of tuples whose values refer to typed instances An instance of an association is called a link

## Notation

Die Binäre Assoziation wird durch eine durchgezogene Linie dargestellt. Diese kann sowohl durch textuelle Angaben als auch durch grafische Symbole
weiter konkretisiert werden.

Die wichtigsten Angaben sind der Name und die Beschriftung der Enden und der Multiplizität.

![image_2.png](image_2.png) { width="600" }

### Multiplizitäten

Multiplizitäten einer Assoziation geben an, wie viele Objekte der einen Klasse mit der anderen Klasse in Verbindung stehen.

> **Beispiel 1:** Kunde erhält mindestens eine bis beliebig viele Rechnungen
>
> **Beispiel 2:** Ein Angestellter einer Firma betreut 0 bis beliebig viele Lieferanten der Firma
>
> **Beispiel 3:** Eine Schulklasse hat genau einen Klassensprecher, welcher nur für eine Klasse zuständig ist

````plantuml
@startuml
left to right direction

Klasse "1" -- "1" Sprecher
Angestellter "1" -- "0..*" Lieferant
Kunde "1" -- "1..*" Rechnung : erhält >
@enduml
````

| Multiplizität | Beschreibung                      |
|---------------|-----------------------------------|
| `0`           | keins                             |
| `1`           | genau eins                        |
| `*`           | beliebig viele                    |
| `0..*`        | keins oder beliebig viele (wie *) |
| `1..*`        | eins oder beliebig viele          |
| `1..3`        | eins, zwei oder drei              |
| `4..20`       | vier bis zwanzig                  |
| `1, 5, 7`     | eins, fünf oder sieben            |

### Leserichtung

Oftmals ist der gewählte Assoziationsname nicht für beide Assoziationsrichtungen gleichermassend treffend. Mit dem ausgefüllten Dreieck wird die
bevorzugte Leserichtung angegeben.

> **Beispiel:** Der Kunde besucht das Geschäft und nicht umgekehrt

````plantuml
@startuml
left to right direction

Kunde -- Geschäft : besucht >

@enduml
````

### Rollen

Es ist möglich, dass eine Klasse mit einer anderen Klassen verknüpft ist Mithilfe von Rollen kann die spezifische Verwendung einer Klasse näher
beschrieben werden.

> **Beispiel:** Eine Person arbeitet in der Firma und abends betreut sie einen Verein

````plantuml
@startuml

Person "Arbeitnehmer" -- Firma : arbeitet >
Person "Trainer" -- Verein : betreut >

@enduml
````

### Navigierbarkeit

#### Unidirektionale Navigierbarkeit

Mit der Navigierbarkeit ist die Kenntnis der anderen Klass gemeint. Man spricht hierbei von einer gerichteten Assoziation.

Die Navigierbarkeit wird
durch einen offenen Pfeil am Ende der Assoziation ausgedrückt.

> **Beispiel:** Der Fan kennt einen Star, aber der Star kennt seinen Fan nicht

````plantuml
@startuml
left to right direction

Fan --> Star : kennt >

@enduml
````

#### Bidirektionale Navigierbarkeit

> **Beispiel:** Ein Kind kennt seinen Vater und der Vater kennt sein Kind

````plantuml
@startuml
left to right direction

Kind <--> Vater : kennt >

@enduml
````

#### Navigationsverbot

> **Beispiel:** Ein Detektiv kennt die zu beschattende Person, doch die Person darf auf keinen Fall den Detektiven kennen

````plantuml
@startuml
left to right direction

Detektiv x--> Person : kennt >

@enduml
````

## Umsetzung in C#

### Vater und Kind

````plantuml
@startuml
left to right direction

Kind "0..1" <--> "0..1" Vater  : kennt >

@enduml
````

````C#
public class Child
{
    public Father Father { get; private set; }
    
    public void SetFather(Father father)
    {
        Father = father;
    }
}

public class Father
{
    public Child Child { get; private set; }
    
    public void SetChild(Child child)
    {
        Child = child;
    }
}
````

### Hund und Laus

````plantuml
@startuml
left to right direction

Hund "1" <--> "0..*" Laus

@enduml
````

````C#
public class Dog
{
    private readonly List<Louse> _louses = [];
    public IReadOnlyCollection<Louse> Louses => _louses;
    
    public void AddLouse(Louse louse)
    {
        _louses.add(louse);
    }
}

public class Louse
{
    public Dog Host { get; private set; }
    
    public Louse(Dog host)
    {
        Host = host;
        host.AddLouse(this);
    }
}
````

### Kunde und Buch

````plantuml
@startuml
left to right direction

Kunde "0..1" --> "0..*" Buch : leiht >

@enduml
````

````C#
public class Client
{
    private readonly List<Book> _books = [];
    public IReadOnlyCollection<Book> Books => _books;
    
    public void BorrowBook(Book book)
    {
        if (!book.IsLended)
        {
            _books.Add(book);
            book.Lend();
        }
    }
    
    public void ReturnBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.remove(book);
            book.Return();
        }
    }
}

public class Book
{
    public bool IsLended { get; private set; } = false;
    
    public void Lend()
    {
        IsLended = true;
    }
    
    public void Return()
    {
        IsLended = false;
    }
}
````