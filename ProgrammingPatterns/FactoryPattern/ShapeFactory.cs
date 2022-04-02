namespace FactoryPattern
{
    using System;
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType shapetype)
        {
            switch (shapetype)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    throw new Exception($"Shape type {shapetype} is not handled");
            }
        }
    }
}