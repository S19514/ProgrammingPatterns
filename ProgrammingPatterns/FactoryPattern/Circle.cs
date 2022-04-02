
namespace FactoryPattern
{
    using System;
    public class Circle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Circle");
        }
    }
}