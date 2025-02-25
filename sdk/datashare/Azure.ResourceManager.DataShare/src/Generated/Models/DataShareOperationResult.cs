// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Response for long running operation. </summary>
    public partial class DataShareOperationResult
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

        /// <summary> Initializes a new instance of <see cref="DataShareOperationResult"/>. </summary>
        /// <param name="status"> Operation state of the long running operation. </param>
        internal DataShareOperationResult(DataShareOperationStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="DataShareOperationResult"/>. </summary>
        /// <param name="endOn"> start time. </param>
        /// <param name="error"> The error property when status is failed. </param>
        /// <param name="startOn"> start time. </param>
        /// <param name="status"> Operation state of the long running operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataShareOperationResult(DateTimeOffset? endOn, ResponseError error, DateTimeOffset? startOn, DataShareOperationStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndOn = endOn;
            Error = error;
            StartOn = startOn;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataShareOperationResult"/> for deserialization. </summary>
        internal DataShareOperationResult()
        {
        }

        /// <summary> start time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The error property when status is failed. </summary>
        public ResponseError Error { get; }
        /// <summary> start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Operation state of the long running operation. </summary>
        public DataShareOperationStatus Status { get; }
    }
}
