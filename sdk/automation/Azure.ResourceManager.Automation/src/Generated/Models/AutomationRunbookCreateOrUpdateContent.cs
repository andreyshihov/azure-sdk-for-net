// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update runbook operation. </summary>
    public partial class AutomationRunbookCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookCreateOrUpdateContent"/>. </summary>
        /// <param name="runbookType"> Gets or sets the type of the runbook. </param>
        public AutomationRunbookCreateOrUpdateContent(AutomationRunbookType runbookType)
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            RunbookType = runbookType;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the resource. </param>
        /// <param name="location"> Gets or sets the location of the resource. </param>
        /// <param name="tags"> Gets or sets the tags attached to the resource. </param>
        /// <param name="isLogVerboseEnabled"> Gets or sets verbose log option. </param>
        /// <param name="isLogProgressEnabled"> Gets or sets progress log option. </param>
        /// <param name="runbookType"> Gets or sets the type of the runbook. </param>
        /// <param name="draft"> Gets or sets the draft runbook properties. </param>
        /// <param name="publishContentLink"> Gets or sets the published runbook content link. </param>
        /// <param name="description"> Gets or sets the description of the runbook. </param>
        /// <param name="logActivityTrace"> Gets or sets the activity-level tracing options of the runbook. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationRunbookCreateOrUpdateContent(string name, AzureLocation? location, IDictionary<string, string> tags, bool? isLogVerboseEnabled, bool? isLogProgressEnabled, AutomationRunbookType runbookType, AutomationRunbookDraft draft, AutomationContentLink publishContentLink, string description, int? logActivityTrace, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Location = location;
            Tags = tags;
            IsLogVerboseEnabled = isLogVerboseEnabled;
            IsLogProgressEnabled = isLogProgressEnabled;
            RunbookType = runbookType;
            Draft = draft;
            PublishContentLink = publishContentLink;
            Description = description;
            LogActivityTrace = logActivityTrace;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationRunbookCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets verbose log option. </summary>
        public bool? IsLogVerboseEnabled { get; set; }
        /// <summary> Gets or sets progress log option. </summary>
        public bool? IsLogProgressEnabled { get; set; }
        /// <summary> Gets or sets the type of the runbook. </summary>
        public AutomationRunbookType RunbookType { get; }
        /// <summary> Gets or sets the draft runbook properties. </summary>
        public AutomationRunbookDraft Draft { get; set; }
        /// <summary> Gets or sets the published runbook content link. </summary>
        public AutomationContentLink PublishContentLink { get; set; }
        /// <summary> Gets or sets the description of the runbook. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the activity-level tracing options of the runbook. </summary>
        public int? LogActivityTrace { get; set; }
    }
}
