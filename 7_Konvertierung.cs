namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // implizite Konvertierung
            int zahl = 3;
            zahl = 6;
            Console.WriteLine("Ganze Zahl: " + zahl);
            double zahl2 = zahl;
            zahl2 = 12.4;
            Console.WriteLine("Gleitkommazahl: " + zahl2);

            Console.WriteLine();

            // explizite Konvertierung
            double zahl3 = 3.7;
            Console.WriteLine("Gleitkommazahl: " + zahl3);
            int zahl4 = (int)zahl3;
            Console.WriteLine("Ganze Zahl: " + zahl4);
        }
    }
}
