namespace ShapeLibrary.Shapes
{
    public class Circle : Shape
    {
        public Circle(double r) : base(r * r * Math.PI)
        {
            if (r <= 0)
                throw new ArgumentException("Circle must have a positive radius");
        }
    }
}
