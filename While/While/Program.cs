using System;
using System.Globalization;

namespace While
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (num >= 0) {
                Console.WriteLine(Math.Sqrt(num).ToString("F3"));
                Console.Write("Digite um número: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");
        }
    }
}