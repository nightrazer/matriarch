using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ps. Inte Loggboken
namespace PersonalData_ListAccess
{
    class Logg
    {
        string rubrik;
        string inlägg;
        int platsID;
        int timestamp;
        public Logg(int platsID, string rubrik, string inlägg, int timestamp)
        {
            this.platsID = platsID;
            this.rubrik = rubrik;
            this.inlägg = inlägg;
            this.timestamp = timestamp;
        }
        // Egenskap för PlatsID
        public int PlatsID
        {
            get { return platsID; }
            set { platsID = value; }
        }
        // Egenskap för Rubrik
        public string Rubrik
        {
            get { return rubrik; }
            set { rubrik = value; }
        }
        // Egenskap för Inlägg
        public string Inlägg
        {
            get { return inlägg; }
            set { inlägg = value; }
        }
        // Egenskap för Timestamp
        public int Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }


       
        class Program
        {
            static int LinearSearch(List<Logg> list, int key)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].PlatsID == key)
                        return i;
                }
                return -1;


            }
            static void Main(string[] args)
            {
                List<Logg> myList = new List<Logg>();
                myList.Add(new Logg(1, "Dagens rubrik", "Det här är vad som har hänt idag", 20180430));
                myList.Add(new Logg(2, "Förra veckans nytt", "Det här är vad som har hänt förra veckan", 20180430));
                myList.Add(new Logg(3, "Testrubrik3", "Det här är vad som har hänt förra månaden", 20180430));
                myList.Add(new Logg(4, "Julen närmar sig", "Julklappar", 2018120));
                myList.Add(new Logg(5, "Minrubrik5", "Hittat ett jobb", 20180430));
                myList.Add(new Logg(6, "Minrubrik6", "Börjat träna igen", 20180430));
                myList.Add(new Logg(7, "Minrubrik7", "Blivit sjuk igen", 20180430));
                myList.Add(new Logg(8, "Minrubrik8", "Konferrens planerad, peppad!", 20180430));
                myList.Add(new Logg(9, "Minrubrik9", "Nya recept", 20180704));
                myList.Add(new Logg(10, "Minrubrik10", "Nytt datorinköp", 20190812));

                Console.Write("Välj bland lnlägg 1 - 10: ");
                string mySearch = Console.ReadLine();
                int key = Convert.ToInt32(mySearch);
                int index = LinearSearch(myList, key);

                if (index == -1) {
                    Console.WriteLine("\tRubriken hittades inte!");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("\n\tplats : " 
                        + index 
                        + "\n" + "\tDatum: " + myList[index].timestamp
                        + "\n\tRubrik: "
                        + myList[index].rubrik
                        + "\n\t" + myList[index].inlägg);

                    Console.ReadLine();
                    }
                }

            }

        }
    }

