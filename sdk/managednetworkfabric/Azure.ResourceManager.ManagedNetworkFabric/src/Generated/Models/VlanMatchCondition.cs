// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The vlan match conditions that need to be matched. </summary>
    public partial class VlanMatchCondition
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

        /// <summary> Initializes a new instance of <see cref="VlanMatchCondition"/>. </summary>
        public VlanMatchCondition()
        {
            Vlans = new ChangeTrackingList<string>();
            InnerVlans = new ChangeTrackingList<string>();
            VlanGroupNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VlanMatchCondition"/>. </summary>
        /// <param name="vlans"> List of vlans that need to be matched. </param>
        /// <param name="innerVlans"> List of inner vlans that need to be matched. </param>
        /// <param name="vlanGroupNames"> List of vlan group names that need to be matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VlanMatchCondition(IList<string> vlans, IList<string> innerVlans, IList<string> vlanGroupNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Vlans = vlans;
            InnerVlans = innerVlans;
            VlanGroupNames = vlanGroupNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of vlans that need to be matched. </summary>
        public IList<string> Vlans { get; }
        /// <summary> List of inner vlans that need to be matched. </summary>
        public IList<string> InnerVlans { get; }
        /// <summary> List of vlan group names that need to be matched. </summary>
        public IList<string> VlanGroupNames { get; }
    }
}
