// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class BackupProperties : IUtf8JsonSerializable, IJsonModel<BackupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureStorageResourceUri))
            {
                writer.WritePropertyName("azureStorageResourceUri"u8);
                writer.WriteStringValue(AzureStorageResourceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupOn))
            {
                writer.WritePropertyName("lastBackupDateTime"u8);
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
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

        BackupProperties IJsonModel<BackupProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupProperties(document.RootElement, options);
        }

        internal static BackupProperties DeserializeBackupProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri azureStorageResourceUri = default;
            DateTimeOffset? lastBackupDateTime = default;
            string lastBackupStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureStorageResourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStorageResourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastBackupDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastBackupDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupProperties(azureStorageResourceUri, lastBackupDateTime, lastBackupStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupProperties)} does not support '{options.Format}' format.");
            }
        }

        BackupProperties IPersistableModel<BackupProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
