using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prototype!");
            Circle circle = new Circle()
            {
                Radius = 5,
                X = 1,
                Y = 2,
                Border = new Border()
                {
                    Color = "Red",
                    Size = "2px"
                }
            };
            Circle circle2 = (Circle)circle.Clone();
            bool referenceEquals = ReferenceEquals(circle, circle2);
            Console.WriteLine($"refenence equals: {referenceEquals}");

            bool borderReferenceEquals = ReferenceEquals(circle.Border, circle2.Border);
            Console.WriteLine($"border reference equals: {borderReferenceEquals}");
            Console.WriteLine();
        }
    }
}