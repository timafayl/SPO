using System;

namespace FuelCalculation
{
    public class Car : ITransportProperty
    {
        /// <summary>
        /// Марка машины.
        /// </summary>
        private string _carName;
        /// <summary>
        /// Степень износа авто.
        /// </summary>
        private double _wearRate;
        /// <summary>
        /// Расход топлива на 100 км.
        /// </summary>
        private double _fuelWaste;
        /// <summary>
        /// Скорость авто во время поездки.
        /// </summary>
        private double _speed;
        /// <summary>
        /// Используемый тип топлива.
        /// </summary>
        private string _fuelType;
        /// <summary>
        /// Общий объём бака.
        /// </summary>
        private double _tankVolume;

        /// <summary>
        /// Конструктор класса CarTransportProperty.
        /// </summary>
        public Car() { }

        /// <summary>
        /// Конструктор класса CarTransport.
        /// </summary>
        /// <param name="carName">Марка машины</param>
        /// <param name="wearRate">Степень износа</param>
        /// <param name="fuelWaste">Расход топлива</param>
        /// <param name="speed">Скорость</param>
        /// <param name="fuelType">Вид топлива</param>
        /// <param name="way">Расстояние</param>
        /// <param name="tankVolume">Объём бака</param>
        public Car(string carName, double wearRate, double fuelWaste, double speed, string fuelType, double tankVolume)
        {
            TransportName = carName;
            WearRate = wearRate;
            FuelWaste = fuelWaste;
            Speed = speed;
            FuelType = fuelType;
            TankVolume = tankVolume;
        }

        /// <summary>
        /// Аксессор для получения значения марки машины.
        /// </summary>
        public string TransportName
        {
            get { return _carName; }
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

                _carName = value;
            }
        }

        /// <summary>
        /// Аксессор для получения значения износа авто.
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
                if ((value >= 5) && (value <= 30))
                {
                    _fuelWaste = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан расход топлива, значение должно быть от 5 до 30");
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
                if ((value > 1) && (value < 180))
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указана скорость, значение должно быть от 1 до 180");
                }
            }
        }

        /// <summary>
        /// Аксессор для получения значения типа топлива авто.
        /// </summary>
        /// <returns>Массу груза</returns>
        public string FuelType
        {
            get { return _fuelType; }
            set
            {
                value = value.ToLower();
                if ((value == "бензин") || (value == "дизель"))
                {
                    _fuelType = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан тип топлива, значение может быть либо 'бензин', либо 'дизель'");
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
                if ((value >= 20) && (value <= 100))
                {
                    _tankVolume = value;
                }
                else
                {
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 20 до 100");
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
            double calcValue;

            var coef = (_fuelType == "бензин") ? 1 : 0.9;
       
            calcValue = coef * 0.01 * _fuelWaste * (1 + _wearRate * 0.1) * (_speed/80) * distance;

            _wearRate += 0.0001 * distance;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
