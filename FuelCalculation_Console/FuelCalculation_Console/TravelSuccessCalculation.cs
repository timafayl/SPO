using System;
using System.Collections.Generic;
using FuelCalculation;

namespace FuelCalculation_Console
{
    static class TravelSuccessCalculation
    {
        static void Main()
        {
            var toyota = new CarTransportProperty("toyota", 0.15, 12, 95, "бензин", 450, 64);
            var subaru = new CarTransportProperty();
            var mercedes = new CarTransportProperty("mercedes", 0.22, 13, 100, "дизель", 240, 58);
            try
            {
                subaru = new CarTransportProperty("subaru", -0.05, 9, 120, "бензин", 120, 60);
            }
            catch (Exception)
            {
               throw new ArgumentException("уберите мЕнус");
            }
            var cars = new List<ITransportProperty> {toyota, subaru, mercedes};

            var a = new double();

            foreach (ITransportProperty car in cars)
            {
                Console.WriteLine("Марка машины: " + car.TransportName);
                if (car.SuccessProbability(ref a))
                {
                    Console.WriteLine("calcValue = " + a);
                    Console.WriteLine("wearRate = " + car.WearRate);
                    Console.WriteLine("Вы сможете преодолеть заданный маршрут на данном авто");
                }
                else
                {
                    Console.WriteLine("calcValue = " + a);
                    Console.WriteLine("wearRate = " + car.WearRate);
                    Console.WriteLine("Путешествие обречено на провал");
                }
            }
        }
    }
}
