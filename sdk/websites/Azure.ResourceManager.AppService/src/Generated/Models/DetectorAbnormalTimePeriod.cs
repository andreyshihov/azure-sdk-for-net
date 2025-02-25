// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Abnormal Time Period detected. </summary>
    public partial class DetectorAbnormalTimePeriod
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

        /// <summary> Initializes a new instance of <see cref="DetectorAbnormalTimePeriod"/>. </summary>
        public DetectorAbnormalTimePeriod()
        {
            MetaData = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
            Solutions = new ChangeTrackingList<DiagnosticSolution>();
        }

        /// <summary> Initializes a new instance of <see cref="DetectorAbnormalTimePeriod"/>. </summary>
        /// <param name="startOn"> Start time of the correlated event. </param>
        /// <param name="endOn"> End time of the correlated event. </param>
        /// <param name="message"> Message describing the event. </param>
        /// <param name="source"> Represents the name of the Detector. </param>
        /// <param name="priority"> Represents the rank of the Detector. </param>
        /// <param name="metaData"> Downtime metadata. </param>
        /// <param name="issueType"> Represents the type of the Detector. </param>
        /// <param name="solutions"> List of proposed solutions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectorAbnormalTimePeriod(DateTimeOffset? startOn, DateTimeOffset? endOn, string message, string source, double? priority, IList<IList<AppServiceNameValuePair>> metaData, DetectorIssueType? issueType, IList<DiagnosticSolution> solutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            Message = message;
            Source = source;
            Priority = priority;
            MetaData = metaData;
            IssueType = issueType;
            Solutions = solutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Start time of the correlated event. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the correlated event. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Message describing the event. </summary>
        public string Message { get; set; }
        /// <summary> Represents the name of the Detector. </summary>
        public string Source { get; set; }
        /// <summary> Represents the rank of the Detector. </summary>
        public double? Priority { get; set; }
        /// <summary> Downtime metadata. </summary>
        public IList<IList<AppServiceNameValuePair>> MetaData { get; }
        /// <summary> Represents the type of the Detector. </summary>
        public DetectorIssueType? IssueType { get; set; }
        /// <summary> List of proposed solutions. </summary>
        public IList<DiagnosticSolution> Solutions { get; }
    }
}
