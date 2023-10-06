namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Grundgerüst einer For Schleife
            //for (Initialsierung; Bedingung; Variablenveränderung)
            //{
            //    Console.WriteLine();
            //}

            // einfache For Schleife
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Endlosschleife
            //for (int zahl = 0; zahl < 10;)
            //{
            //    Console.WriteLine(zahl);
            //}

            int zwsumme = 0;

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                int zahl = Convert.ToInt32(Console.ReadLine());

                //zwsumme += zahl;
                zwsumme = zwsumme + zahl;
                Console.WriteLine("Summe: " + zwsumme);
            }
        }
    }
}
