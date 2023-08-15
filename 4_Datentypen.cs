namespace Ablauf
{
    class Program
    {
        static void Main()
        {
            // Ganze Zahlen
            //                         Wertebereich
            byte bZahl = 127;       // 0 bis 255
            sbyte sZahl = 28;       // -128 bis 127
            short shZahl = 12;      // -32768 bis 32.767
            ushort usZahl = 126;    // 0 bis 65.535
            int zahl = -12;         // -2.147.483.648 bis 2.147.483.647
            uint uZahl = 89;        // 0 bis 4.294.967.296
            long lZahl = 128;       // -9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807
            ulong ulZahl = 289;     // 0 bis 18.446.744.073.709.551.615   

            // Gleitkommazahlen
            //                         Wertebereich
            float f = 5.4f;         // -3,402823x10^38 bis 3,402823x10^38
            double d = 4.9;         // -1,79769313486232x10^308 bis 1,79769313486232x10^308
            decimal dc = 7.5M;      // (-7,9x10^28 bis 7,9x10^28) / 10x10^(0 bis 28)

            // Wahrheitswert
            bool auto1 = true;
            bool auto2 = false;

            // einzelne Zeichen
            char c = 'a';

            // Zeichenketten
            string s = "Hallo";

            object obj = new object();
            obj = "Hello";

            object obj2 = 12.7f;

            Console.WriteLine(obj2);
        }
    }
}
