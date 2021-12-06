using System;
using System.Globalization;

namespace Course_Membros_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Caluculadora.Circunferencia(raio);
            double volume = Caluculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Caluculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
