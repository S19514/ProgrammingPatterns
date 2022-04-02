using System;

namespace ObserverPattern
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }
        public void Update(string context)
        {
            Console.WriteLine($"Subscriber {Name} notified: {context}");
        }
    }
}