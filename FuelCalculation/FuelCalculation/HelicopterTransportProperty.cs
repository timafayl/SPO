using System;

namespace FuelCalculation
{
    public class HelicopterTransportProperty : ITransportProperty
    {
        /// <summary>
        /// Степень износа вертолёта
        /// </summary>
        private double _wearRate;
        /// <summary>
        /// Расход топлива за 1 час
        /// </summary>
        private double _fuelWaste;
        /// <summary>
        /// Скорость авто во время поездки
        /// </summary>
        private double _speed;
        /// <summary>
        /// Масса груза
        /// </summary>
        private double _mass;
        /// <summary>
        /// Заданный путь
        /// </summary>
        private double _way;
        /// <summary>
        /// Общий объём бака
        /// </summary>
        private double _tankVolume;

        public double WearRate
        {
            get { return _wearRate; }
            set
            {
                if ((value >= 0) && (value <= 1))
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
                if ((value >= 20) && (value <= 50))
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
                if ((value > 1) && (value < 400))
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
                if ((value > 0) && (value < 1000))
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
                if (value > 0)
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
                if ((value >= 50) && (value <= 200))
                    _tankVolume = value;
                else
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 50 до 200");
            }
        }

        public bool SuccessProbobility()
        {
            double calcValue = 0.01 * _fuelWaste * (1 + _wearRate * 0.1) * (_speed / 200) * (1 + 0.0001*_mass) * (_way / _speed);

            _wearRate += 0.0001 * _way;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
