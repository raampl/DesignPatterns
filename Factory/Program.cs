using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
            factory.Operate();

            factory = new AirConditioner().ExecuteCreation(Actions.Warming, 35.0);
            factory.Operate();

            factory = new AirConditioner().ExecuteCreation(Actions.RoomTemperature, 32.5);
            factory.Operate();
        }
    }
}
