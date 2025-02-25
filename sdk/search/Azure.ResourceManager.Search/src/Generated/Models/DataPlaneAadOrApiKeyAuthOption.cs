// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Indicates that either the API key or an access token from Azure Active Directory can be used for authentication. </summary>
    internal partial class DataPlaneAadOrApiKeyAuthOption
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

        /// <summary> Initializes a new instance of <see cref="DataPlaneAadOrApiKeyAuthOption"/>. </summary>
        public DataPlaneAadOrApiKeyAuthOption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataPlaneAadOrApiKeyAuthOption"/>. </summary>
        /// <param name="aadAuthFailureMode"> Describes what response the data plane API of a Search service would send for requests that failed authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataPlaneAadOrApiKeyAuthOption(SearchAadAuthFailureMode? aadAuthFailureMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AadAuthFailureMode = aadAuthFailureMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes what response the data plane API of a Search service would send for requests that failed authentication. </summary>
        public SearchAadAuthFailureMode? AadAuthFailureMode { get; set; }
    }
}
