namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Division
            int zahl1 = 17;
            int zahl2 = 5;
            int summe = zahl1 / zahl2;
            Console.WriteLine("Division: " + summe);

            Console.WriteLine("------------------------------");

            // Modulo Operator
            int num1 = 24;
            int num2 = 9;
            int sum = num1 % num2;
            Console.WriteLine("Modulo: " + sum);

            Console.WriteLine("------------------------------");

            // Anwendungsbeispiel: gerade und ungerade Zahl
            Console.WriteLine("Gib die erste Zahl ein: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Gib die zweite Zahl ein: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int modulo = number1 % number2;

            if(modulo % 2 == 0)
            {
                Console.WriteLine("gerade Zahl: " + modulo);
            }
            else
            {
                Console.WriteLine("ungerade Zahl: " + modulo);
            }

        }
    }
}
