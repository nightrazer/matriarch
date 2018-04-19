using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearStringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Numplace = new string[6]
              {
                    "Alpha", "Beta", "Centa", "Delta", "Epsilon", "Felix"
              };
            int i = 0;
            int[] MyWallet = new int[2]
            {
                500, 32000
            };

            bool MainMenu = true;
            while (MainMenu) {
                Console.WriteLine("[1] Add / Remove");
                Console.WriteLine("[2] Show Integers / Strings");
                Console.WriteLine("[3] Search Integers / Strings");
                Console.WriteLine("[4] End Program");
                Console.Write("Choice: ");
                string MenuChoice = Console.ReadLine();
                try
                {
                    int Tester = Convert.ToInt32(MainMenu);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.Beep();
                }
                string OneorOther;
                string TheList; 

                switch (MenuChoice)
                {
                    case "1":
                        Console.Write("Do you want to (A)dd or (R)emove: ");
                        OneorOther = Console.ReadLine();
                            if ( OneorOther == "A" || OneorOther == "a")
                        {
                            Console.Write("Pick 1 - 6: ");
                            TheList = Console.ReadLine();
                            Console.Write("What would you like to add? ");
                            switch (TheList)

                            {
                                case "1":
                                    Numplace[0] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[0]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Numplace[1] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[1]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Numplace[2] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[2]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    Numplace[3] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[3]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Numplace[4] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[4]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "6":
                                    Numplace[5] = Console.ReadLine();
                                    Console.WriteLine("Added " + Numplace[5]);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    break;
                            }
                            
                        }
                            else if (OneorOther == "R" || OneorOther == "r")
                        {
                            Console.WriteLine("Pick 1 - 6 or ALL: ");
                            TheList = Console.ReadLine();
                            switch (TheList)

                            {
                                case "1":
                                    Numplace[0] = " ";
                                    break;
                                case "2":
                                    Numplace[1] = " ";
                                    break;
                                case "3":
                                    Numplace[2] = " ";
                                    break;
                                case "4":
                                    Numplace[3] = " ";
                                    break;
                                case "5":
                                    Numplace[4] = " ";
                                    break;
                                case "6":
                                    Numplace[5] = " ";
                                    break;
                                case "ALL":
                                    Numplace[0] = " ";
                                    Numplace[1] = " ";
                                    Numplace[2] = " ";
                                    Numplace[3] = " ";
                                    Numplace[4] = " ";
                                    Numplace[5] = " ";
                                    break;
                                default:
                                    break;
                            }
                        }
                            else
                        {

                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Show (I)ntegers or (S)trings: ");
                         OneorOther = Console.ReadLine();
                        Console.Clear();
                        if (
                            OneorOther == "I" ||
                            OneorOther == "i"
                           )
                        {
                            Console.WriteLine("My Wallet: " + MyWallet[0]);
                            Console.WriteLine("My Bankaccount: " + MyWallet[1]);
                        }
                        else if (
                            OneorOther == "S" ||
                            OneorOther == "s")
                        {
                            foreach (var item in Numplace)
                            {
                                if (i < 6)
                                {
                                    Console.Write("(" + i++ + ") ");
                                }
                                else
                                {

                                }
                                Console.WriteLine("[" + item + "]");
                               
                            }
                            Console.WriteLine("");
                        }
                        else
                        {

                        }

                        break;
                    case "3":
                        Console.Write("Search: ");
                        string searchWord = Console.ReadLine();
                        {
                            if (Numplace[i].ToUpper() == searchWord.ToUpper())
                                Console.WriteLine("Found (" + Numplace[i] + ")\n");
                        }

                        break;
                    case "4":
                        MainMenu = false;
                        break;

                    default:
                        break;
                }








               
            }
            Console.ReadLine();
        }
        
    }
}
