using System;

namespace PrototypePattern
{
    public class Rectangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }

        public override Shape Clone()
        {
            Rectangle cloneBase = (Rectangle) this.MemberwiseClone(); //shallow copy
            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };//deep copy
            return cloneBase;
        }
    }
}