# Aggregation

Die Aggregation ist eine spezielle Assoziation, welche immer dann angewendet wird, wenn eine "**Ganze-Teile**"-Beziehung vorliegt.

Hierbei verkörpert die Klasse das Ganze und die andere Klasse einen Teil davon.

> Sobald man die Fragestellung mit "**hat**" beantworten kann, handelt es sich um eine Aggregation

````plantuml
@startuml
left to right direction

Ganzes "1" o-- "0..*" Teil
@enduml
````

- Sowohl das Ganze, als auch die Teile können einzeln existieren
- Teile können in verschiedenen Ganzen verwendet werden

## Beispiele

> **Beispiel 1**: Ein Notebook hat eine bis drei Festplatten. Eine Festplatte ist entweder nicht oder in genau einem Notebook eingebaut.
>
> **Beispiel 2**: In einer Firma arbeiten beliebig viele Mitarbeiter. Die Mitarbeiter können bei beliebig vielen Firmen arbeiten.

````plantuml
@startuml
left to right direction

Firma "0..*" o--> "0..*" Mitarbeiter
Notebook "0..3" o--> "0..1" Festplatte

@enduml
````

### Umsetzung in C#

````C#
public class Notebook
{
    private readonly List<HardDrive> _hardDrives = [];
    public IReadOnlyCollection HardDrives => _hardDrives.AsReadOnly();

    public Notebook(HardDrive hardDrive)
    {
        _hardDrives.Add(hardDrive);
    }

    public bool AddHardDrive(HardDrive hardDrive)
    {
        if (hardDrive.IsInstalled)
            return false;

        if (_hardDrives.Count >= 2)
            return false;

        _hardDrives.Add(hardDrive);
        hardDrive.Install();

        return true;
    }

    public bool RemoveHardDrive(HardDrive hardDrive)
    {
        if (!hardDrive.IsInstalled)
            return false;

        if (_hardDrives.Count <= 1)
            return false;

        _hardDrives.Remove(hardDrive);
        hardDrive.Uninstall();

        return true;
    }
}

public class HardDrive
{
    public bool IsInstalled { get; private set; }

    public void Install()
    {
        IsInstalled = true;
    }

    public void Uninstall()
    {
        IsInstalled = false;
    }
}
````

````C#
public class Company
{
    private readonly List<Employee> _employees = [];
    public IReadOnlyCollection<Employee> Employees => _employees;

    public void Hire(Employee employee)
    {
        _employees.Add(employee);
    }

    public void Fire(Employee employee)
    {
        if (_employees.Contains(employee))
        {
            _employees.Remove(employee);
        }
    }
}

public class Employee
{
    
}
````