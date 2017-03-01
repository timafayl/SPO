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
  
            var transports = new List<ITransportProperty> {toyota, subaru, mercedes};

            var robinson = new Helicopter("robinson", 0.2, 25, 273, 900, 100);
            transports.Add(robinson);

            double distance = 0;
            try
            {
                Console.WriteLine("Введите расстояние: ");
                distance = Convert.ToDouble(Console.ReadLine());
                while (distance < 0)
                {
                    Console.WriteLine("Введите расстояние: ");
                    distance = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                    throw new ArgumentException("Distance value have to be double");
            }

            foreach (ITransportProperty transport in transports)
            {
                Console.WriteLine("\nНаименование транспорта: " + transport.TransportName);
                if (transport.IsCanPassDistance(ref distance))
                {
                    Console.WriteLine("wearRate = " + transport.WearRate);
                    Console.WriteLine("Вы сможете преодолеть заданный маршрут на данном авто\n");
                }
                else
                {
                    Console.WriteLine("wearRate = " + transport.WearRate);
                    Console.WriteLine("Путешествие обречено на провал\n");
                }
            }
        }
    }
}
