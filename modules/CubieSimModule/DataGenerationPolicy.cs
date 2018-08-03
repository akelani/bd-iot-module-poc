// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace AzureIotEdgeSimulatedCubie
{
    public class DataGenerationPolicy
    {
        private static readonly Random rnd = new Random();
        private double _normal;
        private double currentBatteryLife = 100;

        public DataGenerationPolicy()
        {
            BatteryLifeMin = 0.0;
            BatteryLifeMax = 100.0;
            // MachinePressureMin = 1;
            // MachinePressureMax = 10;
            // AmbientTemperature = 21;
            // HumidityPercentMin = 24;
            // HumidityPercentMax = 27;
            // _normal = (MachinePressureMax - MachinePressureMin) / (MachineTemperatureMax - MachineTemperatureMin);
        }

        public double BatteryLifeMin { get; private set; }
        public double BatteryLifeMax { get; private set; }
        // public double MachinePressureMin { get; private set; }
        // public double MachinePressureMax { get; private set; }
        // public double AmbientTemperature { get; private set; }
        // public int HumidityPercentMin { get; private set; }
        // public int HumidityPercentMax { get; set; }

        public double CalculateBatteryLife(double? initBatteryLife = null)
        {
            //var current = currentBatteryLife ?? BatteryLifeMin;
            if(currentBatteryLife > BatteryLifeMin) {
                currentBatteryLife -= 0.5;
            } else {
                currentBatteryLife = 100.0;
            }
            // if(current > BatteryLifeMax)
            // {
            //     current += rnd.NextDouble() - 0.5; // add value between [-0.5..0.5]
            // }
            // else
            // {
            //     current += -0.25 + (rnd.NextDouble() * 1.5); // add value between [-0.25..1.25] - avg +0.5
            // }
            return Math.Round(currentBatteryLife, 2);
        }

        // public double CalculatePressure(double currentTemperature)
        // {
        //     return MachinePressureMin + ((currentTemperature - MachineTemperatureMin) * _normal);
        // }

        // public double CalculateAmbientTemperature()
        // {
        //     return AmbientTemperature + rnd.NextDouble() -0.5;
        // }

        // public int CalculateHumidity()
        // {
        //     return rnd.Next(HumidityPercentMin, HumidityPercentMax);
        // }
    }
}
