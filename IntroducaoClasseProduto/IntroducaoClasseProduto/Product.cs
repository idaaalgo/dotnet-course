namespace IntroducaoClasseProduto
{
    internal class Product
    {
        private string Nome { get; set; }
        private Double Preco { get; set;}
        private int Quantidade { get; set;}

        public Product()
        {
        }

        public Product(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco.ToString("C")}, {Quantidade} unidades, Total: {ValorTotalEmEstoque().ToString("C")}";
        }
    }
}
