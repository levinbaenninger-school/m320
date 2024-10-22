# Komposition

Die Komposition ist ein Spezialfall der Aggregation, bei der das Teil ohne sein Ganzes nicht existieren kann.

Ansonsten gelten dieselben Eigenschaften, wie bei der Aggregation.

````plantuml
@startuml
left to right direction

Ganzes "1" *-- "0..*" Teil
@enduml
````

- Das Teil kann ohne sein Ganzes nicht existieren
- Ein Teil kann höchstens zu einem Ganzen gehören

## Beispiele

> **Beispiel 1:** Ein Schulhaus besitzt mehrere Schulzimmer
>
> **Beispiel 2:** Ein Kunde besitz ein bis fünf Konten

````plantuml
@startuml
left to right direction

Kunde "1" *--> "1..5" Konto
Schulhaus "1" *-- "1..*" Zimmer


@enduml
````

### Umsetzung in C#

````C#
public class SchoolHouse
{
    private readonly List<Room> _rooms = [];
    public IReadOnlyCollection<Room> Rooms => _rooms;

    public SchoolHouse()
    {
        _rooms.Add(new Room());
    }

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }
}

public class Room
{

}
````

````C#
public class Client
{
    private readonly List<Account> _accounts = [];
    public IReadOnlyCollection<Account> Accounts => _accounts;

    public Client()
    {
        _accounts.Add(new Account());
    }

    public bool AddAccount(Account account)
    {
        if (_accounts.Count >= 5)
            return false;

        _accounts.Add(account);
        return true;
    }
}

public class Account
{

}
````