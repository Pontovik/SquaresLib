namespace SquaresLib
{
    interface ISquarable
    {
        double GetSquare();
    }


    public class Circle : ISquarable
    {
        private double rad;

        public Circle(double rad)
        {
            if (rad <= 0)
            {
                throw new ArgumentException("Radius cant be less than or equal to 0", nameof(rad));
            }
            this.rad = rad;
        }

        public  double GetSquare()
        {
            return Math.Pow(rad, 2) * Math.PI;
        }
    }

    public class Triangle : ISquarable
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            CanBeTriangle(a, b, c);
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private void CanBeTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides cant be less than or equal to 0");
            }
            double[] sortedSides = new double[] { a, b, c }.OrderBy(n => n).ToArray();
            if (!(sortedSides[0] + sortedSides[1] > sortedSides[2]))
            {
                throw new ArgumentException("There is no such triangle with these sides");
            }
        }
        public bool IsRectang() => ((a * a + b * b == c * c) || (b * b + c * c == a * a) || (a * a + c * c == b * b));

        public double GetSquare()
        {
                double halfP = (a + b + c) / 2;
                return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
            } 
    }
}