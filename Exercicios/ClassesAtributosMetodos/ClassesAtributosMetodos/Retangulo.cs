namespace ClassesAtributosMetodos
{
    internal class Retangulo
    {
        private double Largura { get; set; }
        private double Altura { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
