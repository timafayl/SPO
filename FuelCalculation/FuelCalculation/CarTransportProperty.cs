using System;

namespace FuelCalculation
{
    public class CarTransportProperty : ITransportProperty
    {
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
                if ((_fuelWaste >= 5) && (_fuelWaste <= 30))
                    _fuelWaste = value;
                else
                    throw new ArgumentException("Неверно указан расход топлива, значение должно быть от 5 до 30");
            }
        }

        public double Speed
        {
            get { return _speed; }
            set
            {
                if ((_speed > 1) && (_speed < 180))
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
                if ((_fuelType == "бензин") || (_fuelType == "дизель"))
                    _fuelType = value;
                else
                    throw new ArgumentException("Неверно указан тип топлива, значение может быть либо 'бензин', либо 'дизель'");
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
                if ((_tankVolume >= 20) && (_tankVolume <= 100))
                    _tankVolume = value;
                else
                    throw new ArgumentException("Неверно указан объём бака, значение должно быть в диапозоне от 20 до 100");
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

            _wearRate += 0.01*_way/10;

            return ((calcValue <= _tankVolume) && (_wearRate <= 1));
        }
    }
}
