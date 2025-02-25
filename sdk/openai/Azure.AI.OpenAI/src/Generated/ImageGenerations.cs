// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary> The result of a successful image generation operation. </summary>
    public partial class ImageGenerations
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

        /// <summary> Initializes a new instance of <see cref="ImageGenerations"/>. </summary>
        /// <param name="created">
        /// A timestamp representing when this operation was started.
        /// Expressed in seconds since the Unix epoch of 1970-01-01T00:00:00+0000.
        /// </param>
        /// <param name="data"> The images generated by the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public ImageGenerations(DateTimeOffset created, IEnumerable<ImageGenerationData> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Created = created;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerations"/>. </summary>
        /// <param name="created">
        /// A timestamp representing when this operation was started.
        /// Expressed in seconds since the Unix epoch of 1970-01-01T00:00:00+0000.
        /// </param>
        /// <param name="data"> The images generated by the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageGenerations(DateTimeOffset created, IList<ImageGenerationData> data, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Created = created;
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerations"/> for deserialization. </summary>
        internal ImageGenerations()
        {
        }

        /// <summary>
        /// A timestamp representing when this operation was started.
        /// Expressed in seconds since the Unix epoch of 1970-01-01T00:00:00+0000.
        /// </summary>
        public DateTimeOffset Created { get; set; }
        /// <summary> The images generated by the operation. </summary>
        public IList<ImageGenerationData> Data { get; }
    }
}
