using System;
using System.Collections.Generic;
using FuelCalculation;

namespace FuelCalculation_Console
{
    static class TravelSuccessCalculation
    {
        static void Main()
        {
            var toyota = new Car("toyota", 0.15, 12, 95, "бензин", 64);
            var mercedes = new Car("mercedes", 0.22, 13, 100, "дизель", 58);
            var  subaru = new Car("subaru", 0.05, 9, 120, "бензин", 60);
  
            var cars = new List<ITransportProperty> {toyota, subaru, mercedes};

            var robinson = new Helicopter("robinson", 0.2, 25, 273, 900, 100);

            cars.Add(robinson);

            double distance = Convert.ToDouble(Console.ReadLine());

            foreach (ITransportProperty car in cars)
            {
                Console.WriteLine("Наименование транспорта: " + car.TransportName);
                if (car.IsCanPassDistance(ref distance))
                {
                    Console.WriteLine("wearRate = " + car.WearRate);
                    Console.WriteLine("Вы сможете преодолеть заданный маршрут на данном авто");
                }
                else
                {
                    Console.WriteLine("wearRate = " + car.WearRate);
                    Console.WriteLine("Путешествие обречено на провал");
                }
            }
        }
    }
}
