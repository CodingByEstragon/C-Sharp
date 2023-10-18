namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Grundgerüst einer while Schleife
            //Intialisierung;
            //do
            //{
            //    Anweisung;
            //    Variablenveränderung;
            //} while (Bedingung);

            // Endlosschleife
            //int anzahl = 5;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //} while (i < anzahl);

            // einfach while Schleife
            //int anzahl = 5;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < anzahl);

            // Anwendungsbeispiel for Schleife in while Schleife umschreiben
            int zwsumme = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                int zahl = Convert.ToInt32(Console.ReadLine());

                //zwsumme += zahl;
                zwsumme = zwsumme + zahl;
                Console.WriteLine("Summe: " + zwsumme);
                i++;
            } while (i < 4);
        }
    }
}
