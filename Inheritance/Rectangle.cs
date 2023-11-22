namespace Inheritance
{
    internal partial class Program
    {
        class Rectangle : Shape, IShape
        {
            public double Width { get; set; }
            public double getArea()
            {
                return Length * Width;
            }
        }
    }
}
