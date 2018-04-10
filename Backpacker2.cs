using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpacker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meny systemet
            // Mitt program är uppbyggt av 3st metoder
            // Welcome som enbart välkommnar användaren. Tanken har varit att denna ska visa sig som en
            // Titel hela tiden, men jag fick inte till det riktigt. Jag provade Boolean.
            //
            // Nästa steg är huvudmenyn som körs genom metoden Menu
            // Vidare sen till huvudprogrammet som körs under metoden Choices
            // Tanken har varit att koden på detta vis ska bli mer återanvändningsbar
            // Detta har gjort genom att lägga dessa att skapa private static void metoder.
            //
            // Choices blev så stor då Variablerna myItem1 - MyItem4 hamnar annars utanför scope
            // vilket gör att det inte kan användas. De har kastats ur minnet in i garbage collectorn.
            // Därför måste de användas inom samma kodblock.
            
            // Dessa metoder kallas i lämplig ordning innifrån Main metoden

            Welcome();
            Menu();
            Choices();
            Console.Read();
        }


        private static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string WelcomeMessage = "Välkommen till Backpacker";
            Console.WriteLine(
                String.Format("{0,"
                + ((Console.WindowWidth / 2)
                + (WelcomeMessage.Length / 2))
                + "}", WelcomeMessage));
            
        }
            


        private static void Menu()
        {
            bool isMenuSystemRunning = true;
            while (isMenuSystemRunning)
            {

                // Meny systemet
                

                Console.WriteLine("\n[1] Börja Packa Ryggsäcken");
                Console.WriteLine("[2] Avsluta programmet");
                Console.Write("Välj: ");
                /* int menyVal;
                 * Jag provade här att använda Exceptions handlers, men fick det inte att fungera.
                 * 
                string strmenyVal = Console.ReadLine();
                try
                {
                    int menyValTest = Convert.ToInt32(strmenyVal);
                    isMenuSystemRunning = false;
                }
                catch
                {
                    Console.Write("Funkar inte");
                }
            } while (isMenuSystemRunning);
            */

                int menyVal = Convert.ToInt32(Console.ReadLine());
                
                
              
               

                if (menyVal == 1)
                {
                    // Lämnar loopen isRunning och forsätter köra programmet.
                    isMenuSystemRunning = false;

                    Console.WriteLine("Då kör vi!");
                    Console.Clear();
                }
                else if (menyVal == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    // Ange värdet mellan 1 - 2
                    Console.Clear();
                }
            }








        }
        private static void Choices()
        {
            // Användaren får mata en vad vad de vill lägga ned i ryggsäcken.
            // Detta kommer sedan att spara i myItem1, myItem2, myItem3, myItem4
            // i formen av en sträng

            Console.Write("Vad vill du packa ned i ryggsäcken?");
            Console.Write("\nDu kan packa ned 4 saker i ryggsäcken\n");

            Console.Write("Ditt Val 1: ");
            string myItem1 = Console.ReadLine();

            Console.Write("Ditt Val 2: ");
            string myItem2 = Console.ReadLine();

            Console.Write("Ditt Val 3: ");
            string myItem3 = Console.ReadLine();

            Console.Write("Ditt Val 4: ");
            string myItem4 = Console.ReadLine();
            // Rensar skärmen med Console.Clear()
            Console.Clear();

            // Visar användaren vad som finns i Variablerna genom att skriva ut dem i en lista.
            Console.Write("Din ryggsäck innehåller nu följande: ");
            Console.WriteLine("\n\t[1] " + myItem1 + "\n\t[2] " + myItem2 + "\n\t[3] " + myItem3 + "\n\t[4] " + myItem4);

            // Släng processen. Användaren kan slänga de som finns i myItem1 - MyItem4
            // Genom att ange 1 - 4. Om användaren matar in ett värde över 4 eller under eller lika med 0 så avslutas programmet.
            Console.Write("Din ryggsäck är full, vill du ta bort någonting? Ja eller Nej: ");

            string myFirstChoice = Console.ReadLine();
            if (myFirstChoice == "Ja" || myFirstChoice == "ja")
            {
                Console.Write("Okej, Vad ska jag kasta bort? 1 - 4: ");
                Console.Clear();

                Console.WriteLine("\n\t[1] " + myItem1 + "\n\t[2] " + myItem2 + "\n\t[3] " + myItem3 + "\n\t[4] " + myItem4);
                bool TrashisRunning = true;
                while (TrashisRunning)
                {

                    // Meny systemet

                    Console.WriteLine("\nVad vill du kasta?");
                    Console.Write("Välj 1 - 4: ");
                    int Trash = Convert.ToInt32(Console.ReadLine());
                    // Testar Exception handlers
                    /*
                     * Jag fick det inte att fungera denna gång.
                    try
                    {
                        int CheckTrash = Convert.ToInt32(Trash);
                    }
                    catch
                    {
                        Console.WriteLine("Du kan enbart välja siffror");
                    }
                    */

                    if (Trash == 1)
                    {
                        myItem1 = "";
                        Console.Clear();
                        Console.WriteLine("Just nu finns följande saker i ryggsäcken. För att avsluta programmet välj 5 eller mer");
                        Console.WriteLine("\n[1] " + myItem1 + "\n[2] " + myItem2 + "\n[3] " + myItem3 + "\n[4] " + myItem4);
                    }
                    else if (Trash == 2)
                    {
                        myItem2 = "";
                        Console.Clear();
                        Console.WriteLine("Just nu finns följande saker i ryggsäcken. För att avsluta programmet välj 5 eller mer");
                        Console.WriteLine("\n[1] " + myItem1 + "\n[2] " + myItem2 + "\n[3] " + myItem3 + "\n[4] " + myItem4);
                    }
                    else if (Trash == 3)
                    {
                        myItem3 = "";
                        Console.Clear();
                        Console.WriteLine("Just nu finns följande saker i ryggsäcken. För att avsluta programmet välj 5 eller mer");
                        Console.WriteLine("\n[1] " + myItem1 + "\n[2] " + myItem2 + "\n[3] " + myItem3 + "\n[4] " + myItem4);
                    }
                    else if (Trash == 4)
                    {
                        myItem4 = "";
                        Console.Clear();
                        Console.WriteLine("Just nu finns följande saker i ryggsäcken. För att avsluta programmet välj 5 eller mer");
                        Console.WriteLine("\n[1] " + myItem1 + "\n[2] " + myItem2 + "\n[3] " + myItem3 + "\n[4] " + myItem4);
                    }
                    else if (Trash < 5 || Trash >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Tack för att du provade BackPacker!");
                        TrashisRunning = false;
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Tack för att du provade BackPacker!");
                        TrashisRunning = false;
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Tack för att du provade BackPacker!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
        }

    }

}

