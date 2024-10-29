namespace IntroducaoClasses
{
    internal class Triangle
    {
        private double A;
        private double B;
        private double C;

        public Triangle()
        {
        }

        public Triangle(double A, double B, double C)
        {
            this.A = A;
            this.A = B;
            this.A = C;
        }
        
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
