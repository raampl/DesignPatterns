using System;
namespace Factory
{
    public abstract class AirConditionerFactory
    {
        // This abstract class provides an interface for object creation in derived classe
        public abstract IAirConditioner Create(double temperature);
    }
}
