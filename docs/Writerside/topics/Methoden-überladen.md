# Methoden überladen

Wenn wir bei Methoden unterschiedliche Signaturen haben, können wir mehrere Methoden mit demselben Namen erstellen. Die Methodensignatur ist die
eindeutige Beschreibung einer Operation und setzt sich aus Name und Typisierung zusammen.

````C#
Calculate() { ... } // --> Calculate
Calculate(int x) { ... } // --> Calculate, int
Calculate(int x, int y) { ... } --> Calculate, int, int
````

Wir können alle diese Methoden deklarieren, obwohl sie gleiche Namen haben, jedoch haben sie ganz andere Parameter.

> Bei den Parametern ist nur der Datentyp wichtig, nicht der Name!