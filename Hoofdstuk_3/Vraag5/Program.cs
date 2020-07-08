using System;

namespace Vraag5
{
    class Program
    {
        static void Main(string[] args)
        {
            int leeftijd = 42;
            Console.Write("Geef je leeftijd: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{leeftijd}");
        }
    }
}