// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The parameters for updating a machine learning workspace. </summary>
    public partial class MachineLearningWorkspacePatch
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspacePatch"/>. </summary>
        public MachineLearningWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspacePatch"/>. </summary>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="sku"> Optional. This field is required to be implemented by the RP because AML is supporting more than one tier. </param>
        /// <param name="tags"> The resource tags for the machine learning workspace. </param>
        /// <param name="applicationInsights"> ARM id of the application insights associated with this workspace. </param>
        /// <param name="containerRegistry"> ARM id of the container registry associated with this workspace. </param>
        /// <param name="description"> The description of this workspace. </param>
        /// <param name="enableDataIsolation"></param>
        /// <param name="encryption"></param>
        /// <param name="featureStoreSettings"> Settings for feature store type workspace. </param>
        /// <param name="friendlyName"> The friendly name for this workspace. This name in mutable. </param>
        /// <param name="imageBuildCompute"> The compute name for image build. </param>
        /// <param name="managedNetwork"> Managed Network settings for a machine learning workspace. </param>
        /// <param name="primaryUserAssignedIdentity"> The user assigned identity resource id that represents the workspace identity. </param>
        /// <param name="publicNetworkAccessType"> Whether requests from Public Network are allowed. </param>
        /// <param name="serviceManagedResourcesSettings"> The service managed resource settings. </param>
        /// <param name="softDeleteRetentionInDays"> Retention time in days after workspace get soft deleted. </param>
        /// <param name="v1LegacyMode"> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspacePatch(ManagedServiceIdentity identity, MachineLearningSku sku, IDictionary<string, string> tags, string applicationInsights, string containerRegistry, string description, bool? enableDataIsolation, EncryptionUpdateProperties encryption, FeatureStoreSettings featureStoreSettings, string friendlyName, string imageBuildCompute, ManagedNetworkSettings managedNetwork, string primaryUserAssignedIdentity, MachineLearningPublicNetworkAccessType? publicNetworkAccessType, ServiceManagedResourcesSettings serviceManagedResourcesSettings, int? softDeleteRetentionInDays, bool? v1LegacyMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Sku = sku;
            Tags = tags;
            ApplicationInsights = applicationInsights;
            ContainerRegistry = containerRegistry;
            Description = description;
            EnableDataIsolation = enableDataIsolation;
            Encryption = encryption;
            FeatureStoreSettings = featureStoreSettings;
            FriendlyName = friendlyName;
            ImageBuildCompute = imageBuildCompute;
            ManagedNetwork = managedNetwork;
            PrimaryUserAssignedIdentity = primaryUserAssignedIdentity;
            PublicNetworkAccessType = publicNetworkAccessType;
            ServiceManagedResourcesSettings = serviceManagedResourcesSettings;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            V1LegacyMode = v1LegacyMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Optional. This field is required to be implemented by the RP because AML is supporting more than one tier. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> The resource tags for the machine learning workspace. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> ARM id of the application insights associated with this workspace. </summary>
        public string ApplicationInsights { get; set; }
        /// <summary> ARM id of the container registry associated with this workspace. </summary>
        public string ContainerRegistry { get; set; }
        /// <summary> The description of this workspace. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the enable data isolation. </summary>
        public bool? EnableDataIsolation { get; set; }
        /// <summary> Gets or sets the encryption. </summary>
        internal EncryptionUpdateProperties Encryption { get; set; }
        /// <summary> Gets or sets the key identifier. </summary>
        public string KeyIdentifier
        {
            get => Encryption is null ? default : Encryption.KeyIdentifier;
            set => Encryption = new EncryptionUpdateProperties(value);
        }

        /// <summary> Settings for feature store type workspace. </summary>
        public FeatureStoreSettings FeatureStoreSettings { get; set; }
        /// <summary> The friendly name for this workspace. This name in mutable. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The compute name for image build. </summary>
        public string ImageBuildCompute { get; set; }
        /// <summary> Managed Network settings for a machine learning workspace. </summary>
        public ManagedNetworkSettings ManagedNetwork { get; set; }
        /// <summary> The user assigned identity resource id that represents the workspace identity. </summary>
        public string PrimaryUserAssignedIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public MachineLearningPublicNetworkAccessType? PublicNetworkAccessType { get; set; }
        /// <summary> The service managed resource settings. </summary>
        internal ServiceManagedResourcesSettings ServiceManagedResourcesSettings { get; set; }
        /// <summary> Gets or sets the cosmos db collections throughput. </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => ServiceManagedResourcesSettings is null ? default : ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput;
            set
            {
                if (ServiceManagedResourcesSettings is null)
                    ServiceManagedResourcesSettings = new ServiceManagedResourcesSettings();
                ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput = value;
            }
        }

        /// <summary> Retention time in days after workspace get soft deleted. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </summary>
        public bool? V1LegacyMode { get; set; }
    }
}
