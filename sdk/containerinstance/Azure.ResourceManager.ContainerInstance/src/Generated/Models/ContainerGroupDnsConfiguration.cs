// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ContainerInstance;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> DNS configuration for the container group. </summary>
    public partial class ContainerGroupDnsConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ContainerGroupDnsConfiguration"/>. </summary>
        /// <param name="nameServers"> The DNS servers for the container group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nameServers"/> is null. </exception>
        public ContainerGroupDnsConfiguration(IEnumerable<string> nameServers)
        {
            Argument.AssertNotNull(nameServers, nameof(nameServers));

            NameServers = nameServers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupDnsConfiguration"/>. </summary>
        /// <param name="nameServers"> The DNS servers for the container group. </param>
        /// <param name="searchDomains"> The DNS search domains for hostname lookup in the container group. </param>
        /// <param name="options"> The DNS options for the container group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupDnsConfiguration(IList<string> nameServers, string searchDomains, string options, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NameServers = nameServers;
            SearchDomains = searchDomains;
            Options = options;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupDnsConfiguration"/> for deserialization. </summary>
        internal ContainerGroupDnsConfiguration()
        {
        }

        /// <summary> The DNS servers for the container group. </summary>
        public IList<string> NameServers { get; }
        /// <summary> The DNS search domains for hostname lookup in the container group. </summary>
        public string SearchDomains { get; set; }
        /// <summary> The DNS options for the container group. </summary>
        public string Options { get; set; }
    }
}
