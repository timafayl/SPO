using FuelCalculation;
using System;

namespace TravelingSuccessCalculationView
{
    /// <summary>
    /// Класс для создания случайного транспортного средства.
    /// </summary>
    public class RandomTransportGenerator
    {
        /// <summary>
        /// Переменная для создания случайный чисел.
        /// </summary>
        private Random _randomInt = new Random();

        /// <summary>
        /// Метод, создающий экземпляр вертолёта со случайными значениями.
        /// </summary>
        /// <returns>Экземпляр вертолёта со случайными значениями</returns>
        public Helicopter GenerateHelicopter()
        {
            var helicopter = new Helicopter();
            GenerateCommonFields(helicopter, 1);
            helicopter.Mass = _randomInt.Next(100, 999);
            return helicopter;
        }

        /// <summary>
        /// Метод, создающий экземпляр машины со случайными значениями.
        /// </summary>
        /// <returns>Экземпляр машины со случайными значениями</returns>
        public Car GenerateCar()
        {
            var car = new Car();
            GenerateCommonFields(car, 0);
            car.FuelType = FuelType.Бензин;
            return car;
        }


        /// <summary>
        /// Метод, создающий экземпляр случайного транстпортного средства.
        /// </summary>
        /// <returns>Случайное транспортное средство</returns>
        public ITransport GenerateRandomTransport()
        {
            var transportType = _randomInt.Next(0, 2);
            if (transportType == 0)
            {
               return GenerateCar();
            }
            return GenerateHelicopter();
        }

        /// <summary>
        /// Метод, генерирующий случайные значения для полей интерфейса.
        /// </summary>
        /// <param name="transport">Объект транспорта</param>
        /// <param name="transportType">Тип транспорта: вертолёт или машина</param>
        private void GenerateCommonFields(ITransport transport, int transportType)
        {
            if (transportType == 0)
            {
                transport.TransportName = Convert.ToString((CarNames)_randomInt.Next(0, 20));
            }
            else
            {
                transport.TransportName = Convert.ToString((HelicopterNames)_randomInt.Next(0, 20));
            }
            transport.WearRate = _randomInt.NextDouble();
            transport.FuelWaste = _randomInt.Next(25, 27);
            transport.Speed = _randomInt.Next(100, 180);
            transport.TankVolume = _randomInt.Next(50, 60);
        }
    }
}
