// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Synapse spark job reference type. </summary>
    public partial class SynapseSparkJobReference
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

        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobReference"/>. </summary>
        /// <param name="sparkJobReferenceType"> Synapse spark job reference type. </param>
        /// <param name="referenceName"> Reference spark job name. Expression with resultType string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SynapseSparkJobReference(SparkJobReferenceType sparkJobReferenceType, DataFactoryElement<string> referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            SparkJobReferenceType = sparkJobReferenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobReference"/>. </summary>
        /// <param name="sparkJobReferenceType"> Synapse spark job reference type. </param>
        /// <param name="referenceName"> Reference spark job name. Expression with resultType string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSparkJobReference(SparkJobReferenceType sparkJobReferenceType, DataFactoryElement<string> referenceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SparkJobReferenceType = sparkJobReferenceType;
            ReferenceName = referenceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSparkJobReference"/> for deserialization. </summary>
        internal SynapseSparkJobReference()
        {
        }

        /// <summary> Synapse spark job reference type. </summary>
        public SparkJobReferenceType SparkJobReferenceType { get; set; }
        /// <summary> Reference spark job name. Expression with resultType string. </summary>
        public DataFactoryElement<string> ReferenceName { get; set; }
    }
}
