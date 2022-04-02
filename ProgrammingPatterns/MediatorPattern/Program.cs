using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mediator!");

            Button submitButton = new Button();
            Checkbox clientType = new Checkbox();

            new RegisterClientView(clientType, submitButton);
            
            submitButton.Click();
            clientType.Select();
        }
    }
}