// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the network interfaces or the networking configuration of the virtual machine. </summary>
    public partial class VirtualMachineNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineNetworkProfile"/>. </summary>
        public VirtualMachineNetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<VirtualMachineNetworkInterfaceReference>();
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineNetworkInterfaceConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Specifies the list of resource Ids for the network interfaces associated with the virtual machine. </param>
        /// <param name="networkApiVersion"> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations. </param>
        /// <param name="networkInterfaceConfigurations"> Specifies the networking configurations that will be used to create the virtual machine networking resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineNetworkProfile(IList<VirtualMachineNetworkInterfaceReference> networkInterfaces, NetworkApiVersion? networkApiVersion, IList<VirtualMachineNetworkInterfaceConfiguration> networkInterfaceConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkInterfaces = networkInterfaces;
            NetworkApiVersion = networkApiVersion;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the virtual machine. </summary>
        public IList<VirtualMachineNetworkInterfaceReference> NetworkInterfaces { get; }
        /// <summary> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations. </summary>
        public NetworkApiVersion? NetworkApiVersion { get; set; }
        /// <summary> Specifies the networking configurations that will be used to create the virtual machine networking resources. </summary>
        public IList<VirtualMachineNetworkInterfaceConfiguration> NetworkInterfaceConfigurations { get; }
    }
}
