// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupRecoveryTimeBasedRestoreContent : IUtf8JsonSerializable, IJsonModel<BackupRecoveryTimeBasedRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRecoveryTimeBasedRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupRecoveryTimeBasedRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRecoveryTimeBasedRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRecoveryTimeBasedRestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointTime"u8);
            writer.WriteStringValue(RecoverOn, "O");
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            writer.WriteObjectValue(RestoreTargetInfo);
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
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

        BackupRecoveryTimeBasedRestoreContent IJsonModel<BackupRecoveryTimeBasedRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRecoveryTimeBasedRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRecoveryTimeBasedRestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRecoveryTimeBasedRestoreContent(document.RootElement, options);
        }

        internal static BackupRecoveryTimeBasedRestoreContent DeserializeBackupRecoveryTimeBasedRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset recoveryPointTime = default;
            string objectType = default;
            RestoreTargetInfoBase restoreTargetInfo = default;
            SourceDataStoreType sourceDataStoreType = default;
            ResourceIdentifier sourceResourceId = default;
            DataProtectionIdentityDetails identityDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetInfo"u8))
                {
                    restoreTargetInfo = RestoreTargetInfoBase.DeserializeRestoreTargetInfoBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDataStoreType"u8))
                {
                    sourceDataStoreType = new SourceDataStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityDetails = DataProtectionIdentityDetails.DeserializeDataProtectionIdentityDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupRecoveryTimeBasedRestoreContent(
                objectType,
                restoreTargetInfo,
                sourceDataStoreType,
                sourceResourceId,
                identityDetails,
                serializedAdditionalRawData,
                recoveryPointTime);
        }

        BinaryData IPersistableModel<BackupRecoveryTimeBasedRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRecoveryTimeBasedRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupRecoveryTimeBasedRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        BackupRecoveryTimeBasedRestoreContent IPersistableModel<BackupRecoveryTimeBasedRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRecoveryTimeBasedRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupRecoveryTimeBasedRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupRecoveryTimeBasedRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupRecoveryTimeBasedRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
