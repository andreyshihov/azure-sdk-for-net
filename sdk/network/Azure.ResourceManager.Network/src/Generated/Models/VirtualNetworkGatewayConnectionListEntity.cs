// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A common class for general resource information. </summary>
    public partial class VirtualNetworkGatewayConnectionListEntity : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayConnectionListEntity"/>. </summary>
        /// <param name="virtualNetworkGateway1"> The reference to virtual network gateway resource. </param>
        /// <param name="connectionType"> Gateway connection type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGateway1"/> is null. </exception>
        public VirtualNetworkGatewayConnectionListEntity(WritableSubResource virtualNetworkGateway1, VirtualNetworkGatewayConnectionType connectionType)
        {
            Argument.AssertNotNull(virtualNetworkGateway1, nameof(virtualNetworkGateway1));

            VirtualNetworkGateway1 = virtualNetworkGateway1;
            ConnectionType = connectionType;
            TunnelConnectionStatus = new ChangeTrackingList<TunnelConnectionHealth>();
            GatewayCustomBgpIPAddresses = new ChangeTrackingList<GatewayCustomBgpIPAddressIPConfiguration>();
            IPsecPolicies = new ChangeTrackingList<IPsecPolicy>();
            TrafficSelectorPolicies = new ChangeTrackingList<TrafficSelectorPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayConnectionListEntity"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="authorizationKey"> The authorizationKey. </param>
        /// <param name="virtualNetworkGateway1"> The reference to virtual network gateway resource. </param>
        /// <param name="virtualNetworkGateway2"> The reference to virtual network gateway resource. </param>
        /// <param name="localNetworkGateway2"> The reference to local network gateway resource. </param>
        /// <param name="connectionType"> Gateway connection type. </param>
        /// <param name="connectionProtocol"> Connection protocol used for this connection. </param>
        /// <param name="routingWeight"> The routing weight. </param>
        /// <param name="connectionMode"> The connection mode for this connection. </param>
        /// <param name="sharedKey"> The IPSec shared key. </param>
        /// <param name="connectionStatus"> Virtual Network Gateway connection status. </param>
        /// <param name="tunnelConnectionStatus"> Collection of all tunnels' connection health status. </param>
        /// <param name="egressBytesTransferred"> The egress bytes transferred in this connection. </param>
        /// <param name="ingressBytesTransferred"> The ingress bytes transferred in this connection. </param>
        /// <param name="peer"> The reference to peerings resource. </param>
        /// <param name="enableBgp"> EnableBgp flag. </param>
        /// <param name="gatewayCustomBgpIPAddresses"> GatewayCustomBgpIpAddresses to be used for virtual network gateway Connection. </param>
        /// <param name="usePolicyBasedTrafficSelectors"> Enable policy-based traffic selectors. </param>
        /// <param name="ipsecPolicies"> The IPSec Policies to be considered by this connection. </param>
        /// <param name="trafficSelectorPolicies"> The Traffic Selector Policies to be considered by this connection. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network gateway connection resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway connection resource. </param>
        /// <param name="expressRouteGatewayBypass"> Bypass ExpressRoute Gateway for data forwarding. </param>
        /// <param name="enablePrivateLinkFastPath"> Bypass the ExpressRoute gateway when accessing private-links. ExpressRoute FastPath (expressRouteGatewayBypass) must be enabled. </param>
        internal VirtualNetworkGatewayConnectionListEntity(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, string authorizationKey, WritableSubResource virtualNetworkGateway1, WritableSubResource virtualNetworkGateway2, WritableSubResource localNetworkGateway2, VirtualNetworkGatewayConnectionType connectionType, VirtualNetworkGatewayConnectionProtocol? connectionProtocol, int? routingWeight, VirtualNetworkGatewayConnectionMode? connectionMode, string sharedKey, VirtualNetworkGatewayConnectionStatus? connectionStatus, IReadOnlyList<TunnelConnectionHealth> tunnelConnectionStatus, long? egressBytesTransferred, long? ingressBytesTransferred, WritableSubResource peer, bool? enableBgp, IList<GatewayCustomBgpIPAddressIPConfiguration> gatewayCustomBgpIPAddresses, bool? usePolicyBasedTrafficSelectors, IList<IPsecPolicy> ipsecPolicies, IList<TrafficSelectorPolicy> trafficSelectorPolicies, Guid? resourceGuid, NetworkProvisioningState? provisioningState, bool? expressRouteGatewayBypass, bool? enablePrivateLinkFastPath) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            ConnectionProtocol = connectionProtocol;
            RoutingWeight = routingWeight;
            ConnectionMode = connectionMode;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            GatewayCustomBgpIPAddresses = gatewayCustomBgpIPAddresses;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IPsecPolicies = ipsecPolicies;
            TrafficSelectorPolicies = trafficSelectorPolicies;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ExpressRouteGatewayBypass = expressRouteGatewayBypass;
            EnablePrivateLinkFastPath = enablePrivateLinkFastPath;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayConnectionListEntity"/> for deserialization. </summary>
        internal VirtualNetworkGatewayConnectionListEntity()
        {
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The authorizationKey. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The reference to virtual network gateway resource. </summary>
        internal WritableSubResource VirtualNetworkGateway1 { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkGateway1Id
        {
            get => VirtualNetworkGateway1 is null ? default : VirtualNetworkGateway1.Id;
            set
            {
                if (VirtualNetworkGateway1 is null)
                    VirtualNetworkGateway1 = new WritableSubResource();
                VirtualNetworkGateway1.Id = value;
            }
        }

        /// <summary> The reference to virtual network gateway resource. </summary>
        internal WritableSubResource VirtualNetworkGateway2 { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkGateway2Id
        {
            get => VirtualNetworkGateway2 is null ? default : VirtualNetworkGateway2.Id;
            set
            {
                if (VirtualNetworkGateway2 is null)
                    VirtualNetworkGateway2 = new WritableSubResource();
                VirtualNetworkGateway2.Id = value;
            }
        }

        /// <summary> The reference to local network gateway resource. </summary>
        internal WritableSubResource LocalNetworkGateway2 { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier LocalNetworkGateway2Id
        {
            get => LocalNetworkGateway2 is null ? default : LocalNetworkGateway2.Id;
            set
            {
                if (LocalNetworkGateway2 is null)
                    LocalNetworkGateway2 = new WritableSubResource();
                LocalNetworkGateway2.Id = value;
            }
        }

        /// <summary> Gateway connection type. </summary>
        public VirtualNetworkGatewayConnectionType ConnectionType { get; set; }
        /// <summary> Connection protocol used for this connection. </summary>
        public VirtualNetworkGatewayConnectionProtocol? ConnectionProtocol { get; set; }
        /// <summary> The routing weight. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> The connection mode for this connection. </summary>
        public VirtualNetworkGatewayConnectionMode? ConnectionMode { get; set; }
        /// <summary> The IPSec shared key. </summary>
        public string SharedKey { get; set; }
        /// <summary> Virtual Network Gateway connection status. </summary>
        public VirtualNetworkGatewayConnectionStatus? ConnectionStatus { get; }
        /// <summary> Collection of all tunnels' connection health status. </summary>
        public IReadOnlyList<TunnelConnectionHealth> TunnelConnectionStatus { get; }
        /// <summary> The egress bytes transferred in this connection. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> The ingress bytes transferred in this connection. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> The reference to peerings resource. </summary>
        internal WritableSubResource Peer { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerId
        {
            get => Peer is null ? default : Peer.Id;
            set
            {
                if (Peer is null)
                    Peer = new WritableSubResource();
                Peer.Id = value;
            }
        }

        /// <summary> EnableBgp flag. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> GatewayCustomBgpIpAddresses to be used for virtual network gateway Connection. </summary>
        public IList<GatewayCustomBgpIPAddressIPConfiguration> GatewayCustomBgpIPAddresses { get; }
        /// <summary> Enable policy-based traffic selectors. </summary>
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        /// <summary> The IPSec Policies to be considered by this connection. </summary>
        public IList<IPsecPolicy> IPsecPolicies { get; }
        /// <summary> The Traffic Selector Policies to be considered by this connection. </summary>
        public IList<TrafficSelectorPolicy> TrafficSelectorPolicies { get; }
        /// <summary> The resource GUID property of the virtual network gateway connection resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network gateway connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Bypass ExpressRoute Gateway for data forwarding. </summary>
        public bool? ExpressRouteGatewayBypass { get; set; }
        /// <summary> Bypass the ExpressRoute gateway when accessing private-links. ExpressRoute FastPath (expressRouteGatewayBypass) must be enabled. </summary>
        public bool? EnablePrivateLinkFastPath { get; set; }
    }
}
