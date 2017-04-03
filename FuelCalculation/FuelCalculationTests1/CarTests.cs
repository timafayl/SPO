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
        [TestCase(0.45, TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = 0.45)]
        [TestCase(1.20, TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase(-0.20, TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double WearRateTest(double wearRate)
        {
            Car transport = new Car();
            return transport.WearRate = wearRate;
        }

        [Test]
        [TestCase(15, TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = "shkoda")]
        [TestCase(120, TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase(-65, TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double FuelWasteTest(double fuelWaste)
        {
            Car transport = new Car();
            return transport.FuelWaste = fuelWaste;
        }

        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = "shkoda")]
        [TestCase("Shkoda", TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double SpeedTest(double speed)
        {
            Car transport = new Car();
            return transport.Speed = speed;
        }

        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = "shkoda")]
        [TestCase("Shkoda", TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public FuelType FuelTypeTest(FuelType fuelType)
        {
            Car transport = new Car();
            return transport.FuelType = fuelType;
        }

        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Car.TransportName с правильным значением", ExpectedResult = "shkoda")]
        [TestCase("Shkoda", TestName = "Тестирование поля Car.TransportName  с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование CopterTransport.Name с ошибочными данными", ExpectedException = typeof(ArgumentException))]
        public double TankVolumeTest(double tankVolume)
        {
            Car transport = new Car();
            return transport.TankVolume = tankVolume;
        }
    }
}