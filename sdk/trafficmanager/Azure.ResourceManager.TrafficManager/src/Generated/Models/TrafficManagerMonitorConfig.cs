// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.TrafficManager;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Class containing endpoint monitoring settings in a Traffic Manager profile. </summary>
    public partial class TrafficManagerMonitorConfig
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

        /// <summary> Initializes a new instance of <see cref="TrafficManagerMonitorConfig"/>. </summary>
        public TrafficManagerMonitorConfig()
        {
            CustomHeaders = new ChangeTrackingList<TrafficManagerMonitorConfigCustomHeaderInfo>();
            ExpectedStatusCodeRanges = new ChangeTrackingList<ExpectedStatusCodeRangeInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerMonitorConfig"/>. </summary>
        /// <param name="profileMonitorStatus"> The profile-level monitoring status of the Traffic Manager profile. </param>
        /// <param name="protocol"> The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health. </param>
        /// <param name="port"> The TCP port used to probe for endpoint health. </param>
        /// <param name="path"> The path relative to the endpoint domain name used to probe for endpoint health. </param>
        /// <param name="intervalInSeconds"> The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile. </param>
        /// <param name="timeoutInSeconds"> The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check. </param>
        /// <param name="toleratedNumberOfFailures"> The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check. </param>
        /// <param name="customHeaders"> List of custom headers. </param>
        /// <param name="expectedStatusCodeRanges"> List of expected status code ranges. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerMonitorConfig(TrafficManagerProfileMonitorStatus? profileMonitorStatus, TrafficManagerMonitorProtocol? protocol, long? port, string path, long? intervalInSeconds, long? timeoutInSeconds, long? toleratedNumberOfFailures, IList<TrafficManagerMonitorConfigCustomHeaderInfo> customHeaders, IList<ExpectedStatusCodeRangeInfo> expectedStatusCodeRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProfileMonitorStatus = profileMonitorStatus;
            Protocol = protocol;
            Port = port;
            Path = path;
            IntervalInSeconds = intervalInSeconds;
            TimeoutInSeconds = timeoutInSeconds;
            ToleratedNumberOfFailures = toleratedNumberOfFailures;
            CustomHeaders = customHeaders;
            ExpectedStatusCodeRanges = expectedStatusCodeRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The profile-level monitoring status of the Traffic Manager profile. </summary>
        public TrafficManagerProfileMonitorStatus? ProfileMonitorStatus { get; set; }
        /// <summary> The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health. </summary>
        public TrafficManagerMonitorProtocol? Protocol { get; set; }
        /// <summary> The TCP port used to probe for endpoint health. </summary>
        public long? Port { get; set; }
        /// <summary> The path relative to the endpoint domain name used to probe for endpoint health. </summary>
        public string Path { get; set; }
        /// <summary> The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile. </summary>
        public long? IntervalInSeconds { get; set; }
        /// <summary> The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check. </summary>
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check. </summary>
        public long? ToleratedNumberOfFailures { get; set; }
        /// <summary> List of custom headers. </summary>
        public IList<TrafficManagerMonitorConfigCustomHeaderInfo> CustomHeaders { get; }
        /// <summary> List of expected status code ranges. </summary>
        public IList<ExpectedStatusCodeRangeInfo> ExpectedStatusCodeRanges { get; }
    }
}
