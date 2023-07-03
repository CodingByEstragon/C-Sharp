namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib eine Zahl ein für die Rundenanzahl: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib eine Zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            int maximum = zahl1;

            for (int i = 1; i < counter; i++)
            {

                Console.WriteLine("Gib eine weitere Zahl ein: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                if (maximum < zahl2)
                {
                    maximum = zahl2;
                }

            }
            Console.WriteLine("Das Maximum ist: " + maximum);
        }
    }
}
