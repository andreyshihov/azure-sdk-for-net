// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines a managed rule set. </summary>
    public partial class ManagedRuleSet
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

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSet"/>. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetType"/> or <paramref name="ruleSetVersion"/> is null. </exception>
        public ManagedRuleSet(string ruleSetType, string ruleSetVersion)
        {
            Argument.AssertNotNull(ruleSetType, nameof(ruleSetType));
            Argument.AssertNotNull(ruleSetVersion, nameof(ruleSetVersion));

            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            Exclusions = new ChangeTrackingList<ManagedRuleExclusion>();
            RuleGroupOverrides = new ChangeTrackingList<ManagedRuleGroupOverride>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSet"/>. </summary>
        /// <param name="ruleSetType"> Defines the rule set type to use. </param>
        /// <param name="ruleSetVersion"> Defines the version of the rule set to use. </param>
        /// <param name="ruleSetAction"> Defines the rule set action. </param>
        /// <param name="exclusions"> Describes the exclusions that are applied to all rules in the set. </param>
        /// <param name="ruleGroupOverrides"> Defines the rule group overrides to apply to the rule set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleSet(string ruleSetType, string ruleSetVersion, ManagedRuleSetActionType? ruleSetAction, IList<ManagedRuleExclusion> exclusions, IList<ManagedRuleGroupOverride> ruleGroupOverrides, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleSetAction = ruleSetAction;
            Exclusions = exclusions;
            RuleGroupOverrides = ruleGroupOverrides;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSet"/> for deserialization. </summary>
        internal ManagedRuleSet()
        {
        }

        /// <summary> Defines the rule set type to use. </summary>
        public string RuleSetType { get; set; }
        /// <summary> Defines the version of the rule set to use. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> Defines the rule set action. </summary>
        public ManagedRuleSetActionType? RuleSetAction { get; set; }
        /// <summary> Describes the exclusions that are applied to all rules in the set. </summary>
        public IList<ManagedRuleExclusion> Exclusions { get; }
        /// <summary> Defines the rule group overrides to apply to the rule set. </summary>
        public IList<ManagedRuleGroupOverride> RuleGroupOverrides { get; }
    }
}
