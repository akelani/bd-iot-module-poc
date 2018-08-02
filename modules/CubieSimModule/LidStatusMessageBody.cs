// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class LidStatusMessageBody : BaseMessageBody
    {
        [JsonProperty("lidStatus")]
        public bool LidStatus { get; set; }
    }
}
