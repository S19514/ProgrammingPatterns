using System;

namespace AbstractFactoryPattern
{
    public class WindowsTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render window textbox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle windows text input");
        }
    }
}