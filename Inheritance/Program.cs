using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter Length:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height:");
            int height = Convert.ToInt32(Console.ReadLine());

            var cube = new Cube(width, height, length);
            var triangle = new Triangle();
            var triangle1 = new Triangle() { Height = height, Length = height, Hypotenuese = 10};
            var triangle2 = new Triangle(10);

            var rectangle = new Rectangle();
            

            Console.WriteLine("Cube Area Is: " + cube.getArea());
            Console.WriteLine("Cube Volume Is: " + cube.getVolume());

            Console.WriteLine("Triangle Area Is: " + triangle.getArea());
            Console.WriteLine("Rectangle Area Is: " +  rectangle.getArea());

        }
    }
}
