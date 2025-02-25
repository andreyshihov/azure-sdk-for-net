// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Deployment slot parameters. </summary>
    public partial class CsmSlotEntity
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

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/>. </summary>
        /// <param name="targetSlot"> Destination deployment slot during swap operation. </param>
        /// <param name="preserveVnet"> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetSlot"/> is null. </exception>
        public CsmSlotEntity(string targetSlot, bool preserveVnet)
        {
            Argument.AssertNotNull(targetSlot, nameof(targetSlot));

            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
        }

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/>. </summary>
        /// <param name="targetSlot"> Destination deployment slot during swap operation. </param>
        /// <param name="preserveVnet"> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CsmSlotEntity(string targetSlot, bool preserveVnet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/> for deserialization. </summary>
        internal CsmSlotEntity()
        {
        }

        /// <summary> Destination deployment slot during swap operation. </summary>
        public string TargetSlot { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool PreserveVnet { get; }
    }
}
