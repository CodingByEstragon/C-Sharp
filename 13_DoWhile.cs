namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib ein Zahl ein: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            do {
                Console.WriteLine(num);
                num++;
            }
            while (num < counter);
        }
    }
}
