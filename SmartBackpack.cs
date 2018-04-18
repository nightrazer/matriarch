using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackpack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BackpackArray = new string[9] {
                /*
                "Alpha", "Beta", "Ceta",
                "Delta", "Epsilon", "Feta",
                "Gamma", "Helios", "Iris",
                "Jango"
                Funkar!
                */
                // Tom ryggsäck
                "", "", "",
                "", "", "",
                "", "", ""
                
            };

            int BackpackContent = 10;
            string[] Backpack = new string[BackpackContent];

            int Wallet = 0;


            bool MainMenu = true;
            while (MainMenu)
            {
                Console.WriteLine("\tDen smarta Ryggsäcken - Alpha Versionen\n");
                // Console.WriteLine("\t[1] Lägg till ett föremål");
                Console.WriteLine("\t[1] Fyll upp ryggsäcken");
                Console.WriteLine("\t[2] Skriv ut alla föremål");
                Console.WriteLine("\t[3] Sök i Ryggsäcken");
                Console.WriteLine("\t[4] Rensa Ryggsäcken");
                Console.WriteLine("\t[5] Avsluta");
                Console.WriteLine("\t[6] Ta bort specifika föremål");
                Console.WriteLine("\t[7] Lägg till specifika föremål");
                Console.Write("\tVälj: ");
                string MenuChoice = Console.ReadLine();

                try
                {
                    int MainMenuTester = Convert.ToInt32(MainMenu);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Message");
                    Console.Beep();
                }


                // TEST!
                
                switch (MenuChoice)
                {
                    case "1":
                        // Console.WriteLine("Välj en plats där du vill lägga till ditt föremål");
                        // Console.WriteLine("Du kan välja mellan plats 1 - 10");
                        // Lista upp föremålen i BackpackerArray med 1 - 10
                        // Med dess nuvarande innehåll.
                        // Lista rött För Siffervärden
                        // Om användaren väljer en plats där det redan finns något
                        // Meddela användaren att platsen är upptagen
                        // Fråga om han vill byta ut föremålet?
                        // OM ja, Rensa den specifka föremålet i array.
                        // Plats 10 ska enbart kunna läggas mynt i, kallar den plånboken.
                        // Fyller upp den här Temporärt, för buggtestning, tar bort sen.
                        Console.WriteLine("Fyller upp din Ryggsäck med ord");
                        BackpackArray[0] = "ALPHA";
                        BackpackArray[1] = "BETA";
                        BackpackArray[2] = "ZETA";
                        BackpackArray[3] = "DELTA";
                        BackpackArray[4] = "EPSILON";
                        BackpackArray[5] = "THETA";
                        BackpackArray[6] = "GAMMA";
                        BackpackArray[7] = "HELIOS";
                        BackpackArray[8] = "IRIS";
                        // BackpackArray[9] = "Jango";
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        foreach (var item in BackpackArray)
                        {
                            Console.Write("(" + item + ") ");
                        }
                        Console.WriteLine("\n" + "\tDu har " + Wallet + " Kr" + " " + "kvar i plånboken\n");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("Sökning: ");
                        string SearchWord = Console.ReadLine();
                        for (int i = 0; i < BackpackArray.Length; i++)
                        {
                            if (BackpackArray[i] == SearchWord.ToUpper())
                            Console.Write(BackpackArray[i] + " ");
                            
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        BackpackArray[0] = "";
                        BackpackArray[1] = "";
                        BackpackArray[2] = "";
                        BackpackArray[3] = "";
                        BackpackArray[4] = "";
                        BackpackArray[5] = "";
                        BackpackArray[6] = "";
                        BackpackArray[7] = "";
                        BackpackArray[8] = "";
                        //  BackpackArray[9] = "";
                        Console.WriteLine("Ryggsäcken är nu tömd!");
                        foreach (var item in BackpackArray)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "5":
                        
                        Console.Clear();
                        MainMenu = false;
                        break;

                    case "6":
                        // Remove specific objects
                        Console.WriteLine("");
                        string RemoveWord = Console.ReadLine();
                        for (int i = 0; i < BackpackArray.Length; i++)
                        {
                            if (BackpackArray[i] == RemoveWord.ToUpper())
                                Console.Write(BackpackArray[i] = " ");
                            Console.WriteLine("Välj ett föremål som du vill ta bort: ");
                        }

                        Console.Clear();
                        break;

                    case "7":
                        // Add specific objects         
                        foreach (var item in BackpackArray)
                        {
                            Console.Write("(" + item + ") ");
                        }
                        Console.WriteLine("Välj vilken plats du vill lägga till en sak på.");
                        Console.Write("Skriv: exit för att avsluta. Välj 1 - 9: ");
                        string AddStorage = Console.ReadLine();
                        Console.Write("Vad vill du lägga in? ");
                        bool StorageBox = true;
                        while (StorageBox)
                        {

                        
                            switch (AddStorage)
                            {
                                case "1":
                                    BackpackArray[0] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "2":
                                    BackpackArray[1] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "3":
                                    BackpackArray[2] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "4":
                                    BackpackArray[3] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "5":
                                    BackpackArray[4] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "6":
                                    BackpackArray[5] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "7":
                                    BackpackArray[6] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "8":
                                    BackpackArray[7] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "9":
                                    BackpackArray[8] = Console.ReadLine();
                                    StorageBox = false;
                                    break;
                                case "exit":
                                    StorageBox = false;
                                    break;

                                default:
                                    StorageBox = false;
                                    break;
                                   
                            }
                        }
                        Console.Clear();
                         break; 
                        // continue;
                    default:
                        break;

                }
            }           

        }

    }

}
