namespace ShapeLibrary.Shapes
{
    public class Triangle : Shape
    {
        private readonly double[] _sides;

        public Triangle(double a, double b, double c)
            : base(Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Triangle cannot have negative sides");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("There is no triangle with such sides");

            _sides = new double[] { a, b, c };
        }

        ///<param name = "eps" >Accuracy to account machine precision</param>
        public bool IsRight(double eps = 1E-12)
        {
            Array.Sort(_sides);//hypotenuse - the last

            return Math.Abs( Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) - Math.Pow(_sides[2], 2)) <= eps;

        }
    }
}
