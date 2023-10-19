namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Grundgerüst einer Do While Schleife
            //Initialisierung;
            //do
            //{
            //    Anweisung;
            //    Variablenveränderung;
            //} while (Bedingung);

            // Endlosschleife
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    // Variablenveränderung
            //} while (i < 5);

            // einfach Do While Schleife
            //int anzahl = 7;
            //int zahl = 0;
            //do
            //{
            //    Console.WriteLine(zahl);
            //    zahl++;
            //} while (zahl < anzahl);

            // Anwendungsbeispiel while Schleife in do while Schleife umschreiben
            //int zwsumme = 0;

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Gib eine Zahl ein: ");
            //    int zahl = Convert.ToInt32(Console.ReadLine());

            //    //zwsumme += zahl;
            //    zwsumme = zwsumme + zahl;
            //    Console.WriteLine("Summe: " + zwsumme);
            //    i++;
            //} while (i < 4);

            // Durschnitt berechnen
            double zwsumme = 0.0;
            int anzahl = 5;

            int i = 0;
            do
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                double zahl = Convert.ToDouble(Console.ReadLine());

                zwsumme += zahl;
                i++;
                Console.WriteLine("Durchschnitt: " + zwsumme / anzahl);

            } while(i < anzahl);
        }
    }
}
