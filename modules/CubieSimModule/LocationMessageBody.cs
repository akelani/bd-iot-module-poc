// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace AzureIotEdgeSimulatedCubie
{
    public class LocationMessageBody : BaseMessageBody
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
