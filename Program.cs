using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico_GFT
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((A == 0) || (B * B - 4 * A * C < 0))
            {
                Console.WriteLine("Impossivel calcular");
                Console.ReadKey();
            }
            else
            {
                double X1 = (-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                double X2 = (-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                Console.WriteLine("X1 = " + X1.ToString("N5"));
                Console.WriteLine("X1 = " + X2.ToString("N5"));
                Console.WriteLine("");

                Console.WriteLine("Pressione ENTER para sair...");
                Console.Read();


            }
        }
    }
}
