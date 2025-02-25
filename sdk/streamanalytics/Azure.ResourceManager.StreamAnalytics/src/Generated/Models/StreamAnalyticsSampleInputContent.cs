// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The stream analytics input to sample. </summary>
    public partial class StreamAnalyticsSampleInputContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSampleInputContent"/>. </summary>
        public StreamAnalyticsSampleInputContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSampleInputContent"/>. </summary>
        /// <param name="input"> The stream analytics input to sample. </param>
        /// <param name="compatibilityLevel"> Defaults to the default ASA job compatibility level. Today it is 1.2. </param>
        /// <param name="eventsUri"> The SAS URI of the storage blob for service to write the sampled events to. If this parameter is not provided, service will write events to he system account and share a temporary SAS URI to it. </param>
        /// <param name="dataLocalion"> Defaults to en-US. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsSampleInputContent(StreamingJobInputData input, string compatibilityLevel, Uri eventsUri, AzureLocation? dataLocalion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            CompatibilityLevel = compatibilityLevel;
            EventsUri = eventsUri;
            DataLocalion = dataLocalion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The stream analytics input to sample. </summary>
        public StreamingJobInputData Input { get; set; }
        /// <summary> Defaults to the default ASA job compatibility level. Today it is 1.2. </summary>
        public string CompatibilityLevel { get; set; }
        /// <summary> The SAS URI of the storage blob for service to write the sampled events to. If this parameter is not provided, service will write events to he system account and share a temporary SAS URI to it. </summary>
        public Uri EventsUri { get; set; }
        /// <summary> Defaults to en-US. </summary>
        public AzureLocation? DataLocalion { get; set; }
    }
}
