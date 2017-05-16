using FuelCalculation;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TravelingSuccessCalculationView
{
    public class Serializer
    {
        /// <summary>
        /// Сериализует получаемый на вход список объектов.
        /// </summary>
        /// <param name="myList">Список объектов, который будет сериализован</param>
        /// <param name="filePath">Путь к файлу</param>
        public static void Serialize<T>(List<T> myList, string filePath)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, myList);
                fs.Close();
            }
        }

        /// <summary>
        /// Десериализует данные в получаемый на вход список.
        /// </summary>
        /// <param name="myList">Список, в который будут десериализованы данные из файла</param>
        /// <param name="filePath">Путь к сериализуемому файлу</param>
        public static void Deserialize<T>(ref List<T> myList, string filePath)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    myList = (List<T>) formatter.Deserialize(fs);
                }
            }
        }
    }
}

