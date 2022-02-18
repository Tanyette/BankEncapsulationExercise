using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount(double amount)
        {
            balance = amount;
        }

        public BankAccount()
        {
        }

        private double balance = 0;//private field called balance using camelCase

        public void Deposit(double amount) 
        {
            balance += amount;
        }

        public double GetBalance() 
        {
            return balance;
        }

        public double Withdrawal()

        
            
        {
            Console.WriteLine("what amount do you want to withdrawl?");
            var isTrue = double.TryParse(Console.ReadLine(), out double amount);
            return balance -= amount;

          
        }

        

    }

}
