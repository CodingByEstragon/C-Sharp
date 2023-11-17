namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // foreach Schleife
            //Datentyp[] Arrayname = new Datentyp[] { wert1, wert2, wert3 };
            //foreach(Datentyp Variablenname in Arrayname)
            //{
            //    Console.WriteLine(Variablenname);
            //}

            // zwei einfache Beispiele
            string[] firstname = new string[] { "Laura", "Mike", "Sarah" };
            foreach (string name in firstname)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-------------------------");

            int[] zahl = new int[3];
            zahl[0] = 12;
            zahl[1] = 13;
            zahl[2] = 14;
            foreach(int zahlen in zahl)
            {
                Console.WriteLine(zahlen);
            }
        }
    }
}
