using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPacker4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 1
            bool menuSystem = true;
            while (menuSystem)
            {
                Console.WriteLine("Welcome to Backpacker");
                Console.WriteLine("[1] Start");
                Console.WriteLine("[2] End");
                Console.Write("Pick: ");

                int menuChoice = Convert.ToInt32(Console.ReadLine());
                if (menuChoice == 1)
                {
                    menuSystem = false;
                    Console.Clear();
                }
                else if (menuChoice == 2)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }
            }
            // Section 2
            string item1 = "", item2 = "", item3 = "", item4 = "";
            string[] items = new string[4] { item1, item2, item3, item4 };

            Console.WriteLine("Store up to 4 items");
            Console.Write("[1]: ");
            item1 = Console.ReadLine();
            Console.Write("[2]: ");
            item2 = Console.ReadLine();
            Console.Write("[3]: ");
            item3 = Console.ReadLine();
            Console.Write("[4]: ");
            item4 = Console.ReadLine();
            Console.Clear();

            Console.Write("You have stored: ");
           Console.Write("\n[1]: " 
                + item1 + "\n[2]: " 
                + item2 + "\n[3]: " 
                + item3 + "\n[4]: " 
                + item4 + "\n"); // works!
               // Section 3
            Console.Write("\nThrow something away? Yes / No : ");

            string PlayAgain = Console.ReadLine();
            if (
                PlayAgain == "yes" ||
                PlayAgain == "Yes" ||
                PlayAgain == "Y" ||
                PlayAgain == "y")
            {

            }
            else
            {
                Environment.Exit(0);
            }

            Console.Clear();
            bool TrashLoop = true;
            while (TrashLoop)
            {
                Console.WriteLine("\n[1]: "
                + item1 + "\n[2]: "
                + item2 + "\n[3]: "
                + item3 + "\n[4]: "
                + item4 + "\n"); // works!

                Console.WriteLine("What should I discard? Pick [1] through [5].\n[5] Drops all your gear.");
                Console.WriteLine("If you are done, [6] or above to Exit application.");

                int Trash = Convert.ToInt32(Console.ReadLine());
               

                    if (Trash == 1)
                {
                    Console.Clear();
                    item1 = "";
                }
                    else if (Trash == 2)
                {
                    Console.Clear();
                    item2 = "";
                }
                    else if (Trash == 3)
                {
                    Console.Clear();
                    item3 = "";
                }
                    else if (Trash == 4)
                {
                    Console.Clear();
                    item4 = "";
                }
                else if (Trash == 5)
                {
                    Console.Clear();
                    item1 = "";
                    item2 = "";
                    item3 = "";
                    item4 = "";
                }

                else
                {
                    TrashLoop = false;
                }
            }

        }
    }
}
