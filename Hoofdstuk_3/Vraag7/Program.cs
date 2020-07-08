using System;

namespace Vraag7
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 42, getal2;
            //Console.Write("Geef eerste getal: ");
            //getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef tweede getal: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Het resultaat is {getal1 - getal2}");
        }
    }
}
