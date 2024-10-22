# Konstruktoren

Konstruktoren sind spezielle Methoden einer Klasse, die bei der Objekterstellung aufgerufen werden.

- Namen ist identisch mit dem Klassennamen
- Kein Rückgabetyp (auch nicht `void`)
- Wird beim Erstellen eines Objektes mit `new` aufgerufen
- Initialisiert einen Objekt-Zustand

````C#
public class Person
{
    public string Name;
    public int Age;

    // Standardkonstruktor (parameterlos)
    public Person()
    {
        Name = "Unbekannt";
        Age = 0;
    }

    // Parametrisierter Konstruktor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Kopierkonstruktor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }
}

public class Main 
{
    public static void Main(string[] args)
    {
        // Standardkonstruktor
        Person p1 = new Person();
        // p1.Name ist "Unbekannt", p1.Age ist 0
    
        // Parametrisierter Konstruktor
        Person p2 = new Person("Max", 25);
        // p2.Name ist "Max", p2.Age ist 25
    
        // Kopierkonstruktor
        Person p3 = new Person(p2);
        // p3 hat die gleichen Werte wie p2
    }
}
````

Wie man sieht können also auch Konstruktoren überladen werden.

## Konstruktorenverkettung

Mit der Konstruktorenverkettung müssen wir nicht unnötig Code wiederholen, wenn wir mehrere Möglichkeiten zur Konstruktion eines Objektes haben.
Ausserdem können wir so den Konstruktor der Basisklasse (Klasse von welcher wir erben) aufrufen:

````C#
public class Student : Person
{
    public int MatrNr;

    // Basis-Konstruktor aufrufen
    public Student(string name, int age, int matrNr) 
        : base(name, age)
    {
        MatrNr = matrNr;
    }

    // Anderen Konstruktor aufrufen
    public Student(string name) 
        : this(name, 18, 0)
    {
    }
}
````

## Anderes

- Wenn kein Konstruktor definiert &rarr; automatischer parameterloser Konstruktor
- Private Konstruktoren verhindern die Instanziierung von Aussen
- Statische Klassen haben private Konstruktoren
