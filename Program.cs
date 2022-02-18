using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcct = new BankAccount(400.00);
            Console.WriteLine("New bank account created");

            Console.WriteLine($"Your balance is: {myAcct.GetBalance()}");

            var secondAcct = new BankAccount();
            Console.WriteLine("2nd account created");

            Console.WriteLine($"Your 2nd account balance is: {secondAcct.GetBalance()}");

            secondAcct.Deposit(200.00);
            Console.WriteLine("Deposit accepted.");
            Console.WriteLine($"New balance is:{secondAcct.GetBalance()}");
        }
    }
}
