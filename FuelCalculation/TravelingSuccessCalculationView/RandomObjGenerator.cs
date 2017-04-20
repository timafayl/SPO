using FuelCalculation;
using System;

namespace TravelingSuccessCalculationView
{
    public class RandomObjGenerator
    {
        public Helicopter GenerateHelicopter()
        {
            var helicopter = new Helicopter();
            return helicopter;
        }

        public Car GenerateCar()
        {
            var car = new Car();
            return car;
        }
        /*private void GenerateRandomTransport()
        {
            const int size = 5;
            Random rand = new Random();
            string name = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < size; i++, Transport.TransportName += name[rand.Next(name.Length)].ToString()) ;
            /*char[] newName = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < size; i++, Transport.TransportName += newName[rand.Next(newName.Length)].ToString()) ;
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            var randomInt = new Random(unixTimestamp);
            Transport.WearRate = randomInt.Next(10, 90) / 100;
            Transport.FuelWaste = randomInt.Next(25, 27);
            Transport.Speed = randomInt.Next(100, 180);
            Transport.TankVolume = randomInt.Next(50, 60);

            if (ChooseTransportComboBox.Text == "Car")
            {
                FuelTypeComboBox.Text = Convert.ToString(FuelType.Бензин);
            }
            else
            {
                MassTextBox.Text = Convert.ToString(randomInt.Next(100, 999));
            }
        }*/
    }
}
