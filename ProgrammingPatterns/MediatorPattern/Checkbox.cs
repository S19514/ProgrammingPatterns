using System;

namespace MediatorPattern
{
    public class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");
            this._mediator.Notify(this,"checkboxSelected");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}