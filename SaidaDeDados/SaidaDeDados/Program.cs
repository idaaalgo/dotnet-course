using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 19;
            double saldo = 2000;
            string nome = "Isabela Mouro";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString("C")); // Imprimindo como valor monetário (C = Currency)
            Console.WriteLine(nome);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2}", nome, idade, saldo.ToString("C"));
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("C")}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}");
        }
    }
}