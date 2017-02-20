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
        void SetWearRate();
        void SetFuelWaste();
        void SetSpeed();
        void SetWay();
        void SetTankVolume();
    }
}
