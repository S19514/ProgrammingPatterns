using System;

namespace MediatorPattern
{
    public class Button : Component
    {
        public void Render()
        {
            Console.WriteLine("Render button");
        }

        public void Click()
        {
            Console.WriteLine("Button click");
            this._mediator.Notify(this,"click");
        }
    }
    
}