using System;

namespace FuelCalculation
{
    public interface ITransportProperty
    {
        /// <summary>
        /// Метод, вычисляющий вероятность успеха поездки.
        /// </summary>
        /// <returns>Возвращает true или false в зависимости от того, сможет трансортное средство проехать заднный путь, или же нет</returns>
        bool IsCanPassDistance(double distance);

        /// <summary>
        /// Наименование транспорта.
        /// </summary>
        string TransportName { get; set; }

        /// <summary>
        /// Аксессор для получения значения износа транспортного средства.
        /// </summary>
        /// <returns>Значение износа транспортного средства</returns>
        double WearRate { get; set; }

        /// <summary>
        /// Аксессор для получения значения расхода топлива на 100 км транспортным средством.
        /// </summary>
        /// <returns>Значения расхода топлива на 100 км</returns>
        double FuelWaste { get; set; }

        /// <summary>
        /// Аксессор для получения значения скорости передвижения во время передвижения.
        /// </summary>
        /// <returns>Значение скорости передвижения</returns>
        double Speed { get; set; }

        /// <summary>
        /// Аксессор для получения объёма бака транспортного средства.
        /// </summary>
        /// <returns>Объём бака</returns>
        double TankVolume { get; set; }
    }
}
