namespace FactoryPattern
{
    using System;
    public class Rectangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}