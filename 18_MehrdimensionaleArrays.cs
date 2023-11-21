namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Mehrdimensionales Array
            string[,] auto = new string[2, 4];
            auto[0, 0] = "Mercedes";
            auto[1, 0] = "BMW";
            auto[0, 1] = "Dodge";
            auto[1, 1] = "Ford";
            auto[0, 2] = "Nissan";
            auto[1, 2] = "Toyota";
            auto[0, 3] = "Maserati";
            auto[1, 3] = "Ferrari";

            //          Spalte 1    Spalte 2    Spalte 3    Spalte 4
            // Zeile 1  Mercedes    Dodge       Nissan      Maserati
            // Zeile 2  BMW         Ford        Toyota      Ferrari

            Console.Write(auto[0, 0] + " ");
            Console.Write(auto[0, 1] + " ");
            Console.Write(auto[0, 2] + " ");
            Console.WriteLine(auto[0, 3]);
            Console.Write(auto[1, 0] + "      ");
            Console.Write(auto[1, 1] + "  ");
            Console.Write(auto[1, 2] + " ");
            Console.WriteLine(auto[1, 3]);

            Console.WriteLine("----------------------------");

            int[,] zahlen = { { 1, 2, 3 }, 
                              { 4, 5, 6 }, 
                              { 7, 8, 9 } };

            foreach(int i in zahlen)
            {
                Console.WriteLine(i);
            }

            //          Spalte 1    Spalte 2    Spalte 3
            // Zeile 1      1           2           3
            // Zeile 2      4           5           6
            // Zeile 3      7           8           9

            Console.WriteLine("----------------------------");

            // [Zeile, Spalte]
            Console.Write(zahlen[0, 0] + " ");
            Console.Write(zahlen[0, 1] + " ");
            Console.WriteLine(zahlen[0, 2]);

            Console.WriteLine("----------------------------");

            Console.Write(zahlen[1, 0] + " ");
            Console.Write(zahlen[1, 1] + " ");
            Console.WriteLine(zahlen[1, 2]);

            Console.WriteLine("----------------------------");

            Console.Write(zahlen[2, 0] + " ");
            Console.Write(zahlen[2, 1] + " ");
            Console.WriteLine(zahlen[2, 2]);
        }
    }
}
