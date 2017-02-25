﻿using System;
using System.Collections.Generic;
using FuelCalculation;

namespace FuelCalculation_Console
{
    static class TravelSuccessCalculation
    {
        static void Main()
        {
            var toyota = new CarTransportProperty("toyota", 0.15, 12, 95, "бензин", 450, 64);
            var subaru = new CarTransportProperty("subaru", 0.05, 9, 120, "бензин", 120, 60);
            var mercedes = new CarTransportProperty("mercedes", 0.22, 13, 100, "дизель", 240, 58);

            var cars = new List<CarTransportProperty> {toyota, subaru, mercedes};

            var a = new double();

            foreach (CarTransportProperty car in cars)
            {
                Console.WriteLine("Марка машины: " + car.CarName);
                if (car.SuccessProbability(ref a))
                {
                    Console.WriteLine("calcValue = " + a);
                    Console.WriteLine("Вы сможете преодолеть заданный маршрут на данном авто");
                }
                else
                {
                    Console.WriteLine("calcValue = " + a);
                    Console.WriteLine("Путешествие обречено на провал");
                }

            }
        }
    }
}
