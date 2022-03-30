using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Welcome to the First Terminal Bank of Indianapolis.");
            bool isValidResponse = false;
            bool isDoubleResponse = false;
            bool isDepositResponse = false;
            string userInput;
            double userAmount;
            string userBalance = "BALANCE";
            string userDeposit = "DEPOSIT";
            string userExit = "EXIT";

            
            do
            {
                Console.WriteLine("To see your balance, type BALANCE.  To make a deposit, type DEPOSIT: ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == userBalance)
                {
                    isValidResponse = true;
                    Console.WriteLine($"Your balance is ${account.GetBalance()}.");
                }

                if (userInput == userDeposit)
                {
                    isValidResponse = true;

                    do
                    {
                        Console.Write("List the amount you wish to deposit: $");
                        isDoubleResponse = double.TryParse(Console.ReadLine(), out userAmount);
                    } while (isDoubleResponse != true);

                    if (userAmount >= 0)
                    {
                        account.Deposit(userAmount);
                        Console.WriteLine($"Your new balance is ${account.GetBalance()}");
                        isDepositResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Withdrawls are not available at this time.");
                    }
                }

            } while (isValidResponse != true);


            while (isDepositResponse != true)
            {
                Console.WriteLine("To make a deposit, type DEPOSIT. To exit, type EXIT: ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == userDeposit)
                {
                    do
                    {
                        Console.Write("List the amount you wish to deposit: $");
                        isDoubleResponse = double.TryParse(Console.ReadLine(), out userAmount);
                    } while (isDoubleResponse != true);

                    if (userAmount >= 0)
                    {
                        account.Deposit(userAmount);
                        Console.WriteLine($"Your new balance is ${account.GetBalance()}");
                        isDepositResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Withdrawls are not available at this time.");
                    }
                }
                if (userInput == userExit)
                {
                    isDepositResponse = true;
                }
            }

            Console.WriteLine("We value your business.  Don't forget to take your receipt.");
         }
    }
}
