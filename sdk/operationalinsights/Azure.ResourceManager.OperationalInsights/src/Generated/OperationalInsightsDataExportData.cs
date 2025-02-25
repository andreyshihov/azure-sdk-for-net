// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the OperationalInsightsDataExport data model.
    /// The top level data export resource container.
    /// </summary>
    public partial class OperationalInsightsDataExportData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsDataExportData"/>. </summary>
        public OperationalInsightsDataExportData()
        {
            TableNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsDataExportData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataExportId"> The data export rule ID. </param>
        /// <param name="tableNames"> An array of tables to export, for example: [“Heartbeat, SecurityEvent”]. </param>
        /// <param name="isEnabled"> Active when enabled. </param>
        /// <param name="createdOn"> The latest data export rule modification time. </param>
        /// <param name="lastModifiedOn"> Date and time when the export was last modified. </param>
        /// <param name="resourceId"> The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure. </param>
        /// <param name="destinationType"> The type of the destination resource. </param>
        /// <param name="eventHubName"> Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsDataExportData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? dataExportId, IList<string> tableNames, bool? isEnabled, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, ResourceIdentifier resourceId, OperationalInsightsDataExportDestinationType? destinationType, string eventHubName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DataExportId = dataExportId;
            TableNames = tableNames;
            IsEnabled = isEnabled;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            ResourceId = resourceId;
            DestinationType = destinationType;
            EventHubName = eventHubName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The data export rule ID. </summary>
        public Guid? DataExportId { get; set; }
        /// <summary> An array of tables to export, for example: [“Heartbeat, SecurityEvent”]. </summary>
        public IList<string> TableNames { get; }
        /// <summary> Active when enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The latest data export rule modification time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Date and time when the export was last modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The type of the destination resource. </summary>
        public OperationalInsightsDataExportDestinationType? DestinationType { get; }
        /// <summary> Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account. </summary>
        public string EventHubName { get; set; }
    }
}
