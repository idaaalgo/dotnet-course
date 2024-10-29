using System;

namespace OperadoresLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5; // True
            bool c2 = 2 > 3 && 4 != 5; // False
            bool c3 = 2 > 3 || 4 != 5; // True
            bool c4 = !(2 > 3) && 4 != 5; // True

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("----------------");

            /*
             * Ordem Precedência
             * ! > && > ||
             */

            bool c5 = 10 < 5; // False
            bool c6 = c3 || c4 && c5; // True
            
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}