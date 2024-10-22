# Vererbung

Generalisierung
: A generalization is a taxonomic relationship between a more general classifier and a more specific classifier. Each instance of the specific
classifier is also an indirect instance of the general classifier. Thus, the specific classifier inherits the features of the more general classifier.

## Notation

Die Generalisierungsbeziehung zwischen Klassen wird mit einem Pfeil mit nicht ausgefüllter dreieckiger Pfeilspitze dargestellt. Sie zeigt von der
spezialisierten Klasse hin zur allgemeinen (generalisierten Klasse).

````plantuml
@startuml

"Allgemeine Klasse" <|-- "Spezialisierte Klasse"

@enduml
````

## Beispiele

### Generalisierung

````plantuml
@startuml

class Person {
  + lastName: string
  + firstName: string
  + eat()
}

class Client {
  + revenue: float
  + buy()
}

class "Warehouse Clerk" {
  + heightInCm: int
  + store()
}

Person <|-- Client
Person <|-- "Warehouse Clerk"

@enduml
````

````C#
public class Person(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} eats...");
    }
   
}

public class Customer(string firstName, string lastName) : Person(firstName, lastName)
{
    public float Revenue { get; set; } = 0;
    
    public void Buy(float amount)
    {
        Console.WriteLine($"{FirstName} {LastName} buys food for {amount:C}...");
        Revenue += amount;
    }
}

public class WarehouseClerk(string firstName, string lastName int heightInCm) : Person(firstName, lastName)
{
    public int HeightInCm { get; set; } = heightInCm;
    
    public void Store()
    {
        Console.WriteLine($"{FirstName} {LastName} stores an item...");
    }
}
````

### Abstrakte Klasse

````plantuml
@startuml

abstract class Person {
  + lastName: string
  + firstName: string
  + eat()
}

class Client {
  + sales: float
  + buy()
}

class "Warehouse Clerk" {
  + heightInCm: int
  + store()
}

Person <|-- Client
Person <|-- "Warehouse Clerk"

@enduml
````

````C#
public abstract class Person(string firstName, string lastName) { ... }
````

### Abstrakte Methode

````plantuml
@startuml

abstract class Person {
  + lastName: string
  + firstName: string
  + eat()
  + carry() { abstract }
}

class Client {
  + sales: float
  + buy()
}

class "Warehouse Clerk" {
  + heightInCm: int
  + store()
}

Person <|-- Client
Person <|-- "Warehouse Clerk"

@enduml
````

````C#
public abstract class Person(string firstName, string lastName) 
{ 
    ... 
    public abstract void Carry();    
}

public class Customer(string firstName, string lastName) : Person(firstName, lastName)
{
    ...    
    public override void Carry()
    {
        Console.WriteLine($"{FirstName} {LastName} works to be able to buy at Lidl...");
    }
}

public class WarehouseClerk(string firstName, string lastName int heightInCm) : Person(firstName, lastName)
{
    ...
    public override void Carry()
    {
        Console.WriteLine($"{FirstName} {LastName} works as warehouse clerk...");
    }
}
````

### Überschreiben

````plantuml
@startuml

abstract class Person {
  + lastName: string
  + firstName: string
  + eat()
  + carry() { abstract }
}

class Client {
  + sales: float
  + buy()
}

class Child {
  + age: byte
  + eat()
}

class "Warehouse Clerk" {
  + heightInCm: int
  + store()
}

Person <|-- Client
Person <|-- Child
Person <|-- "Warehouse Clerk"

@enduml
````

````C#
public abstract class Person(string firstName, string lastName) 
{ 
    ... 
    public virtual void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} eats...");
    } 
    ...
}

public class Child(string firstName, string lastName) : Person(firstName, lastName)
{
    public int Age { get; set; } = age;

    public override void Eat()
    {
        Console.WriteLine($"{FirstName} {LastName} eats candy with it's hands...");
    }

    public override void Carry()
    {
        Console.WriteLine($"{FirstName} {LastName} is too young to work...");
    }
}
````