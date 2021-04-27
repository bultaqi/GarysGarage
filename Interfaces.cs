using System;

namespace GarysGarage
{

    public interface IElectricVehicles
    {

        int CurrentChargePercentage {get; set;}
        void ChargeBattery();

    }

    public interface IGasVehicles
    {

        int CurrentTankPercentage {get; set;}

        void RefuelTank();

    }

























}