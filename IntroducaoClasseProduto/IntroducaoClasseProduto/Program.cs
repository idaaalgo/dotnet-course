using System;
using System.Globalization;

namespace IntroducaoClasseProduto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Product product = new Product(nome, preco, quantidade);

            Console.WriteLine($"Dados do produto: {product}");

            Console.Write("Digite o número de quantidades para serem adicionadas ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(quantidade);
            Console.WriteLine($"Dados atualizados: {product}");

            Console.Write("Digite o número de quantidades para serem removidas do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            product.RemoverProdutos(quantidade);
            Console.WriteLine($"Dados atualizados: {product}");

        }
    }
}