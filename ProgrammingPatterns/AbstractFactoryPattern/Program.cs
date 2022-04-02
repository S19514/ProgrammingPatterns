using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Abstract Factory!");

            var uiApplication = new Application(new MacosFactory());
            uiApplication.RenderUi();
        }
    }
}