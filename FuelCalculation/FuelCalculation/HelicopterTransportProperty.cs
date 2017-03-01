using System;

namespace FuelCalculation
{
    public class Helicopter : ITransportProperty
    {
        /// <summary>
        /// Модель вертолёта.
        /// </summary>
        private string _copterName;
        /// <summary>
        /// Степень износа вертолёта.
        /// </summary>
        private double _wearRate;
        /// <summary>
        /// Расход топлива за 1 час.
        /// </summary>
        private double _fuelWaste;
        /// <summary>
        /// Скорость авто во время поездки.
        /// </summary>
        private double _speed;
        /// <summary>
        /// Масса груза.
        /// </summary>
        private double _mass;
        /// <summary>
        /// Общий объём бака.
        /// </summary>
        private double _tankVolume;

        /// <summary>
        /// Конструктор класса Helicopter.
        /// </summary>
        public Helicopter() { }

        /// <summary>
        /// Конструктор класса Helicopter.
        /// </summary>
        /// <param name="copterName">Модель вертолёта</param>
        /// <param name="wearRate">Степень износа</param>
        /// <param name="fuelWaste">Расход топлива</param>
        /// <param name="speed">Скорость</param>
        /// <param name="mass">Масса груза</param>
        /// <param name="way">Расстояние</param>
        /// <param name="tankVolume">Объём бака</param>
        public Helicopter(string copterName, double wearRate, double fuelWaste, double speed, double mass, double tankVolume)
        {
            TransportName = copterName;
            WearRate = wearRate;
            FuelWaste = fuelWaste;
            Speed = speed;
            Mass = mass;
            TankVolume = tankVolume;
        }

        /// <summary>
        /// Аксессор для получения значения модели вертолёта.
        /// </summary>
        public string TransportName
        {
            get { return _copterName; }
            set
            {
                //value = value.ToLower();
                foreach (char letter in value)
                {
                    if ((letter < 'a') || (letter > 'z'))
                    {
                        throw new ArgumentException(
                            "Неверно указана марка авто, значение должно содержать только буквы латинского алфавита");
                    }
                }

                _copterName = value;
            }
        }

        /// <summary>
        /// Аксессор для получения значения износа транспортного средства.
        /// </summary>
        public double WearRate
        {
            get { return _wearRate; }
            set
            {
                if ((value >= 0) && (value <= 1))
                {
                    _wearRate = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан износ ТС, значение должно быть от 0 до 1");
                }
            }
        }

        /// <summary>
        /// Аксессор для получения значения расхода топлива.
        /// </summary>
        public double FuelWaste
        {
            get { return _fuelWaste; }
            set
            {
                if ((value >= 20) && (value <= 50))
                {
                    _fuelWaste = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан расход топлива, значение должно быть от 20 до 50");
                }
            }
        }

        /// <summary>
        /// Аксессор для получения значения скорости.
        /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if ((value > 1) && (value < 400))
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указана скорость, значение должно быть от 1 до 400");
                }
            }
        }

        /// <summary>
        /// Аксессор для получения значения массы груза на вертолете.
        /// </summary>
        /// <returns>Массу груза</returns>
        public double Mass
        {
            get { return _mass; }
            set
            {
                if ((value > 0) && (value < 1000))
                {
                    _mass = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указана массы, значение должно быть от 1 до 1000");
                }
            }
        }

        /// <summary>
        /// Аксессор для получения значения объёма бака.
        /// </summary>
        public double TankVolume
        {
            get { return _tankVolume; }
            set
            {
                if ((value >= 50) && (value <= 200))
                {
                    _tankVolume = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 50 до 200");
                }
            }
        }

        /// <summary>
        /// Метод, вычисляющий вероятность успеха поездки.
        /// </summary>
        /// <param name="distance">Переменная для получения значения рассчитываемого количества топлива</param>
        /// <returns>true или false в зависимости от успеха поездки</returns>
        public bool IsCanPassDistance(double distance)
        {
            double calcValue = 0.01 * _fuelWaste * (1 + _wearRate * 0.1) * (_speed / 200) * (1 + 0.0001*_mass) * (distance / _speed);

            _wearRate += 0.0001 * distance;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
