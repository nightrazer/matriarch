using System; // system måste anges som System

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1 , 20); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            // Lade till int speltal = slumpat.Next(1 , 20); istället för int speltal = slumpat.Next();
            int Gissningar = 0;
            bool Fel = true;


            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela) // För att loppen ska köras är det nödvändigt att den är sann medans den kör
                          // ändrade (!spela) till (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                int tal = Convert.ToInt32(Console.ReadLine());

                if (tal < speltal)
                {
                   
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                    string resultat = Console.ReadLine();
                    Gissningar++;
                }

                else if (tal > speltal) // ändrat till en else if
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                    string resultat = Console.ReadLine();
                    Gissningar++;
                    // Console.WriteLine("\tDet inmatade talet " + tal  " är för stort, försök igen.");
                    // Strängen saknade ett plus för att addera ihop sista strängen
                }

                else if (tal == speltal) // (tal = speltal) är felaktigt angiven. Cannot convert int to bool
                {
                    // prövar (tal == speltal)
                    // ändrat till en else if
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    Console.WriteLine("\tDet tog dig {0} gissningar", Gissningar);
                    
                    Gissningar++;

                spela = false;

                Console.ReadLine();
                }
                else{
                    Console.WriteLine("Something wrong");
                }
            }
        }
    }
}
