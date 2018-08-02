// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class BaseMessageBody
    {
        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
        public string TimeCreated { get; set; }
    }
}
