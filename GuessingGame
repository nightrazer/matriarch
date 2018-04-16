using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames
{
    /*
     * I koden ska det finnas exception handlers genom Try och flera Catch exceptions
     * Exempelcis DivideByZeroExcepion e , Exception e
     * 
     * Du kan använda dig utav Int32.TryParse(Console.ReadLine(), out myNum
     * Men det är inte bra att myNum = 0; och enbart kan köras en gång.
     * Vi vill ha ett värde ifrån användaren!
     * 
     * Programmet ska beskrivas hur det är uppbyggt genom PseudoKod
     * Använd Draw.io https://www.draw.io
     * Strukturer markeras med versaler och fet sil (OM, ANNARS, SÅ LÄNGE)
     * Villkor markeras med kursiv text (OM vilkor, SÅ LÄNGE det här är sant)
     * Instruktioner markeras ine ut. (Skriv ut "Hej!")
     * 
     * Din uppgift blir sedan att se till att programmet kan köras utan körtidsfel.
     * För detta ska du använda dig av TryParse för att hantera inmatning.
     * 
     * Checklista:
     * 1) Felsök programmet
     * 2) Kommenterat alla fel i koden
     * 3) Skrivit och laddat upp pseudokod för min lösning
     * 4) Svarat på frågan om körtidsfel
     * 5) Laddat upp källkoden för mitt program
     */

    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            { 
                 displayMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Chose an option: ");
            Console.WriteLine("[1] Print Numbers");
            Console.WriteLine("[2] Guessing Game");
            Console.WriteLine("[3] View Hi-Scores");
            Console.WriteLine("[4] Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                HighScores();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }

            else
            {
                return true;
            }


        }
       

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Guessing Game: ");
            // Convert string to integer with Parse
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
                
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                incorrect = false;
                else{
                    Console.WriteLine("Wrong!");
                }

            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

    {

            }

            Console.ReadLine();
        }
        private static void HighScores()
        {
            // Spara en highscore-lista som sparar antalet gissningar mellan flera spelomgångar
            // Spara en lista på 10 Försök, Ange Datum
            // Bonus: Spara highscore till en txt.fil som läses in av programmet vid start
            // Bonus: Ge erbjudandet att Rensa Hi-score listan. 
            // Exempelvis skriva över fil innehållet.
            
        }
        private static void Player()
        {
            // Värdet på player ska nollställas för varje gång du spelar
            // PlayerScore = 0; alterantivt PlayerScore(""); för reset av värdet
            // Om spelaren skriver ett namn som redan finns, medela högsta tidigare
            // resultat och datumet, säg Lycka till!
        }
    }
}
