namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Grundgerüst einer while Schleife
            //Intialisierung;
            //while (Bedingung)
            //{
            //    Ausgabe;
            //    Variablenveränderung;
            //}

            // Endlosschleife
            //int anzahl = 5;
            //int i = 0;
            //while (i < anzahl)
            //{
            //    Console.WriteLine(i);
            //}

            // einfach while Schleife
            //int anzahl = 5;
            //int i = 0;
            //while (i < anzahl)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Anwendungsbeispiel for Schleife in while Schleife umschreiben
            int zwsumme = 0;
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                int zahl = Convert.ToInt32(Console.ReadLine());

                //zwsumme += zahl;
                zwsumme = zwsumme + zahl;
                Console.WriteLine("Summe: " + zwsumme);
                i++;
            }
        }
    }
}
