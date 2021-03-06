﻿using System;
using NUnit.Framework;


namespace FuelCalculation.Tests
{
    [TestFixture]
    public class HelicopterTests
    {
        [Test]
        [TestCase("shkoda", TestName = "Тестирование поля Helicopter.TransportName с латинскими символами нижнего регистра", ExpectedResult = "shkoda")]
        [TestCase("ShkOda", TestName = "Тестирование поля Helicopter.TransportName  с включением символов верхнего регистра", ExpectedException = typeof(ArgumentException))]
        [TestCase("", TestName = "Тестирование Helicopter.Name с пустым значением строки", ExpectedException = typeof(ArgumentException))]
        public string TransportNameTest(string name)
        {
            Helicopter transport = new Helicopter();
            return transport.TransportName = name;
        }

        [Test]
        [TestCase(0.45, TestName = "Тестирование поля Helicopter.WearRate со значением диапазона 0-1", ExpectedResult = 0.45)]
        [TestCase(1.20, TestName = "Тестирование поля Helicopter.WearRate со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(-0.20, TestName = "Тестирование Helicopter.WearRate со значением меньше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double WearRateTest(double wearRate)
        {
            Helicopter transport = new Helicopter();
            return transport.WearRate = wearRate;
        }

        [Test]
        [TestCase(30, TestName = "Тестирование поля Helicopter.FuelWaste со значением диапазона 20-50", ExpectedResult = 30)]
        [TestCase(120, TestName = "Тестирование поля Helicopter.FuelWaste со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(-65, TestName = "Тестирование Helicopter.FuelWaste со значением меньше чем, заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double FuelWasteTest(double fuelWaste)
        {
            Helicopter transport = new Helicopter();
            return transport.FuelWaste = fuelWaste;
        }

        [Test]
        [TestCase(399, TestName = "Тестирование поля Helicopter.Speed со значением диапазона 1-400", ExpectedResult = 399)]
        [TestCase(0, TestName = "Тестирование поля Helicopter.Speed  со значением меньше чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(400.1, TestName = "Тестирование Helicopter.Speed со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double SpeedTest(double speed)
        {
            Helicopter transport = new Helicopter();
            return transport.Speed = speed;
        }

        [Test]
        [TestCase(124, TestName = "Тестирование поля Helicopter.TankVolume со значением диапазона 20-100", ExpectedResult = 124)]
        [TestCase(300, TestName = "Тестирование поля Helicopter.TankVolume  со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(49.5, TestName = "Тестирование Helicopter.TankVolume со значением меньше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double TankVolumeTest(double tankVolume)
        {
            Helicopter transport = new Helicopter();
            return transport.TankVolume = tankVolume;
        }

        [Test]
        [TestCase(845, TestName = "Тестирование поля Helicopter.Mass со значением диапазона 20-100", ExpectedResult = 845)]
        [TestCase(1001, TestName = "Тестирование поля Helicopter.Mass  со значением больше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        [TestCase(0, TestName = "Тестирование Helicopter.Mass со значением меньше, чем заданный диапазон", ExpectedException = typeof(ArgumentException))]
        public double MassTest(double mass)
        {
            Helicopter transport = new Helicopter();
            return transport.Mass = mass;
        }

        [Test]
        [TestCase(1000, "accura", 0.15, 30, 200, 500, 110,
            TestName = "Тестирование метода Helicopter.IsCanPassDistanec с созданным объектом, при котором значение " +
            "при заданной дистанции будет true", ExpectedResult = true)]
        [TestCase(1500, "accura", 0.9, 30, 250, 800, 200,
            TestName = "Тестирование метода Helicopter.IsCanPassDistanec с созданным объектом, при котором " +
            "значение при заданной дистанции будет false, из-за достижения максильмального износа вертолёта", ExpectedResult = false)]
        [TestCase(1500, "accura", 0.9, 30, 250, 800, 150,
            TestName = "Тестирование метода Helicopter.IsCanPassDistanec с созданным объектом, при котором " +
            "значение при заданной дистанции будет false, из-за достижения максимального износа вертолёта, а также недостаточного объёма бака", ExpectedResult = false)]
        [TestCase(500, "accura", 0.05, 30, 250, 500, 100,
            TestName = "Тестирование метода Helicopter.IsCanPassDistanec с созданным объектом, при котором " +
            "значение при заданной дистанции будет false, из-за недостаточного объёма бака", ExpectedResult = true)]
        public bool IsCanPassDistanceTest(int distance, string name, double wearRate, double fuelWaste,
            double speed, double mass, double tankVolume)
        {
            Helicopter transport = new Helicopter(name, wearRate, fuelWaste, speed, mass, tankVolume);
            return transport.IsCanPassDistance(distance);
        }
    }
}