using FuelCalculation;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TravelingSuccessCalculationView
{
    public class Serialization
    {
        /// <summary>
        /// Сериализует получаемый на вход список объектов.
        /// </summary>
        /// <param name="myList">Список объектов, который будет сериализован</param>
        public static void Serialize(List<ITransportProperty> myList)
        {
            string filename = FilePath.filepath;

            if (File.Exists(filename)) File.Delete(filename);

            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, myList);
            }
        }

        /// <summary>
        /// Десериализует данные в получаемый на вход список.
        /// </summary>
        /// <param name="myList">Список, в который будут десериализованы данные из файла</param>
        public static void Deserialize(ref List<ITransportProperty> myList)
        {
            string filename = FilePath.filepath;

            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                myList = (List<ITransportProperty>)formatter.Deserialize(fs);
            }
        }
    }
}

