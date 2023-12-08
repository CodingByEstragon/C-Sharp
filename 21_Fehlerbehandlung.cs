namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Fehlerbehandlung
            try
            {
                Console.WriteLine("Gib die erste Zahl ein: ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Gib die zweite Zahl ein: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int result = dividend / divisor;
                Console.WriteLine("Ergebnis der Division: " + result);
            } 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt. Details: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Das Programm wurde ausgeführt");
            }
        }
    }
}
