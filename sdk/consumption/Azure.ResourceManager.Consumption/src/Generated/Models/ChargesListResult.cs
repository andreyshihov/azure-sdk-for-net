// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Consumption;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Result of listing charge summary. </summary>
    internal partial class ChargesListResult
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

        /// <summary> Initializes a new instance of <see cref="ChargesListResult"/>. </summary>
        internal ChargesListResult()
        {
            Value = new ChangeTrackingList<ConsumptionChargeSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="ChargesListResult"/>. </summary>
        /// <param name="value">
        /// The list of charge summary
        /// Please note <see cref="ConsumptionChargeSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConsumptionLegacyChargeSummary"/> and <see cref="ConsumptionModernChargeSummary"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChargesListResult(IReadOnlyList<ConsumptionChargeSummary> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The list of charge summary
        /// Please note <see cref="ConsumptionChargeSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConsumptionLegacyChargeSummary"/> and <see cref="ConsumptionModernChargeSummary"/>.
        /// </summary>
        public IReadOnlyList<ConsumptionChargeSummary> Value { get; }
    }
}
