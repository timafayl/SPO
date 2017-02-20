using System;

namespace FuelCalculation
{
    public interface ITransportProperty
    {
        /// <summary>
        /// Метод расчета расхода топлива транспортным средством
        /// </summary>
        /// <returns></returns>
        bool SuccessProbobility();
        double GetWearRate();
        double GetFuelWaste();
        double GetSpeed();
        double GetWay();
        double GetTankVolume();
        double SetWearRate();
        double SetFuelWaste();
        double SetSpeed();
        double SetWay();
        double SetTankVolume();
    }
}
