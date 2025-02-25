// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Data regarding 3rd party partner integration. </summary>
    public partial class SecurityAssessmentPartner
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

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentPartner"/>. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="secret"> secret to authenticate the partner - write only. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="secret"/> is null. </exception>
        public SecurityAssessmentPartner(string partnerName, string secret)
        {
            Argument.AssertNotNull(partnerName, nameof(partnerName));
            Argument.AssertNotNull(secret, nameof(secret));

            PartnerName = partnerName;
            Secret = secret;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentPartner"/>. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="secret"> secret to authenticate the partner - write only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAssessmentPartner(string partnerName, string secret, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PartnerName = partnerName;
            Secret = secret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentPartner"/> for deserialization. </summary>
        internal SecurityAssessmentPartner()
        {
        }

        /// <summary> Name of the company of the partner. </summary>
        public string PartnerName { get; set; }
        /// <summary> secret to authenticate the partner - write only. </summary>
        public string Secret { get; set; }
    }
}
