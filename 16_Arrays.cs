using System;
using System.Reflection;

namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Arrays
            //Datentyp[] Arrayname = new Datentyp[Arraygröße];
            //Arrayname[index] = wert;

            ////                                        0      1      2
            //Datentyp[] Arrayname = new Datentyp[] { wert1, wert2, wert3};
            //Arrayname[index] = wertveränderung;

            // statischer Array
            int[] zahlen = new int[3];
            zahlen[0] = 6;
            zahlen[1] = 12;
            zahlen[2] = 26;
            //zahlen[3] = 26; // <--- IndexOutOfRangeException
            Console.WriteLine(zahlen[2]);
            Console.WriteLine(zahlen.Length);

            Console.WriteLine("-------------------");

            // dynamischer Array                        0                       1              2        3
            string[] name = new string[] { "@Lp_Estragon auf Twitch", "@Lp.estragon auf YT", "Lara", "Sarah" };
            Console.WriteLine(name[1]);
            name[1] = "Jack";
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name.Length);

            Console.WriteLine("-------------------");

            // Anwendungsbeispiel
            Console.WriteLine("Gib eine Anzahl ein: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            int[] zahl = new int[anzahl];

            int i = 0;
            while (i < zahl.Length)
            {
                zahl[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            int summe = 0;
            for (int no = 0; no < zahl.Length; no++)
            {
                summe += zahl[no];
            }

            Console.WriteLine("Der Durchschnitt ist: " + (double)summe / zahl.Length);
        }
    }
}
