using System;
namespace Factory
{
    public class Warming : IAirConditioner
    {
        private readonly double _temperature;

        public Warming(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees");
        }
    }

    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Warming(temperature);
        
    }
}
