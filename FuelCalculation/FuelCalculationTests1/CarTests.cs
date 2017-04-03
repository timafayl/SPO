using System;
using NUnit.Framework;


namespace FuelCalculation.Tests
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = "shkoda")]
        [TestCase("Shkoda", TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public string TransportNameTest(string name)
        {
            Car transport = new Car();
            return transport.TransportName = name;
        }

        [Test]
        [TestCase(0.45, TestName = "Тестирование поля Car.WearRate с правильным значением", ExpectedResult = 0.45)]
        [TestCase(1.20, TestName = "Тестирование поля Car.WearRate  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase(-0.20, TestName = "Тестирование Car.WearRate с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double WearRateTest(double wearRate)
        {
            Car transport = new Car();
            return transport.WearRate = wearRate;
        }

        [Test]
        [TestCase(15, TestName = "Тестирование поля Car.FuelWaste с правильным значением", ExpectedResult = 15)]
        [TestCase(120, TestName = "Тестирование поля Car.FuelWaste  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase(-65, TestName = "Тестирование Car.FuelWaste с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double FuelWasteTest(double fuelWaste)
        {
            Car transport = new Car();
            return transport.FuelWaste = fuelWaste;
        }

        [Test]
        [TestCase(150.5, TestName = "Тестирование поля Car.Speed с правильным значением", ExpectedResult = 150.5)]
        [TestCase(-1, TestName = "Тестирование поля Car.Speed  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("speed", TestName = "Тестирование Car.Speed с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double SpeedTest(double speed)
        {
            Car transport = new Car();
            return transport.Speed = speed;
        }


        //TODO дописать констуктор с дефолтными занчениями и проверить присваивается ли это значение правильно


        [Test]
        [TestCase(55, TestName = "Тестирование поля Car.TankVolume с правильным значением", ExpectedResult = 55)]
        [TestCase(101, TestName = "Тестирование поля Car.TankVolume  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование Car.TankVolume с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double TankVolumeTest(double tankVolume)
        {
            Car transport = new Car();
            return transport.TankVolume = tankVolume;
        }
    }
}