namespace Bank
{
	internal class Program
	{
		private static void Main()
		{
			Account account = new();

			try
			{
				account.Deposit(2000);
				account.CreditDailyInterest();

				account.Withdraw(3000);
				account.CreditDailyInterest();

				account.Deposit(5000);
				account.CreditDailyInterest();

				account.Withdraw(1000);
				account.CreditDailyInterest();
				account.CloseAccount();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
