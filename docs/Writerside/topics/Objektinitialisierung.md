# Objektinitialisierung

Es gibt neben den Konstruktoren eine zweite Möglichkeit um Objekte zu initialisieren, nämlich mit den Object Initializer:

````C#
var person = new Person 
{ 
    Name = "Max", 
    Age = 25 
};
````

Dafür müssen die Properties aber auf `set` oder `init` gesetzt sein. 