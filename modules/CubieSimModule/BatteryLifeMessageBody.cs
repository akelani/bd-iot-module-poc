// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class BatteryLifeMessageBody : BaseMessageBody
    {
        [JsonProperty("batteryLife")]
        public int BatteryLife { get; set; }
    }
}
