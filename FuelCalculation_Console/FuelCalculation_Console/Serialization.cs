using FuelCalculation;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TravelingSuccessCalculationView
{
    public class Serialization
    {
        public static void Serialize(List<ITransportProperty> myList)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("transport.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, myList);
            }
        }

        public static void Deserialize(ref List<ITransportProperty> myList)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("transport.txt", FileMode.OpenOrCreate))
            {
                myList = (List<ITransportProperty>) formatter.Deserialize(fs);
            }
        }
    }
}
