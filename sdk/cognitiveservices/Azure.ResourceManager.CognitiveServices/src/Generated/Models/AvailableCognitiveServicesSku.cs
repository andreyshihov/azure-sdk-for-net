// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Describes an available Cognitive Services SKU. </summary>
    public partial class AvailableCognitiveServicesSku
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

        /// <summary> Initializes a new instance of <see cref="AvailableCognitiveServicesSku"/>. </summary>
        internal AvailableCognitiveServicesSku()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            Restrictions = new ChangeTrackingList<CognitiveServicesSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableCognitiveServicesSku"/>. </summary>
        /// <param name="resourceType"> The type of resource the SKU applies to. </param>
        /// <param name="name"> The name of SKU. </param>
        /// <param name="tier"> Specifies the tier of Cognitive Services account. </param>
        /// <param name="kind"> The Kind of resources that are supported in this SKU. </param>
        /// <param name="locations"> The set of locations that the SKU is available. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableCognitiveServicesSku(string resourceType, string name, string tier, string kind, IReadOnlyList<AzureLocation> locations, IReadOnlyList<CognitiveServicesSkuRestrictions> restrictions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Kind = kind;
            Locations = locations;
            Restrictions = restrictions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of resource the SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> The name of SKU. </summary>
        public string Name { get; }
        /// <summary> Specifies the tier of Cognitive Services account. </summary>
        public string Tier { get; }
        /// <summary> The Kind of resources that are supported in this SKU. </summary>
        public string Kind { get; }
        /// <summary> The set of locations that the SKU is available. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </summary>
        public IReadOnlyList<CognitiveServicesSkuRestrictions> Restrictions { get; }
    }
}
