// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace AzureIotEdgeSimulatedCubie
{
    public class CubieDataFactory
    {
        private static readonly Random rand = new Random();
        private static double CurrentBatteryLife;

        public static BatteryLifeMessageBody CreateBatteryData(String deviceName, String deviceId, DataGenerationPolicy policy = null) {
            
           CubieDataFactory.CurrentBatteryLife = policy.CalculateBatteryLife();

            var batteryLifeMessage = new BatteryLifeMessageBody
            {
                DeviceName = deviceName,
                DeviceId = deviceId,
                BatteryLife = CurrentBatteryLife,
                TimeCreated = string.Format("{0:O}", DateTime.Now)
            };

            return batteryLifeMessage;
        }

        public static LidStatusMessageBody CreateLidStatusData(String deviceName, String deviceId, bool lidStatus) {
            var lidStatusMessage = new LidStatusMessageBody
            {
                DeviceName = deviceName,
                DeviceId = deviceId,
                LidStatus = lidStatus,
                TimeCreated = string.Format("{0:O}", DateTime.Now)
            };

            return lidStatusMessage;
        }

        public static GreenLedStatusMessageBody CreateGreenLedStatusData(String deviceName, String deviceId, bool greenLedStatus) {
            var greenLedMessage = new GreenLedStatusMessageBody
            {
                DeviceName = deviceName,
                DeviceId = deviceId,
                GreenLedStatus = greenLedStatus,
                TimeCreated = string.Format("{0:O}", DateTime.Now)
            };

            return greenLedMessage;
        }

        public static LocationMessageBody CreateLocationData(String deviceName, String deviceId, String location) {
            var locationMessage = new LocationMessageBody
            {
                DeviceName = deviceName,
                DeviceId = deviceId,
                Location = location,
                TimeCreated = string.Format("{0:O}", DateTime.Now)
            };

            return locationMessage;
        }

        // public static MessageBody CreateTemperatureData(int counter, DataGenerationPolicy policy, bool reset = false)
        // {
        //     if(reset)
        //     {
        //         TemperatureDataFactory.CurrentMachineTemperature = policy.CalculateMachineTemperature();
        //     }
        //     else
        //     {
        //         TemperatureDataFactory.CurrentMachineTemperature =
        //             policy.CalculateMachineTemperature(TemperatureDataFactory.CurrentMachineTemperature);
        //     }

        //     var machinePressure = policy.CalculatePressure(TemperatureDataFactory.CurrentMachineTemperature);
        //     var ambientTemperature = policy.CalculateAmbientTemperature();
        //     var ambientHumidity = policy.CalculateHumidity();

        //     var messageBody = new MessageBody
        //     {
        //         Machine = new Machine
        //         {
        //             Temperature = TemperatureDataFactory.CurrentMachineTemperature,
        //             Pressure =  machinePressure
        //         },
        //         Ambient = new Ambient
        //         {
        //             Temperature = ambientTemperature,
        //             Humidity = ambientHumidity
        //         },
        //         TimeCreated = string.Format("{0:O}", DateTime.Now)
        //     };

        //     return messageBody;
        // }
    }
}
