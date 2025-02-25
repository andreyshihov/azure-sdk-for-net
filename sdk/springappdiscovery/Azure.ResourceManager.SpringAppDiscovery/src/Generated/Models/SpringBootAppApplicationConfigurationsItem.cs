// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SpringAppDiscovery;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary>
    /// The SpringBootAppApplicationConfigurationsItem.
    /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem
    /// </summary>
    public partial class SpringBootAppApplicationConfigurationsItem
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

        /// <summary> Initializes a new instance of <see cref="SpringBootAppApplicationConfigurationsItem"/>. </summary>
        /// <param name="key">
        /// The application config file name.
        /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem.key
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public SpringBootAppApplicationConfigurationsItem(string key)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
        }

        /// <summary> Initializes a new instance of <see cref="SpringBootAppApplicationConfigurationsItem"/>. </summary>
        /// <param name="key">
        /// The application config file name.
        /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem.key
        /// </param>
        /// <param name="value">
        /// The application config file content, only contains config keys.
        /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem.value
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpringBootAppApplicationConfigurationsItem(string key, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SpringBootAppApplicationConfigurationsItem"/> for deserialization. </summary>
        internal SpringBootAppApplicationConfigurationsItem()
        {
        }

        /// <summary>
        /// The application config file name.
        /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem.key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The application config file content, only contains config keys.
        /// Serialized Name: SpringbootappsPropertiesApplicationConfigurationsItem.value
        /// </summary>
        public string Value { get; set; }
    }
}
