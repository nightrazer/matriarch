using System; // system måste anges som System

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1 , 21); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            // Lade till int speltal = slumpat.Next(1 , 20); istället för int speltal = slumpat.Next();
            int Gissningar = 0;
           // bool Fel = true;


            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela) // För att loppen ska köras är det nödvändigt att den är sann medans den kör
                          // ändrade (!spela) till (spela)
            {
                
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
               // int tal = Convert.ToInt32(Console.ReadLine());
               // Denna kod med TryParse förhindrar felaktig utmatning
               // Koden ger ett fel som jag upptäckt. Vid inmatning av flyt-tal så registreras
               // det som 0. Jag hade planer på att skapa en avrundning till närmaste heltal
               // och fånga det upp på något sätt.
             if (Int32.TryParse(Console.ReadLine(), out int tal)){

                   // Console.WriteLine("Det här fungerar!");
                }  
           //  else if (tal == 0) {
           //         Console.WriteLine("\tFelaktig inmatning");
           //   }

             else 
                {
                    //    Console.Write("\tDu kan enbart skriva in heltals siffror!\n");
   
                }


                if (tal < speltal)
                {
                   // hur får jag bort att 0 matas ut? Jag la in det under jämförelsen
                   // där talet bli 0 vid felaktig utmatning. Om det är ett giltigt värde
                   // körs istället else satasen som säger att värdet är för litet.
                   if (tal == 0)
                    {
                        Console.Write("\tFelaktig inmatning, Du kan enbart välja heltals siffror!");
                    }
                    else
                    {
                        Console.Write("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                        string resultat = Console.ReadLine(); // användarens gissade värde sparas här
                        Gissningar++; // Ökar Antalet gissningar med +1
                    }
                  
                }

                else if (tal > speltal) // ändrat till en else if
                {
                    Console.Write("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                    string resultat = Console.ReadLine(); // användarens gissade värde sparas här
                    Gissningar++; // Ökar Antalet gissningar med +1
                    // Console.WriteLine("\tDet inmatade talet " + tal  " är för stort, försök igen.");
                    // Strängen saknade ett plus för att addera ihop sista strängen
                }

                else if (tal == speltal) // (tal = speltal) är felaktigt angiven. Cannot convert int to bool
                {
                    Gissningar++; // Ökar Antalet gissningar med +1
                    // prövar (tal == speltal)
                    // ändrat till en else if
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    Console.WriteLine("\tDet tog dig {0} antal gissningar", Gissningar);
                    
                    spela = false; // loppen spela avslutas och programmet avslutas.
                    // Tyvärr loopas inte programmet för flera spelningar emot en hi-score lista.
                Console.ReadLine();
                    Environment.Exit(0); // Avslutar programmet
                }
                else{
                    Console.WriteLine("Något gick fel. Felkod FF#66251");
                    // Om någontins oväntat händer så skrivs detta ut, paus för knapptryckning + return.
                    // Programmet avslutas sedan.
                    Console.ReadLine();
                    // Environment.Exit(0);
                    spela = false;
                }
            }
        }
    }
}
