// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadContainer : IUtf8JsonSerializable, IJsonModel<WorkloadContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
            }
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

        WorkloadContainer IJsonModel<WorkloadContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadContainer(document.RootElement, options);
        }

        internal static WorkloadContainer DeserializeWorkloadContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("containerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SQLAGWorkLoadContainer": return SqlAvailabilityGroupWorkloadProtectionContainer.DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(element, options);
                    case "VMAppContainer": return VmAppContainerProtectionContainer.DeserializeVmAppContainerProtectionContainer(element, options);
                }
            }
            ResourceIdentifier sourceResourceId = default;
            DateTimeOffset? lastUpdatedTime = default;
            WorkloadContainerExtendedInfo extendedInfo = default;
            BackupWorkloadType? workloadType = default;
            WorkloadOperationType? operationType = default;
            string friendlyName = default;
            BackupManagementType? backupManagementType = default;
            string registrationStatus = default;
            string healthStatus = default;
            ProtectableContainerType containerType = default;
            string protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = WorkloadContainerExtendedInfo.DeserializeWorkloadContainerExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new WorkloadOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadContainer(
                friendlyName,
                backupManagementType,
                registrationStatus,
                healthStatus,
                containerType,
                protectableObjectType,
                serializedAdditionalRawData,
                sourceResourceId,
                lastUpdatedTime,
                extendedInfo,
                workloadType,
                operationType);
        }

        BinaryData IPersistableModel<WorkloadContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadContainer)} does not support '{options.Format}' format.");
            }
        }

        WorkloadContainer IPersistableModel<WorkloadContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
