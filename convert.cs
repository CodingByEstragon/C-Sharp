namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // implizite Konvertierung
            int zahl = 3;
            Console.WriteLine("Ganze Zahl: " + zahl);
            zahl = 6;
            double zahl2 = zahl;
            zahl2 = 4.7;
            Console.WriteLine("Gleitpunktzahl: " + zahl2);

            // explizite Konvertierung
            double number = 3.7;
            int number2 = (int)number;
            Console.WriteLine("Ganze Zahl: " + number2);
        }
    }
}
