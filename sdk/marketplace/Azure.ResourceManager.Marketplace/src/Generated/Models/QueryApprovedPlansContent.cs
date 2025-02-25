// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Query approved plans payload. </summary>
    public partial class QueryApprovedPlansContent
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

        /// <summary> Initializes a new instance of <see cref="QueryApprovedPlansContent"/>. </summary>
        public QueryApprovedPlansContent()
        {
            PlanIds = new ChangeTrackingList<string>();
            SubscriptionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryApprovedPlansContent"/>. </summary>
        /// <param name="offerId"> Offer id. </param>
        /// <param name="planIds"> Offer plan ids. </param>
        /// <param name="subscriptionIds"> List of subscription IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryApprovedPlansContent(string offerId, IList<string> planIds, IList<string> subscriptionIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferId = offerId;
            PlanIds = planIds;
            SubscriptionIds = subscriptionIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Offer id. </summary>
        public string OfferId { get; set; }
        /// <summary> Offer plan ids. </summary>
        public IList<string> PlanIds { get; }
        /// <summary> List of subscription IDs. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}
