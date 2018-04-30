using System;

namespace ListHantering
{
    public class SumOfValues
    {
        
        static void Main()
        {
            Console.WriteLine("Nedan följer exempel på hantering av och åtkomst av integers i en lista\n");
            Sum(1, 2, 3);
            Sum(9, 12, 16, 21, 24);

            Console.ReadLine();
            // publik klass, alla värden är åtkomstbara
            // Programmet kör igenom första listan Sum(1, 2, 3);
            // I första varvet av programmet, och i nästa varav kör den Sum(1, 2, 3, 4, 5);
        }
        static void Sum(params int[] list)
        {
          
            Console.WriteLine("Det finns {0} Föremål i listan", list.Length);
            int sum = 0;
            foreach (int i in list)
            {
                sum = sum + i;
            }
            Console.WriteLine("deras sammanlagda värde är: {0}\n", sum);
            int key = 3;
            int key2 = 12;
            // målvärdet är 5, key.
            // Jag går igenom hela listan linjärt
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == key)
                    // om någon plats i listan innehållet värdet i key
                    // mata ut det på skärmen, och platsen i listan med integern i
                {
                    Console.WriteLine("elementet " + key + " finns på indexplats: " + i);
                    break;
                }
                else if (list[i] == key2)
                {
                    Console.WriteLine("elementet " + key2 + " finns på indexplats: " + i);
                    break;
                }
            }
            // Alternativt kan jag använda mig av persondata
            
        }
        
    }
}
