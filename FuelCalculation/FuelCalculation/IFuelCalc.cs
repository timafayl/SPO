using System;

namespace FuelCalculation
{
    public interface ITransportProperty
    {
        /// <summary>
        /// Метод расчета расхода топлива транспортным средством
        /// </summary>
        /// <returns>Возвращает true или false в зависимости от того, сможет трансортное средство проехать заднный путь, или же нет</returns>
        bool SuccessProbobility();
        /// <summary>
        /// Аксессор для получения значения износа транспортного средства
        /// </summary>
        /// <returns>Значение износа транспортного средства</returns>
        double GetWearRate();
        /// <summary>
        /// Аксессор для получения значения расхода топлива на 100 км транспортным средством
        /// </summary>
        /// <returns>Значения расхода топлива на 100 км</returns>
        double GetFuelWaste();
        /// <summary>
        /// Аксессор для получения значения скорости передвижения во время передвижения
        /// </summary>
        /// <returns>Значение скорости передвижения</returns>
        double GetSpeed();
        /// <summary>
        /// Аксессор для получения значения пути, который нужно преодолеть
        /// </summary>
        /// <returns>Значение пути, который нужно преодолеть</returns>
        double GetWay();
        /// <summary>
        /// Аксессор для получения объёма бака транспортного средства
        /// </summary>
        /// <returns>Объём бака</returns>
        double GetTankVolume();
        /// <summary>
        /// Аксессор для внесения значения износа 
        /// </summary>
        void SetWearRate();
        /// <summary>
        /// Аксессор для внесения значения расход топлива на 100 км
        /// </summary>
        void SetFuelWaste();
        /// <summary>
        /// Аксессор для внесения значения скорости передвижения
        /// </summary>
        void SetSpeed();
        /// <summary>
        /// Аксессор для внесения значения пути, который необходимо пройти
        /// </summary>
        void SetWay();
        /// <summary>
        /// Аксессор для внесения значения объёма бака
        /// </summary>
        void SetTankVolume();
    }
}
