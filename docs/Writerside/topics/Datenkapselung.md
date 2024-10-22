# Datenkapselung

* Daten und zugehörige Funktionen werden zusammen gekapselt
* Interne Details werden nach außen verborgen
* Zugriff nur über definierte Schnittstelle (Interface)
* Schutz vor falscher Verwendung

````C#
// Schlechtes Design (keine Kapselung)
public class BankAccount
{
    public decimal balance;  // Direkt zugänglich
}

// Gutes Design (mit Kapselung)
public class BankAccount
{
    // Private Felder - nach außen versteckt
    private decimal balance;
    private string accountNumber;
    private List<Transaction> transactions;

    // Öffentliche Properties - kontrollierter Zugriff
    public decimal Balance { get; private set; }
    public string AccountNumber { get; }

    // Öffentliche Methoden - definierte Schnittstelle
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Betrag muss positiv sein");

        balance += amount;
        transactions.Add(new Transaction(amount));
    }

    public bool Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            transactions.Add(new Transaction(-amount));
            return true;
        }
        return false;
    }
}
````