using FuelCalculation;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TravelingSuccessCalculationView
{
    public class Serialization
    {
        public static void Deserialize(ref List<ITransportProperty> myList)
        {
            string filename = FileName.SettingsFile;
            if (File.Exists(filename))
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(List<ITransportProperty>));
                    myList = (List<ITransportProperty>)xser.Deserialize(stream);
                    stream.Close();
                }
            }
            else myList = null;
        }

        public static void Serialize(List<ITransportProperty> myList)
        {
            string filename = FileName.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(List<ITransportProperty>));
                xser.Serialize(stream, myList);
                stream.Close();
            }
        }
    }
}
