// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define a ProactiveDetection configuration. </summary>
    public partial class ApplicationInsightsComponentProactiveDetectionConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentProactiveDetectionConfiguration"/>. </summary>
        public ApplicationInsightsComponentProactiveDetectionConfiguration()
        {
            CustomEmails = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentProactiveDetectionConfiguration"/>. </summary>
        /// <param name="name"> The rule name. </param>
        /// <param name="isEnabled"> A flag that indicates whether this rule is enabled by the user. </param>
        /// <param name="sendEmailsToSubscriptionOwners"> A flag that indicated whether notifications on this rule should be sent to subscription owners. </param>
        /// <param name="customEmails"> Custom email addresses for this rule notifications. </param>
        /// <param name="lastUpdatedTime"> The last time this rule was updated. </param>
        /// <param name="ruleDefinitions"> Static definitions of the ProactiveDetection configuration rule (same values for all components). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentProactiveDetectionConfiguration(string name, bool? isEnabled, bool? sendEmailsToSubscriptionOwners, IList<string> customEmails, string lastUpdatedTime, ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions ruleDefinitions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IsEnabled = isEnabled;
            SendEmailsToSubscriptionOwners = sendEmailsToSubscriptionOwners;
            CustomEmails = customEmails;
            LastUpdatedTime = lastUpdatedTime;
            RuleDefinitions = ruleDefinitions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The rule name. </summary>
        public string Name { get; set; }
        /// <summary> A flag that indicates whether this rule is enabled by the user. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> A flag that indicated whether notifications on this rule should be sent to subscription owners. </summary>
        public bool? SendEmailsToSubscriptionOwners { get; set; }
        /// <summary> Custom email addresses for this rule notifications. </summary>
        public IList<string> CustomEmails { get; }
        /// <summary> The last time this rule was updated. </summary>
        public string LastUpdatedTime { get; set; }
        /// <summary> Static definitions of the ProactiveDetection configuration rule (same values for all components). </summary>
        public ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions RuleDefinitions { get; set; }
    }
}
