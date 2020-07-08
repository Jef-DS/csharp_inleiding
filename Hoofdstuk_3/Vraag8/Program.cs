using System;

namespace Vraag8
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            Console.Write("De leeftijd van Karen: ");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            totaal = totaal + leeftijd;
            Console.Write("De leeftijd van Kristel: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            totaal = totaal + leeftijd;
            Console.Write("De leeftijd van Kathleen: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            totaal = totaal + leeftijd;
            double gemiddeldeLeeftijd = totaal / 3;
            Console.WriteLine($"De gemiddelde leeftijd van de K'3tjes is {gemiddeldeLeeftijd:F1}");
        }
    }
}
