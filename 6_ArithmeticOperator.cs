namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            int zahl1 = 8;
            int zahl2 = 12;
            Console.WriteLine("erste Zahl: " + zahl1);
            Console.WriteLine("zweite Zahl: " + zahl2);

            int zwsumme1 = zahl1 + zahl2;
            Console.WriteLine("Addition: " + zwsumme1);

            Console.WriteLine();

            zahl1 = 9;
            zahl2 = 4;
            Console.WriteLine("erste Zahl: " + zahl1);
            Console.WriteLine("zweite Zahl: " + zahl2);

            int zwsumme2 = zahl1 - zahl2;
            Console.WriteLine("Subtraktion: " + zwsumme2);

            Console.WriteLine();

            int summe1 = zwsumme1 * zwsumme2;
            int summe2 = zwsumme1 / zwsumme2;
            Console.WriteLine("Multiplikation: " + summe1);
            Console.WriteLine("Division: " + summe2);
        }
    }
}
