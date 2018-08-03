// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class DesiredPropertiesData
    {
        private bool _sendData = true;
        private int _sendInterval = 5;

        private bool _lidStatus = true;
        private bool _greenLedStatus = true;
        private String _location = "Lab1";

        public DesiredPropertiesData(TwinCollection twinCollection)
        {
            Console.WriteLine($"Updating desired properties {twinCollection.ToJson(Formatting.Indented)}");
            try
            {
                if(twinCollection.Contains("SendData") && twinCollection["SendData"] != null)
                {
                    _sendData = twinCollection["SendData"];
                }

                if(twinCollection.Contains("SendInterval") && twinCollection["SendInterval"] != null)
                {
                    _sendInterval = twinCollection["SendInterval"];
                }

                if(twinCollection.Contains("SetLidStatus") && twinCollection["SetLidStatus"] != null)
                {
                    _lidStatus = twinCollection["SetLidStatus"];
                }

                if(twinCollection.Contains("SetGreenLedStatus") && twinCollection["SetGreenLedStatus"] != null)
                {
                    _greenLedStatus = twinCollection["SetGreenLedStatus"];
                }

                if(twinCollection.Contains("SetLocation") && twinCollection["SetLocation"] != null)
                {
                    _location = twinCollection["SetLocation"];
                }
            }
            catch(AggregateException aexc)
            {
                foreach(var exception in aexc.InnerExceptions)
                {
                    Console.WriteLine($"[ERROR] Could not retrieve desired properties {aexc.Message}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[ERROR] Reading desired properties failed with {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Value for SendData = {_sendData}");
                Console.WriteLine($"Value for SendInterval = {_sendInterval}");
                Console.WriteLine($"Value for LidStatus = {_lidStatus}");
                Console.WriteLine($"Value for GreenLedStatus = {_greenLedStatus}");
                Console.WriteLine($"Value for Location = {_location}");
            }
        }

        public bool SendData => _sendData;
        public int SendInterval => _sendInterval;
        public bool LidStatus => _lidStatus;
        public bool GreenLedStatus => _greenLedStatus;
        public String Location => _location;
    }
}
