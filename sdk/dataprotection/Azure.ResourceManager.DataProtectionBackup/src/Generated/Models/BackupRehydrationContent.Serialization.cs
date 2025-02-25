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
    public partial class BackupRehydrationContent : IUtf8JsonSerializable, IJsonModel<BackupRehydrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRehydrationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupRehydrationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRehydrationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            if (Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority.Value.ToString());
            }
            writer.WritePropertyName("rehydrationRetentionDuration"u8);
            writer.WriteStringValue(RehydrationRetentionDuration, "P");
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

        BackupRehydrationContent IJsonModel<BackupRehydrationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRehydrationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRehydrationContent(document.RootElement, options);
        }

        internal static BackupRehydrationContent DeserializeBackupRehydrationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryPointId = default;
            BackupRehydrationPriority? rehydrationPriority = default;
            TimeSpan rehydrationRetentionDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationPriority = new BackupRehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupRehydrationContent(recoveryPointId, rehydrationPriority, rehydrationRetentionDuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupRehydrationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupRehydrationContent)} does not support '{options.Format}' format.");
            }
        }

        BackupRehydrationContent IPersistableModel<BackupRehydrationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRehydrationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupRehydrationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupRehydrationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupRehydrationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
