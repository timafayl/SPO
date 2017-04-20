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
        /// <param name="filePath">Путь к файлу</param>
        public static void Serialize(List<ITransport> myList, string filePath)
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
        public static void Deserialize(ref List<ITransport> myList, string filePath)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if(fs.Length != 0)
                {
                    myList = (List<ITransport>)formatter.Deserialize(fs);
                }
            }
        }

        /// <summary>
        /// Сериализует получаемый на вход список объектов.
        /// </summary>
        /// <param name="myList">Список объектов, который будет сериализован</param>
        public static void SerializeRecentFile(List<string> myList)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("recentFiles.txt", FileMode.Create))
            {
                formatter.Serialize(fs, myList);
                fs.Close();
            }
        }

        /// <summary>
        /// Десериализует данные в получаемый на вход список.
        /// </summary>
        /// <param name="myList">Список, в который будут десериализованы данные из файла</param>
        public static List<string> DeserializeRecentFile()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("recentFiles.txt", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    return (List<string>)formatter.Deserialize(fs);
                }
                return new List<string>();
            }
        }
    }
}

