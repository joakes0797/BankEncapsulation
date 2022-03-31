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
            string userInput;
            string userBalance = "BALANCE";
            string userDeposit = "DEPOSIT";
            string userExit = "EXIT";
            
            do
            {
                Console.WriteLine("To see your balance, type BALANCE.  To make a deposit, type DEPOSIT. To exit, type EXIT: ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == userBalance || userInput == userDeposit || userInput == userExit)
                {
                    isValidResponse = true;
                }

            } while (isValidResponse != true);


            switch (userInput)
            {
                case "BALANCE":
                    Console.WriteLine($"Your balance is ${account.GetBalance()}");
                    Console.WriteLine("We value your business.  Don't forget to take your receipt.");
                    break;

                case "DEPOSIT":
                    Deposit(account);
                    break;

                case "EXIT":
                    Console.WriteLine("Please come again.  Goodbye!");
                    break;
            }
        }

        private static void Deposit(BankAccount account)
        {
            bool isDoubleResponse = false;
            double userAmount;
            do
            {
                Console.Write("List the amount you wish to deposit: $");
                isDoubleResponse = double.TryParse(Console.ReadLine(), out userAmount);
            } while (isDoubleResponse != true);

            if (userAmount >= 0)
            {
                account.Deposit(userAmount);
                Console.WriteLine($"Your new balance is ${account.GetBalance()}");
                Console.WriteLine("We value your business.  Don't forget to take your receipt.");
            }
            else
            {
                Console.WriteLine("Withdrawls are not available at this time.");
            }
        }
    }
}
