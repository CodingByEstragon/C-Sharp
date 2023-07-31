namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib dein Alter ein: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if(age < 12) {
                Console.WriteLine("Du bist ein Kind");
            }
            else if(age >= 12 && age <= 17) {
                Console.WriteLine("Du bist ein Jugendlicher");
            }
            else
                Console.WriteLine("Du bist Erwachsen");
        }
    }
}
