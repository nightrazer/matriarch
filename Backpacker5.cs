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
            // Jag har skapat min variabel i början av programmet.
            // Av typen string för att klara tecken utmatning.
            // userInput kommer vara tillgänglig under hela programmet livstid
            // userInput är en global variabel.
            string userInput = "";

            // loopen myLoop körs igenom programmet tills dess att den avslutas
            // genom att mata in alternativ 4
            bool myLoop = true;
            while (myLoop) {
                Console.WriteLine("\tVälkommen till ryggsäcken!");
                Console.Write("\n\t[1] Lägg till ett föremål");
                Console.Write("\n\t[2] Skriv ut innehållet");
                Console.Write("\n\t[3] Rensa innehållet");
                Console.Write("\n\t[4] Avsluta");
                Console.Write("\n\tVälj: ");

                string menyVal = Console.ReadLine();
                // Try och catch förhindrar felaktig inmatning
                // Tillåter enbart Integer, heltal
                // Vid fel kommer utmatningen ifrån catch

                try
                {
                    int meny = Convert.ToInt32(menyVal);
                }
                catch
                {
                    Console.WriteLine("Fel! Du får bara skriva in nummer!");
                    Console.Beep();
                }
                // Bland alternativen använder jag Console.Clear() 
                // för att göra utmatningen renare. Console.ReadKey för skapa delay.
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
                        // Nollställning genom att skriva över strängen med en tom sträng
                         userInput = "";
                         Console.Write("Innuti strängen finns: ____");
                         Console.Write(userInput);
                         Console.Write("____ . Om det är tomt, Nollställd.");
                         Console.WriteLine(userInput);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        // hoppar ur loopen genom att deklarera myLoop som False;
                        myLoop = false;
                        break;

                    default:

                        break;
                }

            }
        }
        
    }

}
