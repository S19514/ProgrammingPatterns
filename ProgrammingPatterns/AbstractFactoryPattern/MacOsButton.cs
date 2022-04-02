using System;

namespace AbstractFactoryPattern
{
    public class MacOsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render macos button");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle macos click event");
        }
    }
}