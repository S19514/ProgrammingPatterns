using System;

namespace AbstractFactoryPattern
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render windows button");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle windows click event");
        }
    }
}