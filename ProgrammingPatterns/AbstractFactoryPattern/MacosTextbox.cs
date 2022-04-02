using System;

namespace AbstractFactoryPattern
{
    public class MacosTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render macos textbox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle macos text input");
        }
    }
}