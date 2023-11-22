namespace Inheritance
{
    internal partial class Program
    {
        class Triangle : Shape, IShape
        {
            public Triangle()
            {
                
            }

            public Triangle(int hyp)
            {
                
            }
            public double Hypotenuese {  get; set; }

            public double getArea()
            {
                return .5 * Length * Height;
            }
        
        }
    }
}
