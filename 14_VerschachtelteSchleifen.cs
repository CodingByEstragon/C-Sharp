namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Verschachtelte Schleifen - Rechteck
            //Console.WriteLine("Gib die Höhe ein: ");
            //int hoehe = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Gib die Breite ein: ");
            //int breite = Convert.ToInt32 (Console.ReadLine());

            //for (int i = 0; i < hoehe; i++)
            //{
            //    int j = 0;
            //    while (j < breite) 
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //}


            // Verschachtelte Schleifen - Treppenform
            Console.WriteLine("Gib die Höhe ein: ");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hoehe; i++)
            {
                int j = 0;
                while (j < i + 1)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
            }

        }
    }
}
