namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // wenn die Bedingung zutrifft
            int zahl = 1;
            switch (zahl)
            {
                case 1:
                    Console.WriteLine("Das ist die Zahl 1");
                    break;
            }

            Console.WriteLine();

            // wenn keine Bedingung zutrifft
            int number = 12;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Das ist die Zahl 10");
                    break;
                default:
                    Console.WriteLine("Die Zahl ist nicht vorhanden!");
                    break;
            }

            Console.WriteLine();

            // Ist das case und die when Bedingung erfüllt dann wird die entsprechende Anweisung ausgegeben
            int no1 = 12;
            int no2 = 18;
            switch (no1)
            {
                case 11 when no2 == 11:
                    Console.WriteLine("Zahl 11");
                    break;
                case 11 when no2 == 12:
                    Console.WriteLine("Zahl 11 und 12");
                    break;
                case 12:
                    Console.WriteLine("Die Zahl 12");
                    break;
            }

            Console.WriteLine();

            // Mit goto kannst du einen case oder default angeben und ausführen
            int i = 112;
            switch (i)
            {
                case 107:
                    Console.WriteLine("Die Zahl lautet 107");
                    goto default;
                default:
                    Console.WriteLine("Error ist nicht vorhanden!");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("Gib eine Zahl zwischen 1 - 7 ein: ");
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
