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


                string userInput = "";
                switch (menyVal)
                {
                    case "1":
                        Console.Write("Skriv något: ");
                        userInput = Console.ReadLine();
                        // Console.Write(userInput);
                        // break;
                        continue;
                    case "2":
                         
                         Console.WriteLine(userInput);
                   
                        break;
                            
                    case "3":
                        // Nollställning
                        // userinput = "";
                        Console.Write("Inside string is: ____" + userInput + "____ If blank it is removed");
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
