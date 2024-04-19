using System;
using System.Collections.Generic;

namespace Factory
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        public AirConditioner()
        {
            // Old way of doing
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                { Actions.Cooling, new CoolingFactory() },
                { Actions.Warming, new WarmingFactory() },
                {Actions.RoomTemperature, new RoomTemperatureFactory()}
            };

            // With reflection, doesn't work on mac
            //_factories = new Dictionary<Actions, AirConditionerFactory>();

            //foreach (Actions action in Enum.GetValues(typeof(Actions)))
            //{
            //    var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
            //    _factories.Add(action, factory);
            //}
        }

        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
    }
}
