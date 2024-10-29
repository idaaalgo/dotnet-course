﻿using System;
using System.Globalization;

namespace ClassesAtributosMetodos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura (respectivamente) do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo retangulo = new Retangulo(largura, altura);
            Console.WriteLine($"AREA = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}