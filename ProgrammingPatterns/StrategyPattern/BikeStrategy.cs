using System;

namespace StrategyPattern
{
    public class BikeStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Bike strategy");
        }
    }
}