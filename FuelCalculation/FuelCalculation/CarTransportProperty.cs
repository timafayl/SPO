using System;

namespace FuelCalculation
{
    public class CarTransportProperty : ITransportProperty
    {
        /// <summary>
        /// Модель вертолёта
        /// </summary>
        private string _carName;
        /// <summary>
        /// Степень износа авто
        /// </summary>
        private double _wearRate;
        /// <summary>
        /// Расход топлива на 100 км
        /// </summary>
        private double _fuelWaste;
        /// <summary>
        /// Скорость авто во время поездки
        /// </summary>
        private double _speed;
        /// <summary>
        /// Используемый тип топлива
        /// </summary>
        private string _fuelType;
        /// <summary>
        /// Заданный путь
        /// </summary>
        private double _way;
        /// <summary>
        /// Общий объём бака
        /// </summary>
        private double _tankVolume;
        
        /// <summary>
        /// Конструктор класса CarTransportProperty
        /// </summary>
        /// <param name="copterName">марка машины</param>
        /// <param name="wearRate">степень износа</param>
        /// <param name="fuelWaste">расход топлива</param>
        /// <param name="speed">скорость</param>
        /// <param name="fuelType">вид топлива</param>
        /// <param name="way">расстояние</param>
        /// <param name="tankVolume">объём бака</param>
        public CarTransportProperty(string carName, double wearRate, double fuelWaste, double speed, string fuelType, double way, double tankVolume)
        {
            CarName = carName;
            WearRate = wearRate;
            FuelWaste = fuelWaste;
            Speed = speed;
            FuelType = fuelType;
            Way = way;
            TankVolume = tankVolume;
        }

        /// <summary>
        /// Аксессор для получения значения марки машины
        /// </summary>
        public string CarName
        {
            get { return _carName; }
            set
            {
                value = value.ToLower();
                foreach (char letter in value)
                {
                    if (((int)letter < 97) || ((int)letter > 122))
                    {
                        throw new ArgumentException(
                            "Неверно указана марка авто, значение должно содержать только буквы латинского алфавита");
                    }
                }

                _carName = value;
            }
        }

        /// <summary>
        /// Аксессор для получения значения износа авто
        /// </summary>
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

        /// <summary>
        /// Аксессор для получения значения расхода топлива
        /// </summary>
        public double FuelWaste
        {
            get { return _fuelWaste; }
            set
            {
                if ((value >= 5) && (value <= 30))
                    _fuelWaste = value;
                else
                    throw new ArgumentException("Неверно указан расход топлива, значение должно быть от 5 до 30");
            }
        }

        /// <summary>
        /// Аксессор для получения значения скорости
        /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if ((value > 1) && (value < 180))
                    _speed = value;
                else
                    throw new ArgumentException("Неверно указана скорость, значение должно быть от 1 до 180");
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
                    _fuelType = value;
                else
                    throw new ArgumentException("Неверно указан тип топлива, значение может быть либо 'бензин', либо 'дизель'");
            }
        }

        /// <summary>
        /// Аксессор для получения значения расстояния
        /// </summary>
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

        /// <summary>
        /// Аксессор для получения значения объёма бака
        /// </summary>
        public double TankVolume
        {
            get { return _tankVolume; }
            set
            {
                if ((value >= 20) && (value <= 100))
                    _tankVolume = value;
                else
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 20 до 100");
            }
        }

        /// <summary>
        /// Метод, вычисляющий вероятность успеха поездки
        /// </summary>
        /// <returns>true или false в зависимости от успеха поездки</returns>
        public bool SuccessProbobility()
        {
            double calcValue;

            if (_fuelType == "бензин")
            {
                calcValue = 0.01 * _fuelWaste * (1 + _wearRate * 0.1) * (_speed/80) * _way;
            }
            else
            {
                calcValue = 0.9* 0.01 * _fuelWaste * (1 + _wearRate * 0.1) * (_speed / 80) * _way;
            }

            _wearRate += 0.0001 * _way;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
