using System;

namespace Course_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entendendo o SPLIT-------------------------------------------------------");
            Console.WriteLine();

            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
 