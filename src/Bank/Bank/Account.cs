namespace Bank;

public class Account
{
	public static double ActiveInterest { get; set; } = 0.03;
	public static double PassiveInterest { get; set; } = 0.08;
	public double Balance { get; private set; }
	public int AccountNumber { get; private set; }
	private static int _lastAccountNumber = 0;
	private double _currentInterestBalance;

	public Account()
	{
		AccountNumber = ++_lastAccountNumber;
	}

	public void Deposit(double amount)
	{
		if (amount <= 0)
		{
			throw new ArgumentException("Deposit amount must be positive");
		}

		Balance += amount;
		Console.WriteLine("Deposited {0:C} into account {1}", amount, AccountNumber);
	}

	public void Withdraw(double amount)
	{
		if (amount <= 0)
		{
			throw new ArgumentException("Withdrawal amount must be positive");
		}

		Balance -= amount;
		Console.WriteLine("Withdrew {0:C} from account {1}", amount, AccountNumber);
	}

	public void CreditDailyInterest()
	{
		double interest = Balance > 0 ? ActiveInterest : PassiveInterest;
		double dailyInterest = Balance * interest / 360;
		_currentInterestBalance += dailyInterest;
	}

	public void CloseAccount()
	{
		Balance += _currentInterestBalance;
		Console.WriteLine("Closed account {0} with {1:C}", AccountNumber, Balance);
	}
}
