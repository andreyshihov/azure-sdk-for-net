// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> BGP settings details. </summary>
    public partial class BgpSettings
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

        /// <summary> Initializes a new instance of <see cref="BgpSettings"/>. </summary>
        public BgpSettings()
        {
            BgpPeeringAddresses = new ChangeTrackingList<NetworkIPConfigurationBgpPeeringAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpSettings"/>. </summary>
        /// <param name="asn"> The BGP speaker's ASN. </param>
        /// <param name="bgpPeeringAddress"> The BGP peering address and BGP identifier of this BGP speaker. </param>
        /// <param name="peerWeight"> The weight added to routes learned from this BGP speaker. </param>
        /// <param name="bgpPeeringAddresses"> BGP peering address with IP configuration ID for virtual network gateway. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BgpSettings(long? asn, string bgpPeeringAddress, int? peerWeight, IList<NetworkIPConfigurationBgpPeeringAddress> bgpPeeringAddresses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
            PeerWeight = peerWeight;
            BgpPeeringAddresses = bgpPeeringAddresses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The BGP speaker's ASN. </summary>
        public long? Asn { get; set; }
        /// <summary> The BGP peering address and BGP identifier of this BGP speaker. </summary>
        public string BgpPeeringAddress { get; set; }
        /// <summary> The weight added to routes learned from this BGP speaker. </summary>
        public int? PeerWeight { get; set; }
        /// <summary> BGP peering address with IP configuration ID for virtual network gateway. </summary>
        public IList<NetworkIPConfigurationBgpPeeringAddress> BgpPeeringAddresses { get; }
    }
}
