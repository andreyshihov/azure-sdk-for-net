// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Subscription list operation response. </summary>
    internal partial class SubscriptionsResponse
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

        /// <summary> Initializes a new instance of <see cref="SubscriptionsResponse"/>. </summary>
        internal SubscriptionsResponse()
        {
            Value = new ChangeTrackingList<MarketplaceSubscription>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionsResponse"/>. </summary>
        /// <param name="value"> An array of subscriptions. </param>
        /// <param name="skipToken"> The skip token to retrieve the next page. </param>
        /// <param name="count"> Number of subscriptions on the page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionsResponse(IReadOnlyList<MarketplaceSubscription> value, string skipToken, long? count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            SkipToken = skipToken;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of subscriptions. </summary>
        public IReadOnlyList<MarketplaceSubscription> Value { get; }
        /// <summary> The skip token to retrieve the next page. </summary>
        public string SkipToken { get; }
        /// <summary> Number of subscriptions on the page. </summary>
        public long? Count { get; }
    }
}
