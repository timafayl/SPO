using System;

namespace FuelCalculation
{
    public class HelicopterTransportProperty : ITransportProperty
    {
        private double _wearRate;
        private double _fuelWaste;
        private double _speed;
        private double _mass;
        private double _way;
        private double _tankVolume;

        public double WearRate
        {
            get { return _wearRate; }
            set
            {
                if ((_wearRate >= 0) && (_wearRate <= 1))
                    _wearRate = value;
                else
                    throw new ArgumentException("Неверно указан износ ТС, значение должно быть от 0 до 1");
            }
        }

        public double FuelWaste
        {
            get { return _fuelWaste; }
            set
            {
                if ((_fuelWaste >= 20) && (_fuelWaste <= 50))
                    _fuelWaste = value;
                else
                    throw new ArgumentException("Неверно указан расход топлива, значение должно быть от 20 до 50");
            }
        }

        public double Speed
        {
            get { return _speed; }
            set
            {
                if ((_speed > 1) && (_speed < 400))
                    _speed = value;
                else
                    throw new ArgumentException("Неверно указана скорость, значение должно быть от 1 до 400");
            }
        }

        /// <summary>
        /// Аксессор для получения значения массы груза на вертолете
        /// </summary>
        /// <returns>Массу груза</returns>
        public double Mass
        {
            get { return _mass; }
            set
            {
                if ((_mass > 0) && (_mass < 1000))
                    _mass = value;
                else
                    throw new ArgumentException("Неверно указана массы, значение должно быть от 1 до 1000");
            }
        }

        public double Way
        {
            get { return _way; }
            set
            {
                if (_way > 0)
                    _way = value;
                else
                    throw new ArgumentException("Неверно указан путь, значение должно быть больше нуля");
            }
        }

        public double TankVolume
        {
            get { return _tankVolume; }
            set
            {
                if ((_tankVolume >= 50) && (_tankVolume <= 200))
                    _tankVolume = value;
                else
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 50 до 200");
            }
        }

        public bool SuccessProbobility()
        {
            double calcValue = 0.01 * _fuelWaste * (1 + _wearRate) * (_speed / 40) * (1 + 0.0001*_mass) * (_way / _speed);

            _wearRate += 0.01 * _way / 10;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
