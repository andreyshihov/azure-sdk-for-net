// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspacePatch : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspacePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspacePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningWorkspacePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteStringValue(ApplicationInsights);
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                writer.WritePropertyName("containerRegistry"u8);
                writer.WriteStringValue(ContainerRegistry);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(EnableDataIsolation))
            {
                writer.WritePropertyName("enableDataIsolation"u8);
                writer.WriteBooleanValue(EnableDataIsolation.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(FeatureStoreSettings))
            {
                writer.WritePropertyName("featureStoreSettings"u8);
                writer.WriteObjectValue(FeatureStoreSettings);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ImageBuildCompute))
            {
                writer.WritePropertyName("imageBuildCompute"u8);
                writer.WriteStringValue(ImageBuildCompute);
            }
            if (Optional.IsDefined(ManagedNetwork))
            {
                writer.WritePropertyName("managedNetwork"u8);
                writer.WriteObjectValue(ManagedNetwork);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentity))
            {
                writer.WritePropertyName("primaryUserAssignedIdentity"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccessType))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccessType.Value.ToString());
            }
            if (Optional.IsDefined(ServiceManagedResourcesSettings))
            {
                writer.WritePropertyName("serviceManagedResourcesSettings"u8);
                writer.WriteObjectValue(ServiceManagedResourcesSettings);
            }
            if (Optional.IsDefined(SoftDeleteRetentionInDays))
            {
                writer.WritePropertyName("softDeleteRetentionInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionInDays.Value);
            }
            if (Optional.IsDefined(V1LegacyMode))
            {
                writer.WritePropertyName("v1LegacyMode"u8);
                writer.WriteBooleanValue(V1LegacyMode.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningWorkspacePatch IJsonModel<MachineLearningWorkspacePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspacePatch(document.RootElement, options);
        }

        internal static MachineLearningWorkspacePatch DeserializeMachineLearningWorkspacePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            MachineLearningSku sku = default;
            IDictionary<string, string> tags = default;
            string applicationInsights = default;
            string containerRegistry = default;
            string description = default;
            bool? enableDataIsolation = default;
            EncryptionUpdateProperties encryption = default;
            FeatureStoreSettings featureStoreSettings = default;
            string friendlyName = default;
            string imageBuildCompute = default;
            ManagedNetworkSettings managedNetwork = default;
            string primaryUserAssignedIdentity = default;
            MachineLearningPublicNetworkAccessType? publicNetworkAccess = default;
            ServiceManagedResourcesSettings serviceManagedResourcesSettings = default;
            int? softDeleteRetentionInDays = default;
            bool? v1LegacyMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MachineLearningSku.DeserializeMachineLearningSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("applicationInsights"u8))
                        {
                            applicationInsights = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistry"u8))
                        {
                            containerRegistry = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableDataIsolation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDataIsolation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = EncryptionUpdateProperties.DeserializeEncryptionUpdateProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("featureStoreSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            featureStoreSettings = FeatureStoreSettings.DeserializeFeatureStoreSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageBuildCompute"u8))
                        {
                            imageBuildCompute = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedNetwork = ManagedNetworkSettings.DeserializeManagedNetworkSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentity"u8))
                        {
                            primaryUserAssignedIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new MachineLearningPublicNetworkAccessType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceManagedResourcesSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceManagedResourcesSettings = ServiceManagedResourcesSettings.DeserializeServiceManagedResourcesSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("softDeleteRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softDeleteRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("v1LegacyMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            v1LegacyMode = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningWorkspacePatch(
                identity,
                sku,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                applicationInsights,
                containerRegistry,
                description,
                enableDataIsolation,
                encryption,
                featureStoreSettings,
                friendlyName,
                imageBuildCompute,
                managedNetwork,
                primaryUserAssignedIdentity,
                publicNetworkAccess,
                serviceManagedResourcesSettings,
                softDeleteRetentionInDays,
                v1LegacyMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningWorkspacePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningWorkspacePatch IPersistableModel<MachineLearningWorkspacePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningWorkspacePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspacePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
