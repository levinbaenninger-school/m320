# Primitive Datentypen und Objekte

Primitive Datentypen (`int`, `char`, etc.) unterscheiden sich gegenüber Objekten in mehreren Aspekten.

## Primitive Datentypen

- Direkt im Stack gespeichert
- Feste Grösse
- Wertetypen
- Keine Methoden/Properties
- Beispiele: `bool`, `int`, `float`, `byte`, `double`, `char`, etc.

## Objekte

- Referenz im Stack, gespeichert im Heap
- Variable Grösse
- Referenztypen
- Methoden und Properties
- Beispiele: `string`, `Array`, `Color`, etc.

## Value- vs. Referencetype

Der wichtigste Unterschied ist der Value- bzw. Referencetype-Aspekt. Am besten schauen wir uns dafür ein Beispiel an:

````C#
int x = 10;
int y = x; // y erhält Kopie von x
y = 20; // x bleibt 10

Person p1 = new Person();
Person p2 = p1; // Beide Variablen referenzieren dasselbe Objekt im Heap
p2.Name = "Max"; // Ändert auch p1.Name
````

## Methoden

Bei Methoden können wir ebenfalls entscheiden, ob wir die Variable als Wert übergeben wollen oder als Referenz:

````C#
// Wertetyp
void ChangeNumber(int number) {
    number = 42; // Ändert nur lokale Kopie
}

int x = 10;
ChangeNumber(x); // x bleibt 10

// Referenztyp
void ChangeNumber(ref int number) {
    number = 42; // Ändert Original
}

int x = 10;
ChangeNumber(ref x); // x wird zu 42

void GetNumber(out int number) {
    number = 42; // Muss im Method gesetzt werden
}

int x;
GetNumber(out x); // x wird zu 42
````

Der Unterschied zwischen `ref` und `out` ist, dass wir bei `out` den Parameter in der Methode initialisieren müssen, bei `ref` nicht.