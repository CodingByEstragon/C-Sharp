namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Methoden
            Greeting("Jack");
            double ergebnis = Rechteck(2.5, 3.7);
            Console.WriteLine("Flächeninhalt: " + ergebnis + "cm");

            int alter = 17;
            if (Age(alter))
            {
                Console.WriteLine("Du bist erwachsen");
            }
            else
            {
                Console.WriteLine("Du bist noch zu jung");
            }
        }

        // Methode ohne Rückgabewert
        static void Greeting(string name)
        {
            Console.WriteLine("Hallo " + name);
        }

        // Methode mit Rückgabewert
        static double Rechteck(double breite, double hoehe)
        {
            return breite * hoehe;
        }

        static bool Age(int alter)
        {
            return alter > 17;
        }
    }
}
