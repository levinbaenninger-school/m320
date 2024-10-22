# this-Verweis

Das `this`-Keyword verweist auf die aktuelle Instanz einer Klasse. So können wir z.B. Properties nutzen, die bspw. von Parametern überschrieben
wurden, da sie gleich heissen:

````C#
public class Employee
{
    private string alias;
    private string name;

    public Employee(string name, string alias)
    {
        // Use this to qualify the members of the class
        // instead of the constructor parameters.
        this.name = name;
        this.alias = alias;
    }
}
````

Wir können aber auch ein Objekt als Parameter an andere Methoden übergeben:

````C#
CalcTax(this);
````