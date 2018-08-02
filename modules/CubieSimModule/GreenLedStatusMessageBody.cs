// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class GreenLedStatusMessageBody : BaseMessageBody
    {
        [JsonProperty("greenLedStatus")]
        public bool GreenLedStatus { get; set; }
    }
}
