using System;

namespace PrototypePattern
{
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }

        public override Shape Clone()
        {
            Triangle cloneBase = (Triangle) this.MemberwiseClone(); //shallow copy (copying references)
            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };//deep copy (new object with exact values)
            return cloneBase;
        }
    }
}