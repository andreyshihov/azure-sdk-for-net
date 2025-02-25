// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The query compilation object which defines the input, output, and transformation for the query compilation. </summary>
    public partial class StreamAnalyticsCompileQuery
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

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/>. </summary>
        /// <param name="query"> The query to compile. </param>
        /// <param name="jobType"> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public StreamAnalyticsCompileQuery(string query, StreamingJobType jobType)
        {
            Argument.AssertNotNull(query, nameof(query));

            Query = query;
            Inputs = new ChangeTrackingList<StreamAnalyticsQueryInput>();
            Functions = new ChangeTrackingList<StreamAnalyticsQueryFunction>();
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/>. </summary>
        /// <param name="query"> The query to compile. </param>
        /// <param name="inputs"> The inputs for the query compilation. </param>
        /// <param name="functions"> The functions for the query compilation. </param>
        /// <param name="jobType"> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </param>
        /// <param name="compatibilityLevel"> The query to compile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsCompileQuery(string query, IList<StreamAnalyticsQueryInput> inputs, IList<StreamAnalyticsQueryFunction> functions, StreamingJobType jobType, StreamingJobCompatibilityLevel? compatibilityLevel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Query = query;
            Inputs = inputs;
            Functions = functions;
            JobType = jobType;
            CompatibilityLevel = compatibilityLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/> for deserialization. </summary>
        internal StreamAnalyticsCompileQuery()
        {
        }

        /// <summary> The query to compile. </summary>
        public string Query { get; }
        /// <summary> The inputs for the query compilation. </summary>
        public IList<StreamAnalyticsQueryInput> Inputs { get; }
        /// <summary> The functions for the query compilation. </summary>
        public IList<StreamAnalyticsQueryFunction> Functions { get; }
        /// <summary> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </summary>
        public StreamingJobType JobType { get; }
        /// <summary> The query to compile. </summary>
        public StreamingJobCompatibilityLevel? CompatibilityLevel { get; set; }
    }
}
