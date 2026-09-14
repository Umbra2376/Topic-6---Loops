using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my looped menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Guessing number");
                Console.WriteLine("2 - Bank Transactions");
                Console.WriteLine("3 - Rolling doubles");
                Console.WriteLine("...");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    int min, max;
                    Random number = new Random();
                    Console.WriteLine("Please give me a min number.");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please give me a max number.");
                    max = Convert.ToInt32(Console.ReadLine());
                    while (min > max)
                    {
                        Console.WriteLine("That is more than you have, please enter a valid amount:");
                        while (!Int32.TryParse(Console.ReadLine(), out min))
                            Console.WriteLine("Invalid integer, try again.");

                    }
                    int randomNumber = number.Next(min, max + 1);
                    Console.WriteLine("Please guess your random number between " + min + " and " + max + ".");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    while (guess != randomNumber)
                    {
                        if (guess < randomNumber)
                        {
                            Console.WriteLine("Your guess is too low, try again.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (guess > randomNumber)
                        {
                            Console.WriteLine("Your guess is too high, try again.");
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    int transaction;
                    double fee, balance;
                    bool done = false;
                    balance = 150;
                    fee = 0.75;
                    while (!done)
                    {
                        Console.WriteLine("Welcome to BOB! What transaction are you looking to do today? You will be charged a $0.75 transaction fee, even for checking your balance.");
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Check Balance");
                        Console.WriteLine("4 - Bill Payment");
                        Console.WriteLine("5 - Exit");
                        transaction = Convert.ToInt32(Console.ReadLine());
                        if (transaction == 1)
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            balance += deposit;
                            balance -= fee;
                            Console.WriteLine("Your new balance is: $" + balance);
                        }
                        else if (transaction == 2)
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            if (withdraw > balance)
                            {
                                Console.WriteLine("You do not have enough funds to withdraw that amount.");
                            }
                            else
                            {
                                balance -= withdraw;
                                balance -= fee;
                                Console.WriteLine("Your new balance is: " + balance);
                            }
                        }
                        else if (transaction == 3)
                        {
                            Console.WriteLine("Your current balance is: " + balance);
                        }
                        else if (transaction == 4)
                        {
                            Console.WriteLine("How much would you like to pay towards your bill?");
                            double billPayment = Convert.ToDouble(Console.ReadLine());
                            if (billPayment > balance)
                            {
                                Console.WriteLine("You do not have enough funds to pay that bill.");
                            }
                            else
                            {
                                balance -= billPayment;
                                balance -= fee;
                                Console.WriteLine("Your new balance is: " + balance);
                            }
                        }
                        else if (transaction == 5)
                        {
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid transaction, please try again.");
                        }
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "3")
                {
                    // Do option 3
                    Random dice = new Random();
                    int die1 = 0, die2 = 1, rolls = 0;
                    Console.WriteLine("Hi! I'm going to roll 2 dice until I get doubles then I'll tell you how many times it took. You'll have to press ENTER to roll.");
                    Console.ReadLine();
                    while (die1 != die2)
                    {
                        rolls++;
                        die1 = dice.Next(1, 7);
                        die2 = dice.Next(1, 7);
                        Console.WriteLine("You rolled a " + die1 + " and a " + die2 + ".");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                    Console.WriteLine("It took " + rolls + " rolls to get doubles.");
                    Console.WriteLine("Press ENTER to go back to menu.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}