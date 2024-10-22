# Listentypen

In C# gibt es mehrere Arten, um Listen zu erstellen &rarr; Arrays und generische Listen.

## Arrays

- Feste Grösse nach Initialisierung
- Direkter Speicherzugriff (Schnell)
- Typ muss bei Deklaration festgelegt werden

````C#
// Deklaration & Initialisierung
int[] numbers = new int[5];  // Größe 5, alle Elemente 0
string[] names = { "Max", "Anna", "Tom" };  // Direkte Initialisierung

// Zugriff
numbers[0] = 42;  // Schreiben
int x = numbers[0];  // Lesen

// Eigenschaften
int length = numbers.Length;  // Länge
````

## Listen

- Dynamisch wachsend
- Flexibler als Arrays
- Viele nützliche Methoden

````C#
// Deklaration & Initialisierung
List<int> numbers = new List<int>();
List<string> names = new List<string>{ "Max", "Anna" };

// Elemente hinzufügen/entfernen
numbers.Add(42);
numbers.AddRange(new int[] { 1, 2, 3 });
numbers.Remove(42);
numbers.RemoveAt(0);

// Zugriff
int first = numbers[0];
numbers[0] = 10;

// Nützliche Methoden
bool exists = numbers.Contains(42);
numbers.Sort();
numbers.Reverse();
int count = numbers.Count;  // Anzahl Elemente
numbers.Clear();  // Alle Elemente löschen
````

## Nutung

Wann was nutzen:

* **Array**: Wenn Grösse feststeht, Performance wichtig
* **List**: Wenn Grösse dynamisch, mehr Funktionalität benötigt