namespace FactoryPattern
{
    using System;
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}