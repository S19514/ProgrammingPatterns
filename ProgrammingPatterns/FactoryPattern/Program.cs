using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory!");
            
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.CreateShape(ShapeType.Circle);
            circle.Render();

            var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
            triangle.Render();
        }
    }
}