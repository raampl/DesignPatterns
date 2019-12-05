using System;
namespace Factory
{
    public class Cooling : IAirConditioner
    {
        private readonly double _temperature;

        public Cooling(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
        }
    }

    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Cooling(temperature);
        
    }
}
