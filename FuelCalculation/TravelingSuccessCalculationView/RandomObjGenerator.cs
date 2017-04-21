using FuelCalculation;
using System;

namespace TravelingSuccessCalculationView
{
    public class RandomObjGenerator
    {
        public Helicopter GenerateHelicopter()
        {
            var helicopter = new Helicopter();
            helicopter = (Helicopter)GenerateRandomTransport(helicopter);
            return helicopter;
        }

        public Car GenerateCar()
        {
            var car = new Car();
            car = (Car)GenerateRandomTransport(car);
            return car;
        }
        private ITransport GenerateRandomTransport(ITransport transport)
        {
            const int size = 5;
            Random rand = new Random();
            string name = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < size; i++, transport.TransportName += name[rand.Next(name.Length)].ToString()) ;
            /*char[] newName = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < size; i++, Transport.TransportName += newName[rand.Next(newName.Length)].ToString()) ;*/
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            var randomInt = new Random(unixTimestamp);
            transport.WearRate = randomInt.Next(10, 90) / 100;
            transport.FuelWaste = randomInt.Next(25, 27);
            transport.Speed = randomInt.Next(100, 180);
            transport.TankVolume = randomInt.Next(50, 60);

            if (transport is Car)
            {
                var car = new Car();
                car = (Car)transport;
                car.FuelType = FuelType.Бензин;
                return car;
            }
            else
            {
                var helicopter = new Helicopter();
                helicopter = (Helicopter)transport;
                helicopter.Mass = randomInt.Next(100, 999);
                return helicopter;
            }
        }
    }
}
