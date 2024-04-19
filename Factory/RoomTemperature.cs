using System;
namespace Factory
{
    public class RoomTemperature : IAirConditioner
    {
        private readonly double _temperature;

        public RoomTemperature(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Setting Room temperature to the required temperature of {_temperature} degrees");
        }
    }

    public class RoomTemperatureFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new RoomTemperature(temperature);
        
    }
}