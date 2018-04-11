using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpacker5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            bool myloop = true;
            while (myloop) { 
                Console.Write("\n\t[1] Inmatning");
                Console.Write("\n\t[2] Utmatning");
                Console.Write("\n\t[3] Rensa värde");
                Console.Write("\n\t[4] Avsluta");
                Console.Write("\n\tVälj: ");

                string menyVal = Console.ReadLine();
                try
                {
                    int meny = Convert.ToInt32(menyVal);
                }
                catch
                {
                    Console.WriteLine("Fel! Du får bara skriva in nummer!");
                }

                switch (menyVal)
                {
                    case "1":
                        Console.Write("\tSkriv något: ");
                        userInput = Console.ReadLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Din utmatning var: " + userInput);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        // Nollställning
                         userInput = "";
                         Console.Write("Innuti strängen finns: ____");
                         Console.Write(userInput);
                         Console.Write("____ . Om det är tomt, Nollställd.");
                         Console.WriteLine(userInput);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        // hoppar ur loopen
                        myloop = false;
                        break;

                    default:

                        break;
                }

            }
        }
        
    }

}
