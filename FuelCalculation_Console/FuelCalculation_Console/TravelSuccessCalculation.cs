using System.Collections.Generic;
using FuelCalculation;
using TravelingSuccessCalculationView;
using System;

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

            Serialization.Serialize(transports);

            var testList = new List<ITransportProperty>();

            Serialization.Deserialize(ref testList);

            foreach(ITransportProperty element in testList)
            {
                Console.WriteLine(element.TransportName + "\n");
            }
        }
    }
}
