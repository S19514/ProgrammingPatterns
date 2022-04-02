using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args) //simulates i.e. Client class
        {
            Console.WriteLine("Hello Singleton!");

            var configuration = Configuration.GetInstance();
            var configuration2 = Configuration.GetInstance();

            if (ReferenceEquals(configuration, configuration2))
            {
                Console.WriteLine("Configuration is a singleton");
            }
        }
    }
}