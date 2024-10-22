# Attribute

Attribut
: A property is a structural features. A property related to a classifier by owned attribute represents an attribute. It relates an instance of the
class to a value or collection of value of the type of attribute.

## Notation

Attribute werden üblicherweise im zweiten Abschnitt des Klassensymbols linksbündig untereinander angeordnet. Attributnamen werden kleingeschrieben und
Klassenattribute unterstrichen.

````plantuml
@startuml
left to right direction

class Account {
  name: string
  age: int
  address: Address
}
@enduml
````

````C#
class Account {
  string name;
  int age;
  Address address;
}
````

## Attributsdeklaration

Bei den Attributen können wir aber nicht nur den Namen angeben, sondern noch vieles weiteres, wie z.B. die Sichtbarkeit oder den Vorgabewert.

### Sichtbarkeit

Die Sichtbarkeit wird ganz am Anfang dargestellt durch folgende Zeichen:

- `+`(Public): Jede andere Instanz hat uneingeschränkten Zugriff
- `-` (Private): Nur Instanzen der Klasse, die das Attribut definiert, dürfen zugreifen
- `#` (Protected): Nur Instanzen der Klasse, die das Attribut definiert und Instanzen abgeleiteter Klassen, dürfen zugreifen
- `~` (Internal): Jede Instanz innerhalb derselben Assembly dürfen zugreifen

````plantuml
@startuml
left to right direction

class Account {
  + name: string
  # age: int
  - address: Address
  ~ id: Guid
}
@enduml
````

````C#
class Account {
  public string name; // Verstösst gegen die Datenkapselung
  protected int age;
  private Address address;
  internal Guid id;
}
````

### Abgeleitete Attribute

Abgeleitete Attribute werden zur Laufzeit berechnet.

````plantuml
@startuml
left to right direction

class Account {
  ...
  / age: int
  ...
}
@enduml
````

### Multiplizität

Die Multiplizität legt die Unter- und Obergrenze der Anzahl der unter einem Attributnamen ablegbaren Instanzen fest:

- `0..1`: optionales Attribut
- `1..1`: genau ein Wert
- `0..*`: beliebig viele Elemente
- `n..m`: fixiert durch mind. `n` Elemente und max. `m` Elemente, wobei `m` und `n` natürliche Zahlen sind

````plantuml
@startuml
left to right direction

class Account {
  ...
  users: User[1..3] 
  ...
}
@enduml
````

````C#
class Account {
  ...
  user[] users = new User[3];
  ...
}
````

### Vorgabewert

Der Vorgabewert definiert einen Standardwert für ein Attribut.

````plantuml
@startuml
left to right direction

class Account {
  ...
  balance: float = 0
  ...
}
@enduml
````

````C#
class Account {
  ...
  float balance = 0;
  ...
}
````

### Eigenschaftswert

Mit dem Eigenschaftswert können besondere Charakteristika benannt werden:

- `readOnly`: Der Wert des Attributs kann nicht verändert werden
- `ordered`: Die Inhalte eines Attributs sind in geordneter Reihenfolge
- `unique`: Es gibt keine zwei gleichen Werte in den Inhalten eines Attributs
- `id`: Das Attribut ist Teil des Identifiers der Klasse

````plantuml
@startuml
left to right direction

class Account {
  ...
  accountNumber: Guid {readonly, id}
  ...
}
@enduml
````

````C#
class Account {
  ...
  readonly Guid accountNumber;
  ...
}
````

### Klassenattribute

Wenn alle Objekte einer Klasse denselben Wert für ein Attribut haben, dann handelt es sich um ein Klassenattribut.

````plantuml
@startuml
left to right direction

class Account {
  ...
  {static} hourlyWage: float
  ...
}
@enduml
````

````C#
class Account {
  ...
  static float hourlyWage;
  ...
}
````