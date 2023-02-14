namespace ShapeLibrary
{
    public abstract class Shape
    {
        private readonly double _area;

        public double Area => _area;

        protected Shape(double area)
        { 
            _area = area;
        }
    }
}