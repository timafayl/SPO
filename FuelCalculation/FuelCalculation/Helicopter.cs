using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculation
{
    public class Helicopter: ITransportProperty
    {
        private double _wearRate;
        private double _fuelWaste;
        private double _speed;
        private double _mass;
        private double _way;
        private double _tankVolume;

        public double GetWearRate()
        {
            return _wearRate;
        }

        public double GetFuelWaste()
        {
            return _fuelWaste;
        }

        public double GetSpeed()
        {
            return _speed;
        }

        /// <summary>
        /// Аксессор для получения значения массы груза на вертолете
        /// </summary>
        /// <returns>Массу груза</returns>
        public double GetMass()
        {
            return _mass;
        }

        public double GetWay()
        {
            return _way;
        }

        public double GetTankVolume()
        {
            return _tankVolume;
        }

        public void SetWearRate()
        {
            Console.WriteLine("Введите процент износа авто: ");
            _wearRate = Convert.ToDouble(Console.ReadLine());
            while ((_wearRate < 0) || (_wearRate > 1))
            {
                Console.WriteLine("Значение износа введено некорректно, значение должно быть вещественным числом от 0 до 1. Пожалуйста повторите попытку: ");
                _wearRate = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void SetFuelWaste()
        {
            Console.WriteLine("Введите расход топлива на 100 км: ");
            _fuelWaste = Convert.ToDouble(Console.ReadLine());
            while ((_fuelWaste < 1) || (_fuelWaste > 50))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть вещественным числом от 1 до 50. Пожалуйста повторите попытку: ");
                _fuelWaste = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void SetSpeed()
        {
            Console.WriteLine("Введите значение скорости (км/ч): ");
            _speed = Convert.ToDouble(Console.ReadLine());
            while ((_speed < 1) || (_speed > 400))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть в диапозоне от 1 до 180. Пожалуйста повторите попытку: ");
                _speed = Convert.ToDouble(Console.ReadLine());
            }
        }

        /// <summary>
        /// Аксессор для установления значения массы груза
        /// </summary>
        public void SetMass()
        {
            Console.WriteLine("Введите массу перевозимого груза (кг): ");
            _mass = Convert.ToDouble(Console.ReadLine());
            while ((_mass < 0) || (_mass > 1000))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть в диапозоне от 0 до 1000. Пожалуйста повторите попытку: ");
                _mass = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void SetWay()
        {
            Console.WriteLine("Введите значение пути, который хотите проехать (км): ");
            _way = Convert.ToDouble(Console.ReadLine());
            while (_way < 0)
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть больше нуля. Пожалуйста повторите попытку: ");
                _way = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void SetTankVolume()
        {
            Console.WriteLine("Введите объем бака вертолета (л): ");
            _tankVolume = Convert.ToDouble(Console.ReadLine());
            while ((_tankVolume < 50) || (_tankVolume > 200))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть в диапозоне от 50 до 200. Пожалуйста повторите попытку: ");
                _tankVolume = Convert.ToDouble(Console.ReadLine());
            }
        }

        public bool SuccessProbobility()
        {
            double calcValue = 0.01 * _fuelWaste * (1 + _wearRate) * (_speed / 40) * (1 + 0.0001*_mass) * _way;

            _wearRate += 0.01 * _way / 10;

            if ((calcValue <= _tankVolume) && (_wearRate <= 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
