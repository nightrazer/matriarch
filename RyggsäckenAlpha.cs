using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAndStore
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Jag har haft mycket problem med få ett väl fungerande program och det saknas
             * ännu kod för att få det att fungera bra med metoder och klasser.
             * Jag råkade också i min hast lämna in ett defekt program, vilket inte är så kul..
             * Denna variant skrev jag ursprungligen på engelska som ClearAndStore
             * då jag gjorde många utgåvor av ryggsäcken.
             * 
             * TryParse finns inte med som en del i felsöknings processen hellter tyvärr.
             * Felen i min kod har uppkommit efter att jag gjort ändringar i min kod
             * som inte fungerat bra tillsammans med andra delar utav min kod.
             * --- Simon 2018-04-23  00:31
             * Gjort fler korrigeringar 2018-04-23 13:55
             */ 
            string[] myMenu = new string[5]
               {
                    "Tangentbord", "", "", "", ""
               };


            bool MainLoop = true;
            while (MainLoop) {
                Console.WriteLine("\tVälkommen till Ryggsäcken");
                Console.WriteLine("\t\tHuvudMeny\n");
                Console.WriteLine("\t[1] Skriv ut listan");
                Console.WriteLine("\t[2] Lägg till / Ta bort");
                Console.WriteLine("\t[3] Rensa listan");           
                Console.WriteLine("\t[4] Sök");
                Console.WriteLine("\t[5] Avsluta programmet");
                Console.Write("\tVälj: ");
                string MenuChoice = Console.ReadLine();
                try
                {
                    int Test = Convert.ToInt32(MainLoop);
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                switch (MenuChoice)
                {
                    case "1":
                      
                        for (int i = 0; i < myMenu.Length;)
                        {
                            // Felsäker gardering genom att ange en tom sträng,
                            // öppen sträng och värdet null.
                            if (myMenu[i] == "" || myMenu[i] == " " || myMenu[i] == null)
                            {
                                Console.WriteLine("\tDet finns inga föremål i listan");
                                break;
                            }
                            else
                            {
                                // Skriver ut nummerplaceringar för varje del av menyn från 0 - 4
                                // Markerade som 1 - 5
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tUtskrift\n");

                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);

                                break;
                            }
                            
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Lägg till något på plats 1 - 5
                        // Valet från första menyn här sparas in till AddWord
                        Console.WriteLine("\tVälkommen till Ryggsäcken");
                        Console.WriteLine("\t\tLägg till / Ta bort\n");

                        Console.WriteLine("\t[1] " + myMenu[0]);
                        Console.WriteLine("\t[2] " + myMenu[1]);
                        Console.WriteLine("\t[3] " + myMenu[2]);
                        Console.WriteLine("\t[4] " + myMenu[3]);
                        Console.WriteLine("\t[5] " + myMenu[4]);
                        Console.Write("\tVälj mellan plats 1 - 5 på vad du vill lägga till:  ");
                        string AddWord = Console.ReadLine();
                       
                        try
                        {
                            int Test = Convert.ToInt32(AddWord);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\tEnbart 1 - 5 är giltiga val");
                        }

                        // Strängen Add kommer att användas för denna menydel av programmet
                        string Add;
                        switch (AddWord)
                        {
                            // Add hämtar föremålet. lägger sedan till till på rätt plats. position 0 innebär 1 exempelvis
                            // myMenu[0] anger position 0
                            // om föremålet är en tom sträng, användaren inte anger något så tas föremålet bort.
                            // Jag har provat mig fram genom att ha en separat del för bortagning via
                            // en inre switch meny och ett separat sök och ta bort system.
                            // Efter olika ändringar så blev programmet för buggigt så jag valde denna metod till slut.
                            case "1":
                                Console.WriteLine("\tVad vill du lägga till? Välj inget för att ta bort från platsen. ");
                                Console.Write("\tNamnge ditt föremål: ");
                                // Lagrar värden i Add
                                Add = Console.ReadLine(); 
                                myMenu[0] = Add;
                                // likställer värdet i Add med värdet på MyMeny array
                                if (Add == "" || Add == " " || Add == null)
                                {
                                    Console.WriteLine("\tTömmer innehållet på plats " + AddWord);
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tLägg till / Ta bort\n");

                                Console.Write("\tLagt till => " + myMenu[0] + "\n");
                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);
                                break;
                            case "2":
                                Console.WriteLine("\tVad vill du lägga till? Välj inget för att ta bort från platsen. ");
                                Console.Write("\tNamnge ditt föremål: ");
                                Add = Console.ReadLine();
                                myMenu[1] = Add;
                                if (Add == "" || Add == " " || Add == null)
                                {
                                    Console.WriteLine("\tTömmer innehållet på plats " + AddWord);
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tLägg till / Ta bort\n");

                                Console.Write("\tLagt till => " + myMenu[1] + "\n");
                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);
                                break;
                            case "3":
                                Console.WriteLine("\tVad vill du lägga till? Välj inget för att ta bort från platsen. ");
                                Console.Write("\tNamnge ditt föremål: ");
                                Add = Console.ReadLine();
                                myMenu[2] = Add;
                                if (Add == "" || Add == " " || Add == null)
                                {
                                    Console.WriteLine("\tTömmer innehållet på plats " + AddWord);
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tLägg till / Ta bort\n");

                                Console.Write("\tLagt till => " + myMenu[2] + "\n");
                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);
                                break;
                            case "4":
                                Console.WriteLine("\tVad vill du lägga till? Välj inget för att ta bort från platsen. ");
                                Console.Write("\tNamnge ditt föremål: ");
                                Add = Console.ReadLine();
                                myMenu[3] = Add;
                                if (Add == "" || Add == " " || Add == null)
                                {
                                    Console.WriteLine("\tTömmer innehållet på plats " + AddWord);
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tLägg till / Ta bort\n");

                                Console.Write("\tLagt till => " + myMenu[3] + "\n");
                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);
                                break;
                            case "5":
                                Console.WriteLine("\tVad vill du lägga till? Välj inget för att ta bort från platsen. ");
                                Console.Write("\tNamnge ditt föremål: ");
                                Add = Console.ReadLine();
                                myMenu[4] = Add;
                                if (Add == "" || Add == " " || Add == null)
                                {
                                    Console.WriteLine("\tTömmer innehållet på plats " + AddWord);
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine("\tVälkommen till Ryggsäcken");
                                Console.WriteLine("\t\tLägg till / Ta bort\n");

                                Console.Write("\tLagt till => " + myMenu[4] + "\n");
                                Console.WriteLine("\t[1] " + myMenu[0]);
                                Console.WriteLine("\t[2] " + myMenu[1]);
                                Console.WriteLine("\t[3] " + myMenu[2]);
                                Console.WriteLine("\t[4] " + myMenu[3]);
                                Console.WriteLine("\t[5] " + myMenu[4]);
                                break;
                            default:
                                break;
                        }


                        Console.ReadKey();
                        Console.Clear();


                        break;
                    case "3":
                        Console.WriteLine("\tVälkommen till Ryggsäcken");
                        Console.WriteLine("\t\tRensa listan\n");
                        for (int i = 0; i < myMenu.Length; i++)
                        {
                            // Ersätter innehållet i alla strängar ( 0 - 4 ) med ""
                            myMenu[i] = "";
                        }
                        Console.WriteLine("\tAll föremål är bortagna");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("\tSök: ");
                        string SearchWord = Console.ReadLine();
                        // räknar igenom hela arrayn från 0 - storleken av menyn vilket gör att
                        // detta utryck inte behöver skrivas om, när den blir större.
                        for (int i = 0; i < myMenu.Length; i++)
                        {
                            // Tolkar texten som stora bokstäver på det inmatade ordet
                            // och det sökta ordet så det inte blir några matchingsproblem
                            if (myMenu[i].ToUpper() == SearchWord.ToUpper() && myMenu[i] != "")
                            {
                                Console.WriteLine("\tHittade: " + myMenu[i]);
                            }



                            else if (myMenu[i].ToUpper() == SearchWord.ToUpper())
                            {
                                // Jag planerade att lägga till att de ska lista upp hur
                                // passa många matchningar som hittades i denna array
                                Console.Clear();
                                Console.Write("\tHittade inget");
                                // break;
                               
                            }
                            



                        }
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "5":
                        Console.WriteLine("\tAvslutar programmet, var god tryck på Enter.");
                        // Loopen är inte längre sann. MainLoop =! true;
                        MainLoop = ! true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
               


            }
            
           
        }
    }
}
