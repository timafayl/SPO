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
        double getWearRate();
        double getFuelWaste();
        double getSpeed();
        double getWay();
        double getTankVolume();
        void setWearRate();
        void setFuelWaste();
        void setSpeed();
        void setWay();
        void setTankVolume();
    }
}
