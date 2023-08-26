namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib ein Zahl zwischen 1 - 7 ein: ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Die Woche hat nur 7 Tage!!");
                    break;
            }
        }
    }
}
