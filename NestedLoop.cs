namespace Ablauf
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Gib eine Zahl ein: ");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib eine zweite Zahl ein: ");
            int breite = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < hoehe; i++)
            {
                for(int j = 0; j < breite; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
