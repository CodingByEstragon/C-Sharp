namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib eine Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < zahl; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
