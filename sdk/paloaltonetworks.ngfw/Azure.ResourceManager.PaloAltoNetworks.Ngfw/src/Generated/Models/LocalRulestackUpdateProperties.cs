// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The updatable properties of the LocalRulestackResource. </summary>
    public partial class LocalRulestackUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="LocalRulestackUpdateProperties"/>. </summary>
        public LocalRulestackUpdateProperties()
        {
            AssociatedSubscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackUpdateProperties"/>. </summary>
        /// <param name="panETag"> PanEtag info. </param>
        /// <param name="panLocation"> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </param>
        /// <param name="scope"> Rulestack Type. </param>
        /// <param name="associatedSubscriptions"> subscription scope of global rulestack. </param>
        /// <param name="description"> rulestack description. </param>
        /// <param name="defaultMode"> Mode for default rules creation. </param>
        /// <param name="minAppIdVersion"> minimum version. </param>
        /// <param name="securityServices"> Security Profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LocalRulestackUpdateProperties(ETag? panETag, AzureLocation? panLocation, RulestackScopeType? scope, IList<string> associatedSubscriptions, string description, RuleCreationDefaultMode? defaultMode, string minAppIdVersion, RulestackSecurityServices securityServices, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PanETag = panETag;
            PanLocation = panLocation;
            Scope = scope;
            AssociatedSubscriptions = associatedSubscriptions;
            Description = description;
            DefaultMode = defaultMode;
            MinAppIdVersion = minAppIdVersion;
            SecurityServices = securityServices;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> PanEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </summary>
        public AzureLocation? PanLocation { get; set; }
        /// <summary> Rulestack Type. </summary>
        public RulestackScopeType? Scope { get; set; }
        /// <summary> subscription scope of global rulestack. </summary>
        public IList<string> AssociatedSubscriptions { get; }
        /// <summary> rulestack description. </summary>
        public string Description { get; set; }
        /// <summary> Mode for default rules creation. </summary>
        public RuleCreationDefaultMode? DefaultMode { get; set; }
        /// <summary> minimum version. </summary>
        public string MinAppIdVersion { get; set; }
        /// <summary> Security Profile. </summary>
        public RulestackSecurityServices SecurityServices { get; set; }
    }
}
