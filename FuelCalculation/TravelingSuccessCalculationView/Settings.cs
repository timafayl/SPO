using FuelCalculation;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TravelingSuccessCalculationView
{
    public class Settings
    {
        public static Settings GetSettings()
        {
            Settings settings = null;
            string filename = FileName.SettingsFile;
            if (File.Exists(filename))
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(List<ITransportProperty>));
                    settings = (Settings)xser.Deserialize(stream);
                    stream.Close();
                }
            }
            else settings = new Settings();

            return settings;
        }

        public void Save()
        {
            string filename = FileName.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(List<ITransportProperty>));
                xser.Serialize(stream, this);
                stream.Close();
            }
        }
    }
}
