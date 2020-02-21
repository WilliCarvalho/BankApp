using System;
using BankApp.Entities;
using BankApp.Entities.Exceptions;


namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account Data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);

                Console.WriteLine($"New Balance {acc.Balance}");
            }
            catch(AccountException e)
            {
                Console.WriteLine(e.Message);   
            }            
        }
    }
}
