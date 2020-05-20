using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction();
            bool printingTable = true;
            while (printingTable)
            {
                Console.WriteLine("");
                Console.Write("Your Number: ");
                string userNumber = Console.ReadLine().Trim();
                int number;
                bool isANum = int.TryParse(userNumber, out number);
                if (!isANum)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that does not appear to be a number. Please try again.");
                    printingTable = true;
                }
                else if (isANum)
                {
                    PrintPowersTable(number);
                    bool rerunChoice = true;
                    if (rerunChoice)
                    {
                        string decision = GetUserRerunDecision();
                        if (decision == "y")
                        {
                            rerunChoice = false;
                            printingTable = true;
                        }
                        else if (decision == "n")
                        {
                            rerunChoice = false;
                            printingTable = false;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, I didn't comprehend your decision. Allow me to ask again:");
                            rerunChoice = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("I'm sorry, some error has occurred. Please try again.");
                    printingTable = true;
                }
            }
            ProgramClosingStatement();
            Environment.Exit(0);
        }
        static void ProgramIntroduction()
        {
            Console.WriteLine("Welcome to the Powers Table Application!");
            Console.WriteLine("This program allows you to enter a number and displays a Powers Table.");
            Console.WriteLine("The table displays a sequence of the number, the sequence of the number's square, and the sequence of a number's cube.");
            Console.WriteLine("");
            Console.WriteLine("Let's Get Started!");
        }

        static void PrintPowersTable(int number)
        {
            Console.WriteLine("");
            Console.WriteLine(string.Format("{0}\t\t{1}\t\t{2}", "NUMBER", "SQUARE", "CUBE"));
            Console.WriteLine("=====================================");
            for (int i = 1; i < number + 1; i++)
            {
                Console.WriteLine(string.Format("{0}\t\t{1}\t\t{2}", i, i * i, i * i * i));
            }
            Console.WriteLine("");
            Console.WriteLine("Your table has been generated successfully!");
        }
        static string GetUserRerunDecision()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to run this application for another number? (Y / N)");
            Console.Write("Your decision: ");
            return Console.ReadLine().Trim().ToLower();
        }
        static void ProgramClosingStatement()
        {
            Console.WriteLine("");
            Console.WriteLine("Thanks for using our Powers Table Application!");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("");
        }
    }
}
