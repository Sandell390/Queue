using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public static class Menu
    {
        public static void display() 
        {
            Console.Clear();

            Console.WriteLine("========================");
            Console.WriteLine("H1 Queue Operations Menu");
            Console.WriteLine("========================");

            Console.WriteLine();

            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Delete Person");
            Console.WriteLine("3. Show the number of person");
            Console.WriteLine("4. Show min and max age");
            Console.WriteLine("5. Find a person");
            Console.WriteLine("6. Print all person");
            Console.WriteLine("7. Exit");

        }


        public static int userchoice() 
        {
            int userint = 0;
            bool canParse;
            do
            {
                Console.WriteLine();
                Console.Write("Choice: ");
                string input = Console.ReadLine();

                canParse = int.TryParse(input, out userint);


                if (!canParse) 
                {
                    errorMessage(1);
                    canParse = false;
                }
                else if (userint < 1 || userint > 7) 
                {
                    errorMessage(2);
                    canParse = false;
                }

            } while (!canParse);

            return userint;
        
        }


        public static void errorMessage(int ErrorCode) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("You did something wrong! Error code: " +  ErrorCode);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
