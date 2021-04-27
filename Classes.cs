
using System;

namespace GarysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"Vrooom!");
        }
    }

    public class Zero : IElectricVehicles // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()     
        {
            CurrentChargePercentage = 100;
        }   
        
    }

    public class Cessna : IGasVehicles
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        // public override void Drive()
        // {
        //     Console.WriteLine("Zoooooom!");
        // }
    }


    public class Tesla : IElectricVehicles // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }

    public class Ram : IGasVehicles // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }

}