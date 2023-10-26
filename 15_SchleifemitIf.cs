// Schleife mit If Bedingung
namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Verschachtelte Schleifen mit einer If Bedingung - Pyramide

            //Console.WriteLine("Gib eine Höhe ein: ");
            //int hoehe = Convert.ToInt32 (Console.ReadLine());

            //int i = 0;
            //while(i < hoehe)
            //{
            //    int j = 0;
            //    while (j < hoehe + i)
            //    {
            //        if(j < hoehe - i -1)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            // Benutzername und eine Kennwort Eingabe
            //Console.WriteLine("Gib dein Name ein: ");
            //string name = Console.ReadLine();

            //while (true)
            //{
            //    Console.Write("Gib deinen Code ein: ");
            //    string code = Console.ReadLine();

            //    if(code == name)
            //    {
            //        Console.WriteLine("Fehler: Der Name darf nicht als Code verwendet werden!");
            //    }
            //    else if(code.Length < 8)
            //    {
            //        Console.WriteLine("Fehler: Code ist zu kurz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Der Code kann verwendet werden :)");
            //        break;
            //    }
            //}

            // Maximum
            Console.WriteLine("Gib eine Zahl ein für die Rundenanzahl: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib eine Zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            int maximum = zahl1;

            for(int i = 1; i < counter; i++)
            {
                Console.WriteLine("Gib eine weitere Zahl ein: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                if(maximum < zahl2)
                {
                    maximum = zahl2;
                }
            }
            Console.WriteLine("Das Maximum ist: " + maximum);
        }
    }
}
