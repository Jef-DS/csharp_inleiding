using System;

namespace Vraag1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef eerste getal: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef tweede getal: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            double quotient = getal1 / getal2;
            Console.WriteLine($"{getal1} / {getal2} = {quotient}");
        }
    }
}
