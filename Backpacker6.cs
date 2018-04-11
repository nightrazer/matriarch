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
            string item1 = "";

            bool menuSystem = true;
            while (menuSystem)
            {
                // Menysystemet, Välja 1 till och med 4
                Console.WriteLine("Welcome to Backpacker");
                Console.WriteLine("[1] Pack your bag");
                Console.WriteLine("[2] Check your bag");
                Console.WriteLine("[3] Remove item");
                Console.WriteLine("[4] End program");
                Console.Write("Pick: ");
                 int menuChoice = Convert.ToInt32(Console.ReadLine());
                

                if (menuChoice == 1)
                {
                    // Matar in informationen till strängen item1, tömmer skärmen.
                    Console.Write("\nPack you bag with: ");
                    item1 = Console.ReadLine();
                    Console.Clear();
                }
                else if (menuChoice == 2)
                {
                    // Tömmer skärmen, berättar innehållet av item1
                    Console.Clear();
                    Console.WriteLine("You have packed this: ( "  + item1 +  " )!\n");
                    

                }
                else if (menuChoice == 3)
                {
                    // Medelar vad som tagits bort.
                    Console.WriteLine("I Removed your " + item1);
                    item1 = "";
                    // Om det inte finns något i item1, medelar att inget finns där
                        if (item1 == "")
                    {
                        Console.WriteLine("There is nothing in your bag");
                    }
                        // Medelar vad som nu finns i ryggsäcken.
                    else { 
                    Console.WriteLine("You now have ( "+ item1 +" )" + "in your bag" );
                    Console.ReadLine();
                    Console.Clear();
                    }
                }
                // Avslutar programmet.
                else if (menuChoice == 4)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }

            }
        }
    }
}
