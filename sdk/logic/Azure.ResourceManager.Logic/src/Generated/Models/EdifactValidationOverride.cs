// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact validation override settings. </summary>
    public partial class EdifactValidationOverride
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

        /// <summary> Initializes a new instance of <see cref="EdifactValidationOverride"/>. </summary>
        /// <param name="messageId"> The message id on which the validation settings has to be applied. </param>
        /// <param name="enforceCharacterSet"> The value indicating whether to validate character Set. </param>
        /// <param name="validateEdiTypes"> The value indicating whether to validate EDI types. </param>
        /// <param name="validateXsdTypes"> The value indicating whether to validate XSD types. </param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to allow leading and trailing spaces and zeroes. </param>
        /// <param name="trailingSeparatorPolicy"> The trailing separator policy. </param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to trim leading and trailing spaces and zeroes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        public EdifactValidationOverride(string messageId, bool enforceCharacterSet, bool validateEdiTypes, bool validateXsdTypes, bool allowLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy, bool trimLeadingAndTrailingSpacesAndZeroes)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));

            MessageId = messageId;
            EnforceCharacterSet = enforceCharacterSet;
            ValidateEdiTypes = validateEdiTypes;
            ValidateXsdTypes = validateXsdTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactValidationOverride"/>. </summary>
        /// <param name="messageId"> The message id on which the validation settings has to be applied. </param>
        /// <param name="enforceCharacterSet"> The value indicating whether to validate character Set. </param>
        /// <param name="validateEdiTypes"> The value indicating whether to validate EDI types. </param>
        /// <param name="validateXsdTypes"> The value indicating whether to validate XSD types. </param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to allow leading and trailing spaces and zeroes. </param>
        /// <param name="trailingSeparatorPolicy"> The trailing separator policy. </param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to trim leading and trailing spaces and zeroes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdifactValidationOverride(string messageId, bool enforceCharacterSet, bool validateEdiTypes, bool validateXsdTypes, bool allowLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy, bool trimLeadingAndTrailingSpacesAndZeroes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            EnforceCharacterSet = enforceCharacterSet;
            ValidateEdiTypes = validateEdiTypes;
            ValidateXsdTypes = validateXsdTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactValidationOverride"/> for deserialization. </summary>
        internal EdifactValidationOverride()
        {
        }

        /// <summary> The message id on which the validation settings has to be applied. </summary>
        public string MessageId { get; set; }
        /// <summary> The value indicating whether to validate character Set. </summary>
        public bool EnforceCharacterSet { get; set; }
        /// <summary> The value indicating whether to validate EDI types. </summary>
        public bool ValidateEdiTypes { get; set; }
        /// <summary> The value indicating whether to validate XSD types. </summary>
        public bool ValidateXsdTypes { get; set; }
        /// <summary> The value indicating whether to allow leading and trailing spaces and zeroes. </summary>
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        /// <summary> The trailing separator policy. </summary>
        public TrailingSeparatorPolicy TrailingSeparatorPolicy { get; set; }
        /// <summary> The value indicating whether to trim leading and trailing spaces and zeroes. </summary>
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
    }
}
