using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args) // decides which stategy to use
        {
            Console.WriteLine("Hello Strategy!");
            //var strategy = new BikeStrategy();
            //var strategy = new CarStrategy();
            var strategy = new WalkStrategy();
            var map = new Map(strategy);
            var start = new Coordinate();
            var end = new Coordinate();
            map.CreateRoute(start,end);
        }
    }
}