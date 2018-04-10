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
            /* Programmet är inte färdigt och är enbart en prototyp!
             * Den färdiga uppgiften planerar jag att lämna in under dagen.
             * 
             */

            // Meny systemet
            Menu();
            // Användardata  User();
            // Här igenom körs det huvudsakliga programmet.
            // Jag har haft problem med att konvertera strängar till siffror. Jag gör något fel.
            // Som en tillfällig fix så kan man välja ett/två/tre osv.
            User();

            Console.Read();
        }




        private static void Menu()
        {


            bool isRunning = true;
            while (isRunning)
            {

                // Meny systemet
                /* Programmet välkommnar användaren genom att centrera texten i konsollen
                 * genom att hämta strängen WelcomMessage, dela dem fönstrets bredd på två och längden
                 * av medelandet. Det är enbart kosmetiskt.
                 * 
                 * Startart Menusystemet så som vi gått igenom i menyprogrammet
                 * Om menyVal = 1 väljs så deklareras isRunning till false så lämnar den loopen och kör vidare på programmet.
                 * 
                 * 
                 * Väljs menyVal = 2 så avslutas programmet snällt genom Enviroment.Exit(0)
                 */

                string WelcomeMessage = "Välkommen till Backpacker";
                Console.WriteLine(
                    String.Format("{0,"
                    + ((Console.WindowWidth / 2)
                    + (WelcomeMessage.Length / 2))
                    + "}", WelcomeMessage));

                Console.WriteLine("\n\t[1] Börja Packa Ryggsäcken");
                Console.WriteLine("\t[2] Avsluta programmet");
                Console.Write("\tVälj: ");

                int menyVal = Convert.ToInt32(Console.ReadLine());
                // Console.ReadLine();

                if (menyVal == 1)
                {
                    // Lämnar loopen isRunning och forsätter köra programmet.
                    isRunning = false;

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
        private static void User()
        {
            Console.Write("Vad vill du packa ned i ryggsäcken?");
            Console.Write("\n4 Möjliga alternativ i denna array");
            Console.Write("\nDitt Val 1: \n");
            string myItem1 = Console.ReadLine();

            Console.Write("\nDitt Val 2: \n");
            string myItem2 = Console.ReadLine();

            Console.Write("\nDitt Val 3: \n");
            string myItem3 = Console.ReadLine();

            Console.Write("\nDitt Val 4: \n");
            string myItem4 = Console.ReadLine();



            Console.Clear();
            Console.Write("Din ryggsäck innehåller nu följande: \n");
            Console.WriteLine("\nEtt) " + myItem1 + "\nTvå) " + myItem2 + "\nTre) " + myItem3 + "\nFyra) " + myItem4);
            Console.WriteLine("\n");

            Console.WriteLine("Din ryggsäck är full, vill du ta bort någonting? Ja eller Nej");
            string myFirstChoice = Console.ReadLine();



            if (myFirstChoice == "Ja" || myFirstChoice == "ja")
            {
                Console.WriteLine("Okej, Vad ska jag kasta bort? välj 1 - 4");
                string Trashcan = Console.ReadLine();
                if (Trashcan == "ett" || Trashcan == "Ett")
                {
                    myItem1 = "";
                }
                else if (Trashcan == "Två" || Trashcan == "två")
                {
                    myItem2 = "";
                }
                if (Trashcan == "Tre" || Trashcan == "tre")
                {
                    myItem3 = "";
                }
                if (Trashcan == "Fyra" || Trashcan == "fyra")
                {
                    myItem4 = "";
                }

                Console.Clear();
                Console.WriteLine("\n1) " + myItem1 + "\n2) " + myItem2 + "\n3) " + myItem3 + "\n4) " + myItem4);
                Console.WriteLine("Är du nöjd?");
            }
            else if (myFirstChoice == "Nej" || myFirstChoice == "nej")
            {
                Console.WriteLine("Not yet implemented!");
            }
        }

    }
}
