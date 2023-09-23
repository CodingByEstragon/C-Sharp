namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // logische Operatoren

            //  != ---> "ungleich"
            //  == ---> "2 Werte vergleichen"
            //   < ---> "kleiner als"
            //   > ---> "größer als"
            //  <= ---> "kleiner gleich"
            //  >= ---> "größer gleich"
            //  && ---> "Und Operator"
            //  || ---> "Oder Operator"

            Console.WriteLine("Gib dein Alter ein: ");
            int alter = Convert.ToInt32 (Console.ReadLine());

            if(alter < 12)
            {
                Console.WriteLine("Du bist ein Kind");
            }
            else if(alter >= 12 && alter <= 17)
            {
                Console.WriteLine("Du bist jugendlich");
            }
            else
            {
                Console.WriteLine("Du bist erwachsen");
            }
        }
    }
}
