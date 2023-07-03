namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib ein Zahl ein: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            while (num < counter) {
                Console.WriteLine(num);
                num++;
            }
        }
    }
}
