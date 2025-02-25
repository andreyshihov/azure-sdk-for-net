// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Trigger runs. </summary>
    public partial class DataFactoryTriggerRun
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerRun"/>. </summary>
        internal DataFactoryTriggerRun()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            TriggeredPipelines = new ChangeTrackingDictionary<string, string>();
            RunDimension = new ChangeTrackingDictionary<string, string>();
            DependencyStatus = new ChangeTrackingDictionary<string, BinaryData>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerRun"/>. </summary>
        /// <param name="triggerRunId"> Trigger run id. </param>
        /// <param name="triggerName"> Trigger name. </param>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="triggerRunTimestamp"> Trigger run start time. </param>
        /// <param name="status"> Trigger run status. </param>
        /// <param name="message"> Trigger error message. </param>
        /// <param name="properties"> List of property name and value related to trigger run. Name, value pair depends on type of trigger. </param>
        /// <param name="triggeredPipelines"> List of pipeline name and run Id triggered by the trigger run. </param>
        /// <param name="runDimension"> Run dimension for which trigger was fired. </param>
        /// <param name="dependencyStatus"> Status of the upstream pipelines. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryTriggerRun(string triggerRunId, string triggerName, string triggerType, DateTimeOffset? triggerRunTimestamp, DataFactoryTriggerRunStatus? status, string message, IReadOnlyDictionary<string, string> properties, IReadOnlyDictionary<string, string> triggeredPipelines, IReadOnlyDictionary<string, string> runDimension, IReadOnlyDictionary<string, BinaryData> dependencyStatus, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            TriggerRunId = triggerRunId;
            TriggerName = triggerName;
            TriggerType = triggerType;
            TriggerRunTimestamp = triggerRunTimestamp;
            Status = status;
            Message = message;
            Properties = properties;
            TriggeredPipelines = triggeredPipelines;
            RunDimension = runDimension;
            DependencyStatus = dependencyStatus;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Trigger run id. </summary>
        public string TriggerRunId { get; }
        /// <summary> Trigger name. </summary>
        public string TriggerName { get; }
        /// <summary> Trigger type. </summary>
        public string TriggerType { get; }
        /// <summary> Trigger run start time. </summary>
        public DateTimeOffset? TriggerRunTimestamp { get; }
        /// <summary> Trigger run status. </summary>
        public DataFactoryTriggerRunStatus? Status { get; }
        /// <summary> Trigger error message. </summary>
        public string Message { get; }
        /// <summary> List of property name and value related to trigger run. Name, value pair depends on type of trigger. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
        /// <summary> List of pipeline name and run Id triggered by the trigger run. </summary>
        public IReadOnlyDictionary<string, string> TriggeredPipelines { get; }
        /// <summary> Run dimension for which trigger was fired. </summary>
        public IReadOnlyDictionary<string, string> RunDimension { get; }
        /// <summary>
        /// Status of the upstream pipelines.
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
        public IReadOnlyDictionary<string, BinaryData> DependencyStatus { get; }
        /// <summary>
        /// Additional Properties
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
