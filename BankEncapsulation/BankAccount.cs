using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit()
        {
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"We are adding {money, 0:c} to your account");
            Console.WriteLine();

            if (money > 10000) 
            {
                Console.WriteLine("Big Ballin");
                Console.WriteLine();
            }
            else if (money < 10000 && money > 1000)
            {
                Console.WriteLine("Ballin");
                Console.WriteLine();
            }
            else if (money < 1000 && money > 500)
            {
                Console.WriteLine("Baller on a budget");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("that tickled");
                Console.WriteLine();
            }
            _balance += money;
            ExitMaybe();
        }

        public void Withdraw()
        {
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"You are withdrawing {money,0:c} from your account");
            Console.WriteLine();
            _balance -= money;
            ExitMaybe();
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your balance is: {_balance,0:c}");
            Console.WriteLine();
            ExitMaybe();
        }

        public void Pin()
        {
            int x;
            bool userPin;
            do
            {
                Console.WriteLine("Hello, Please enter your 4 digit pin");
                
                userPin = int.TryParse(Console.ReadLine(), out x);
                Console.WriteLine();


                if (x <= 9999 && x >= 0000 && userPin == true)
                {
                    Console.WriteLine("Welcome Money Bags");
                    Console.WriteLine();
                    Welcome();
                }
                else
                {
                    Console.WriteLine("Invalid Input, Try Again");
                    Console.WriteLine();
                }
                   
                
            } while (x > 9999 || x < 0000 || userPin ==false);
        }

        public void Welcome()
        {
            string userInput;
            
                Console.WriteLine("Hello, and welcome to Bank O'Denero");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine();
            do
            { 
                Console.WriteLine("Please choosse from one of the following:");
                Console.WriteLine("Check balance\n" +
                    "Withdraw\n" +
                    "Deposit");
                userInput = Console.ReadLine();
                Console.WriteLine();
                userInput = userInput.ToLower();

                if (userInput == "check balance")
                {
                    GetBalance();
                }
                else if (userInput == "withdraw")
                {
                    Console.WriteLine("How much mullah would you like to withdraw?");
                    Withdraw();
                }
                else if (userInput == "deposit")
                {
                    Console.WriteLine("How much mullah would you like to deposit?");
                    Deposit();
                }
                else
                {
                    Console.WriteLine("Sorry invalid input, try again.");
                    Console.WriteLine();
                }
            } 
            while (userInput != "check balance" && userInput != "withdraw" && userInput != "deposit");
        }
        public void ExitMaybe()
        {
            string userChoice;
            do
            {
                Console.WriteLine("Anything else?\n" +
                        "Yes\n" +
                        "No");
                userChoice = Console.ReadLine();
                Console.WriteLine();
                userChoice = userChoice.ToLower();

                if (userChoice == "yes")
                {
                    Welcome();
                }
                else if (userChoice == "no")
                {
                    Console.WriteLine("Thankyou for choosing Bank O'Denero, Have a great day.");
                    Bye();
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine();
                }
            }
            while(userChoice != "yes" && userChoice != "no");
        }

        public string Bye()
        {
            return "";
        }
    }
}
