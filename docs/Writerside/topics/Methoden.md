# Operationen

Operation
: An operation is a behavioral feature of a classifier that specifies the name, type, parameters, and constraint for invoking an associated behavior.

## Notation

Eine Operation wird immer durch mindestens ihren Namen sowie weitere Angaben spezifiziert. Mehrere Operationen werden dabei vertikal untereinander,
linksbündig und typischerweise im 3. Abschnitt
geschrieben.

````plantuml
@startuml
left to right direction

class Circle {
  ...
  draw()
}
@enduml
````

````C#
class Circle {
  ...
  
  void Draw() {...}
}
````

## Operationsdeklaration

Wie auch bei den Attributen können Operationen noch weiter Deklarationen beinhalten. Die Multiplizität und Eigenschaftswerte sind dieselben, wie bei
der [**Attributsdeklaration**](Attribute.md#attributsdeklaration)

### Sichtbarkeit

Die Sichtbarkeit wird ganz am Anfang dargestellt durch folgende Zeichen:

- `+`(Public): Jede andere Instanz hat uneingeschränkten Zugriff
- `-` (Private): Nur Instanzen der Klasse, die das Attribut definiert, dürfen zugreifen
- `#` (Protected): Nur Instanzen der Klasse, die das Attribut definiert und Instanzen abgeleiteter Klassen, dürfen zugreifen
- `~` (Internal): Jede Instanz innerhalb derselben Assembly dürfen zugreifen

````plantuml
@startuml
left to right direction

class Circle {
  ...
  + draw()
  - delete()
  # copy()
}
@enduml
````

````C#
class Circle {
  ...
  
  public void Draw() {...}
  private void Delete() {...}
  protected void Copy() {...}
}
````

### Parameterliste

Eine Operation kann eine Liste von Parametern haben, um eine bestimmte Operation überhaupt durchführen zu können.

Die Parameterdeklaration ist ähnlich definiert wie die [**Attributsdeklaration**](Attribute.md#attributsdeklaration), jedoch gibt es anstatt der
Sichtbarkeit eine Übergaberichtung und keine statischen Attribute.

````plantuml
@startuml
left to right direction

class Circle {
  ...
  move(x: int, y: int)
}
@enduml
````

````C#
class Circle {
  ...
  
  void Move(int x, int y) {...}
}
````

### Übergaberichtung

In der Parameterliste können wir noch die Übergaberichtung festlegen:

- `in`: Der Parameter wird nur von der Operation gelesen
- `out`: Der Parameter wird von der Operation nicht gelesen, sondern nur geschrieben
- `inout`: Die Operation list und schreibt den Parameter

````plantuml
@startuml
left to right direction

class Circle {
  ...
  draw(radius: int)
  copy(out status: string)
  color(inout color: Color)
}
@enduml
````

````C#
class Circle {
  ...
  
  void draw(int radius) {...}
  void copy(out string status) {...}
  void color(ref Color color) {...}
}
````

### Rückgabetyp

Eine Operation kann uns auch einen Wert zurückgeben.

````plantuml
@startuml
left to right direction

class Circle {
  ...
  isCircle(): boolean
}
@enduml
````

````C#
class Circle {
  ...
  
  bool isCircle() {...}
}
````

### Klassenoperation

Genau wie bei Attributen können auch Operationen statisch sein. Das heisst sie brauchen keine Attribute einer Instanz, um ausgeführt zu werden.

````plantuml
@startuml
left to right direction

class Circle {
  ...
  {static} calculateArea(radius: int): double
}
@enduml
````

````C#
class Circle {
  ...
  
  static double CalculateArea(int radius) {...}
}
````