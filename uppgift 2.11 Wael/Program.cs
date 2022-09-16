using System;
namespace Uppgift_2._2
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hur långt hoppade Elin?");
            string x = Console.ReadLine();
            int h = int.Parse(x);
            Console.WriteLine("hur långt hoppade Alma?");
            string a = Console.ReadLine();
            int k = int.Parse(a);
            int s = h - k;
            Console.WriteLine("skjilnaden mellan Elin och Alma är  " + s);
        }


    }

}