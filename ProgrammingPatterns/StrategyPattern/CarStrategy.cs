using System;

namespace StrategyPattern
{
    public class CarStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Car strategy");
        }
    }
}