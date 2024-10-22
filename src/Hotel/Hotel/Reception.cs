namespace Hotel;

public class Reception(string phoneNumber, string email)
{
    public string PhoneNumber { get; set; } = phoneNumber;
    public string Email { get; set; } = email;
    
    public void Print()
    {
        Console.WriteLine($"Reception: {PhoneNumber}, {Email}");
    }
}