using System;
using NUnit.Framework;


namespace FuelCalculation.Tests
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Car.TransportName с латинскими символами нижнего регистра", ExpectedResult = "shkoda")]
        [TestCase("Shkoda", TestName = "Тестирование поля Car.TransportName  с включением символов верхнего регистра", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование Car.Name с пустым значением строки", ExpectedException = typeof(ArgumentException))]
        public string TransportNameTest(string name)
        {
            Car transport = new Car();
            return transport.TransportName = name;
        }

        [Test]
        [TestCase(0.45, TestName = "Тестирование поля Car.WearRate со значением диапазона 0-1", ExpectedResult = 0.45)]
        [TestCase(1.20, TestName = "Тестирование поля Car.WearRate со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(-0.20, TestName = "Тестирование Car.WearRate со значением меньше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double WearRateTest(double wearRate)
        {
            Car transport = new Car();
            return transport.WearRate = wearRate;
        }

        [Test]
        [TestCase(15, TestName = "Тестирование поля Car.FuelWaste со значением диапазона 5-30", ExpectedResult = 15)]
        [TestCase(120, TestName = "Тестирование поля Car.FuelWaste со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(-65, TestName = "Тестирование Car.FuelWaste со значением меньше чем, заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double FuelWasteTest(double fuelWaste)
        {
            Car transport = new Car();
            return transport.FuelWaste = fuelWaste;
        }

        [Test]
        [TestCase(150.5, TestName = "Тестирование поля Car.Speed со значением диапазона 1-180", ExpectedResult = 150.5)]
        [TestCase(0, TestName = "Тестирование поля Car.Speed  со значением меньше чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(200, TestName = "Тестирование Car.Speed со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double SpeedTest(double speed)
        {
            Car transport = new Car();
            return transport.Speed = speed;
        }


        //TODO дописать констуктор с дефолтными занчениями и проверить присваивается ли это значение правильно


        [Test]
        [TestCase(55, TestName = "Тестирование поля Car.TankVolume со значением диапазона 20-100", ExpectedResult = 55)]
        [TestCase(101, TestName = "Тестирование поля Car.TankVolume  со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(15, TestName = "Тестирование Car.TankVolume со значением меньше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double TankVolumeTest(double tankVolume)
        {
            Car transport = new Car();
            return transport.TankVolume = tankVolume;
        }
    }
}