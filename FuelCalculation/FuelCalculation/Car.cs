using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculation
{
    public class Car : ITransportProperty
    {
        private double _wearRate;
        private double _fuelWaste;
        private double _speed;
        private string _fuelType;
        private double _way;
        private double _tankVolume;

        public double getWearRate()
        {
            return _wearRate ;
        }

        public double getFuelWaste()
        {
            return _fuelWaste;
        }

        public double getSpeed()
        {
            return _speed;
        }

        public string getFuelType()
        {
            return _fuelType;
        }

        public double getWay()
        {
            return _way;
        }

        public double getTankVolume()
        {
            return _tankVolume;
        }

        public void setWearRate()
        {
            Console.WriteLine("Введите процент износа авто: ");
            _wearRate = Convert.ToDouble(Console.ReadLine());
            while ((_wearRate < 0) || (_wearRate > 1))
            {
                Console.WriteLine("Значение износа введено некорректно, значение должно быть вещественным числом от 0 до 1. Пожалуйста повторите попытку: ");
                _wearRate = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void setFuelWaste()
        {
            Console.WriteLine("Введите расход топлива на 100 км: ");
            _fuelWaste = Convert.ToDouble(Console.ReadLine());
            while ((_fuelWaste < 0) || (_fuelWaste > 30))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть вещественным числом от 0 до 30. Пожалуйста повторите попытку: ");
                _fuelWaste = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void setSpeed()
        {
            Console.WriteLine("Введите значение скорости (км/ч): ");
            _speed = Convert.ToDouble(Console.ReadLine());
            while ((_speed < 1) || (_speed > 180))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть в диапозоне от 1 до 180. Пожалуйста повторите попытку: ");
                _speed = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void setFuelType()
        {
            Console.WriteLine("Введите название используемого топлива: ");
            _fuelType = Console.ReadLine();
            while ((_fuelType != "бензин") || (_fuelType != "дизель"))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть либо 'бензин', либо 'дизель'. Пожалуйста повторите попытку: ");
                _fuelType = Console.ReadLine();
            }
        }

        public void setWay()
        {
            Console.WriteLine("Введите значение пути, который хотите проехать (км): ");
            _way = Convert.ToDouble(Console.ReadLine());
            while (_way < 0)
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть больше нуля. Пожалуйста повторите попытку: ");
                _way = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void setTankVolume()
        {
            Console.WriteLine("Введите объем бака авто (л): ");
            _tankVolume = Convert.ToDouble(Console.ReadLine());
            while ((_tankVolume < 20) || (_tankVolume > 100))
            {
                Console.WriteLine("Введенное значение некорректно, значение должно быть в диапозоне от 20 до 100. Пожалуйста повторите попытку: ");
                _tankVolume = Convert.ToDouble(Console.ReadLine());
            }
        }

        public bool SuccessProbobility()
        {
            double calcValue;
            if (_fuelType == "бензин")
            {
                calcValue = 0.01*_fuelWaste*(1 + _wearRate)*(_speed/40)*_way;
            }
            else
            {
                calcValue = 0.9*0.01*_fuelWaste*(1 + _wearRate)*(_speed/40)*_way;
            }

            if (calcValue <= _tankVolume)
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
