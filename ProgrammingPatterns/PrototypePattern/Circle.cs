using System;

namespace PrototypePattern
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Render()
        {
            Console.WriteLine("Render circle");
        }

        public override Shape Clone()
        {
           Circle cloneBase = (Circle) this.MemberwiseClone(); //shallow copy
           cloneBase.Border = new Border()
           {
               Size = Border.Size,
               Color = Border.Color
           };//deep copy
           return cloneBase;
        }
    }
}