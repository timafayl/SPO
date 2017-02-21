using System.Collections.Generic;
using FuelCalculation;

namespace FuelCalculation_Console
{
    class Program
    {
        static void Main()
        {
            var toyota = new CarTransportProperty();
            var subaru = new CarTransportProperty();
            var mercedez = new CarTransportProperty();

            var cars = new List<CarTransportProperty> {toyota, subaru, mercedez};
        }
    }
}
