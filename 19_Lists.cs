namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Lists
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(1);
            list.Add(4);
            list.Add(7);

            int wert1 = list[0];

            Console.WriteLine(wert1);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);

            Console.WriteLine(list.Count);

            Console.WriteLine("---------------");

            list[0] = 12;

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------");

            List<string> motorrad = new List<string>() {"Honda, Suzuki, Ducati" };

            foreach(string name in motorrad)
            {
                Console.WriteLine(name);
            }
        }
    }
}
