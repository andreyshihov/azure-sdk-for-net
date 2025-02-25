// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Rules results input. </summary>
    public partial class RulesResultsContent
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

        /// <summary> Initializes a new instance of <see cref="RulesResultsContent"/>. </summary>
        public RulesResultsContent()
        {
            Results = new ChangeTrackingDictionary<string, IList<IList<string>>>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesResultsContent"/>. </summary>
        /// <param name="latestScan"> Take results from latest scan. </param>
        /// <param name="results">
        /// Expected results to be inserted into the baseline.
        /// Leave this field empty it LatestScan == true.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulesResultsContent(bool? latestScan, IDictionary<string, IList<IList<string>>> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LatestScan = latestScan;
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Take results from latest scan. </summary>
        public bool? LatestScan { get; set; }
        /// <summary>
        /// Expected results to be inserted into the baseline.
        /// Leave this field empty it LatestScan == true.
        /// </summary>
        public IDictionary<string, IList<IList<string>>> Results { get; }
    }
}
