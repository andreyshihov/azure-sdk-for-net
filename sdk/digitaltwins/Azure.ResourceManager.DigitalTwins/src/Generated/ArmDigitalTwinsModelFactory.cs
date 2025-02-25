// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDigitalTwinsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="DigitalTwins.DigitalTwinsDescriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="createdOn"> Time when DigitalTwinsInstance was created. </param>
        /// <param name="lastUpdatedOn"> Time when DigitalTwinsInstance was updated. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="hostName"> Api endpoint to work with DigitalTwinsInstance. </param>
        /// <param name="privateEndpointConnections"> The private endpoint connections. </param>
        /// <param name="publicNetworkAccess"> Public network access for the DigitalTwinsInstance. </param>
        /// <param name="identity"> The managed identity for the DigitalTwinsInstance. </param>
        /// <returns> A new <see cref="DigitalTwins.DigitalTwinsDescriptionData"/> instance for mocking. </returns>
        public static DigitalTwinsDescriptionData DigitalTwinsDescriptionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, DateTimeOffset? createdOn = null, DateTimeOffset? lastUpdatedOn = null, DigitalTwinsProvisioningState? provisioningState = null, string hostName = null, IEnumerable<DigitalTwinsPrivateEndpointConnectionData> privateEndpointConnections = null, DigitalTwinsPublicNetworkAccess? publicNetworkAccess = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<DigitalTwinsPrivateEndpointConnectionData>();

            return new DigitalTwinsDescriptionData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                createdOn,
                lastUpdatedOn,
                provisioningState,
                hostName,
                privateEndpointConnections?.ToList(),
                publicNetworkAccess,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwins.DigitalTwinsPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The connection properties. </param>
        /// <returns> A new <see cref="DigitalTwins.DigitalTwinsPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static DigitalTwinsPrivateEndpointConnectionData DigitalTwinsPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DigitalTwinsPrivateEndpointConnectionProperties properties = null)
        {
            return new DigitalTwinsPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="privateEndpointId"> The private endpoint. </param>
        /// <param name="groupIds"> The list of group ids for the private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The connection state. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsPrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static DigitalTwinsPrivateEndpointConnectionProperties DigitalTwinsPrivateEndpointConnectionProperties(DigitalTwinsPrivateLinkResourceProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, DigitalTwinsPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null)
        {
            groupIds ??= new List<string>();

            return new DigitalTwinsPrivateEndpointConnectionProperties(provisioningState, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, groupIds?.ToList(), privateLinkServiceConnectionState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwins.DigitalTwinsEndpointResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// DigitalTwinsInstance endpoint resource properties.
        /// Please note <see cref="Models.DigitalTwinsEndpointResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DigitalTwinsEventGridProperties"/>, <see cref="Models.DigitalTwinsEventHubProperties"/> and <see cref="Models.DigitalTwinsServiceBusProperties"/>.
        /// </param>
        /// <returns> A new <see cref="DigitalTwins.DigitalTwinsEndpointResourceData"/> instance for mocking. </returns>
        public static DigitalTwinsEndpointResourceData DigitalTwinsEndpointResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DigitalTwinsEndpointResourceProperties properties = null)
        {
            return new DigitalTwinsEndpointResourceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsEndpointResourceProperties"/>. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsEndpointResourceProperties"/> instance for mocking. </returns>
        public static DigitalTwinsEndpointResourceProperties DigitalTwinsEndpointResourceProperties(string endpointType = "Unknown", DigitalTwinsEndpointProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, DigitalTwinsAuthenticationType? authenticationType = null, string deadLetterSecret = null, Uri deadLetterUri = null, DigitalTwinsManagedIdentityReference identity = null)
        {
            return new UnknownDigitalTwinsEndpointResourceProperties(
                endpointType,
                provisioningState,
                createdOn,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsNameContent"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsNameContent"/> instance for mocking. </returns>
        public static DigitalTwinsNameContent DigitalTwinsNameContent(string name = null, DigitalTwinsResourceType resourceType = default)
        {
            return new DigitalTwinsNameContent(name, resourceType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsNameResult"/>. </summary>
        /// <param name="isNameAvailable"> Specifies a Boolean value that indicates if the name is available. </param>
        /// <param name="message"> Message indicating an unavailable name due to a conflict, or a description of the naming rules that are violated. </param>
        /// <param name="reason"> Message providing the reason why the given name is invalid. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsNameResult"/> instance for mocking. </returns>
        public static DigitalTwinsNameResult DigitalTwinsNameResult(bool? isNameAvailable = null, string message = null, DigitalTwinsNameUnavailableReason? reason = null)
        {
            return new DigitalTwinsNameResult(isNameAvailable, message, reason, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwins.DigitalTwinsPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The group information properties. </param>
        /// <returns> A new <see cref="DigitalTwins.DigitalTwinsPrivateLinkResourceData"/> instance for mocking. </returns>
        public static DigitalTwinsPrivateLinkResourceData DigitalTwinsPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DigitalTwinsPrivateLinkResourceProperties properties = null)
        {
            return new DigitalTwinsPrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The group id. </param>
        /// <param name="requiredMembers"> The required members for a specific group id. </param>
        /// <param name="requiredZoneNames"> The required DNS zones for a specific group id. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static DigitalTwinsPrivateLinkResourceProperties DigitalTwinsPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new DigitalTwinsPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwins.TimeSeriesDatabaseConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of a specific time series database connection.
        /// Please note <see cref="Models.TimeSeriesDatabaseConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DataExplorerConnectionProperties"/>.
        /// </param>
        /// <returns> A new <see cref="DigitalTwins.TimeSeriesDatabaseConnectionData"/> instance for mocking. </returns>
        public static TimeSeriesDatabaseConnectionData TimeSeriesDatabaseConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, TimeSeriesDatabaseConnectionProperties properties = null)
        {
            return new TimeSeriesDatabaseConnectionData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TimeSeriesDatabaseConnectionProperties"/>. </summary>
        /// <param name="connectionType"> The type of time series connection resource. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="identity"> Managed identity properties for the time series database connection resource. </param>
        /// <returns> A new <see cref="Models.TimeSeriesDatabaseConnectionProperties"/> instance for mocking. </returns>
        public static TimeSeriesDatabaseConnectionProperties TimeSeriesDatabaseConnectionProperties(string connectionType = "Unknown", TimeSeriesDatabaseConnectionState? provisioningState = null, DigitalTwinsManagedIdentityReference identity = null)
        {
            return new UnknownTimeSeriesDatabaseConnectionProperties(connectionType, provisioningState, identity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsServiceBusProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="endpointUri"> The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'. </param>
        /// <param name="entityPath"> The ServiceBus Topic name for identity-based authentication. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsServiceBusProperties"/> instance for mocking. </returns>
        public static DigitalTwinsServiceBusProperties DigitalTwinsServiceBusProperties(DigitalTwinsEndpointProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, DigitalTwinsAuthenticationType? authenticationType = null, string deadLetterSecret = null, Uri deadLetterUri = null, DigitalTwinsManagedIdentityReference identity = null, string primaryConnectionString = null, string secondaryConnectionString = null, Uri endpointUri = null, string entityPath = null)
        {
            return new DigitalTwinsServiceBusProperties(
                EndpointType.ServiceBus,
                provisioningState,
                createdOn,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData: null,
                primaryConnectionString,
                secondaryConnectionString,
                endpointUri,
                entityPath);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsEventHubProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        /// <param name="connectionStringPrimaryKey"> PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="connectionStringSecondaryKey"> SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="endpointUri"> The URL of the EventHub namespace for identity-based authentication. It must include the protocol 'sb://'. </param>
        /// <param name="entityPath"> The EventHub name in the EventHub namespace for identity-based authentication. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsEventHubProperties"/> instance for mocking. </returns>
        public static DigitalTwinsEventHubProperties DigitalTwinsEventHubProperties(DigitalTwinsEndpointProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, DigitalTwinsAuthenticationType? authenticationType = null, string deadLetterSecret = null, Uri deadLetterUri = null, DigitalTwinsManagedIdentityReference identity = null, string connectionStringPrimaryKey = null, string connectionStringSecondaryKey = null, Uri endpointUri = null, string entityPath = null)
        {
            return new DigitalTwinsEventHubProperties(
                EndpointType.EventHub,
                provisioningState,
                createdOn,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData: null,
                connectionStringPrimaryKey,
                connectionStringSecondaryKey,
                endpointUri,
                entityPath);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DigitalTwinsEventGridProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        /// <param name="topicEndpoint"> EventGrid Topic Endpoint. </param>
        /// <param name="accessKey1"> EventGrid secondary accesskey. Will be obfuscated during read. </param>
        /// <param name="accessKey2"> EventGrid secondary accesskey. Will be obfuscated during read. </param>
        /// <returns> A new <see cref="Models.DigitalTwinsEventGridProperties"/> instance for mocking. </returns>
        public static DigitalTwinsEventGridProperties DigitalTwinsEventGridProperties(DigitalTwinsEndpointProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, DigitalTwinsAuthenticationType? authenticationType = null, string deadLetterSecret = null, Uri deadLetterUri = null, DigitalTwinsManagedIdentityReference identity = null, string topicEndpoint = null, string accessKey1 = null, string accessKey2 = null)
        {
            return new DigitalTwinsEventGridProperties(
                EndpointType.EventGrid,
                provisioningState,
                createdOn,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData: null,
                topicEndpoint,
                accessKey1,
                accessKey2);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataExplorerConnectionProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="identity"> Managed identity properties for the time series database connection resource. </param>
        /// <param name="adxResourceId"> The resource ID of the Azure Data Explorer cluster. </param>
        /// <param name="adxEndpointUri"> The URI of the Azure Data Explorer endpoint. </param>
        /// <param name="adxDatabaseName"> The name of the Azure Data Explorer database. </param>
        /// <param name="adxTableName"> The name of the Azure Data Explorer table used for storing updates to properties of twins and relationships. Defaults to AdtPropertyEvents. </param>
        /// <param name="adxTwinLifecycleEventsTableName"> The name of the Azure Data Explorer table used for recording twin lifecycle events. The table will not be created if this property is left unspecified. </param>
        /// <param name="adxRelationshipLifecycleEventsTableName"> The name of the Azure Data Explorer table used for recording relationship lifecycle events. The table will not be created if this property is left unspecified. </param>
        /// <param name="eventHubEndpointUri"> The URL of the EventHub namespace for identity-based authentication. It must include the protocol sb://. </param>
        /// <param name="eventHubEntityPath"> The EventHub name in the EventHub namespace for identity-based authentication. </param>
        /// <param name="eventHubNamespaceResourceId"> The resource ID of the EventHub namespace. </param>
        /// <param name="eventHubConsumerGroup"> The EventHub consumer group to use when ADX reads from EventHub. Defaults to $Default. </param>
        /// <param name="recordPropertyAndItemRemovals"> Specifies whether or not to record twin / relationship property and item removals, including removals of indexed or keyed values (such as map entries, array elements, etc.). This feature is de-activated unless explicitly set to 'true'. Setting this property to 'true' will generate an additional column in the property events table in ADX. </param>
        /// <returns> A new <see cref="Models.DataExplorerConnectionProperties"/> instance for mocking. </returns>
        public static DataExplorerConnectionProperties DataExplorerConnectionProperties(TimeSeriesDatabaseConnectionState? provisioningState = null, DigitalTwinsManagedIdentityReference identity = null, ResourceIdentifier adxResourceId = null, Uri adxEndpointUri = null, string adxDatabaseName = null, string adxTableName = null, string adxTwinLifecycleEventsTableName = null, string adxRelationshipLifecycleEventsTableName = null, Uri eventHubEndpointUri = null, string eventHubEntityPath = null, ResourceIdentifier eventHubNamespaceResourceId = null, string eventHubConsumerGroup = null, RecordPropertyAndItemRemoval? recordPropertyAndItemRemovals = null)
        {
            return new DataExplorerConnectionProperties(
                ConnectionType.AzureDataExplorer,
                provisioningState,
                identity,
                serializedAdditionalRawData: null,
                adxResourceId,
                adxEndpointUri,
                adxDatabaseName,
                adxTableName,
                adxTwinLifecycleEventsTableName,
                adxRelationshipLifecycleEventsTableName,
                eventHubEndpointUri,
                eventHubEntityPath,
                eventHubNamespaceResourceId,
                eventHubConsumerGroup,
                recordPropertyAndItemRemovals);
        }
    }
}
