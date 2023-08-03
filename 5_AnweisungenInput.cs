using Daten;

namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // 1.example
            Console.WriteLine("Gib mir deinen Vornamen ein: ");
            string vorname = Console.ReadLine();
            Console.WriteLine(vorname);

            Console.WriteLine("Gib mir deinen Vornamen ein: ");
            string nachname = Console.ReadLine();
            Console.WriteLine(nachname);

            Console.WriteLine(vorname + " " + nachname);

            Console.WriteLine();

            // 2.example
            Console.WriteLine("Gib eine Zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib eine zweite Zahl ein: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result: " + (zahl1 + zahl2));
        }
    }
}
