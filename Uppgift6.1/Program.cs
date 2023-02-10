using System;
namespace Uppgift_6._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in tal du vill addera");

           int tal1 = int.Parse(Console.ReadLine());
           int tal2 = int.Parse(Console.ReadLine());   
           int tal3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Addera(tal1, tal2, tal3));
        }
        static int Addera(int tal1,int tal2, int tal3)
        {
            int sum=tal1 + tal2 + tal3;
            return sum;
        }
    }
}
