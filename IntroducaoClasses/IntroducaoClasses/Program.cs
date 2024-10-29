using System;
using System.Globalization;

namespace IntroducaoClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle x = new Triangle(a, b, c);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triangle y = new Triangle(a, b, c);

            Console.WriteLine($"Área de X = {x.Area().ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {y.Area().ToString("F4", CultureInfo.InvariantCulture)}");

            if (x.Area() > y.Area())
            {
                Console.WriteLine("Maior área: x");
            }
            else if (x.Area() < y.Area())
            {
                Console.WriteLine("Maior área: y");
            }
            else
            {
                Console.WriteLine("Áreas iguais");
            }


        }
    }
}