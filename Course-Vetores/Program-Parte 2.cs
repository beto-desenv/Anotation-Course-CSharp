﻿using System;
using System.Globalization;

namespace Course_Vetores
{
    class Program_Parte_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++){
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++){
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVARAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
