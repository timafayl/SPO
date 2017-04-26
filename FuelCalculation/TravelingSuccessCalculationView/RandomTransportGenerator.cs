using FuelCalculation;
using System;

namespace TravelingSuccessCalculationView
{
    public class RandomTransportGenerator
    {
        private Random _randomInt = new Random();

        public Helicopter GenerateHelicopter()
        {
            var helicopter = new Helicopter();
            GenerateCommonFields(helicopter, 1);
            helicopter.Mass = _randomInt.Next(100, 999);
            return helicopter;
        }

        public Car GenerateCar()
        {
            var car = new Car();
            GenerateCommonFields(car, 0);
            car.FuelType = FuelType.Бензин;
            return car;
        }

        public ITransport GenerateRandomTransport()
        {
            var transportType = _randomInt.Next(0, 1);
            if (transportType == 0)
            {
               return GenerateCar();
            }
            return GenerateHelicopter();
        }

        private void GenerateCommonFields(ITransport transport, int transportType)
        {
            if (transportType == 0)
            {
                transport.TransportName = Convert.ToString((CarNames) _randomInt.Next(0, 20));
            }
            else
            {
                transport.TransportName = Convert.ToString((HelicopterNames)_randomInt.Next(0, 20));
            }
            transport.WearRate = _randomInt.Next(10, 90)/100;
            transport.FuelWaste = _randomInt.Next(25, 27);
            transport.Speed = _randomInt.Next(100, 180);
            transport.TankVolume = _randomInt.Next(50, 60);
        }
    }
}
