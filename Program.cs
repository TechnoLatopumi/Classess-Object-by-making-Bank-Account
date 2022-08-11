// See https://aka.ms/new-console-template for more information
using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var account = new BankAccount("Tegar", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);

        Console.WriteLine(account.GetAccountHistory());
        // Test for a negative balance. uncomment the comment line below to try the error!
        /*try
        {
            account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception caught trying to overdraw");
            Console.WriteLine(e.ToString());
        }
        */
// Test that the initial balances must be positive.
        /*
        BankAccount invalidAccount;
        try
        {
            invalidAccount = new BankAccount("invalid", -55);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
            return;
        }
        */
        
        }
}