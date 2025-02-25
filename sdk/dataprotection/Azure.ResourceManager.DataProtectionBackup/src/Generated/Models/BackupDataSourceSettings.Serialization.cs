// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownBackupDatasourceParameters))]
    public partial class BackupDataSourceSettings : IUtf8JsonSerializable, IJsonModel<BackupDataSourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupDataSourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupDataSourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupDataSourceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        BackupDataSourceSettings IJsonModel<BackupDataSourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupDataSourceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupDataSourceSettings(document.RootElement, options);
        }

        internal static BackupDataSourceSettings DeserializeBackupDataSourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BlobBackupDatasourceParameters": return BlobBackupDataSourceSettings.DeserializeBlobBackupDataSourceSettings(element, options);
                    case "KubernetesClusterBackupDatasourceParameters": return KubernetesClusterBackupDataSourceSettings.DeserializeKubernetesClusterBackupDataSourceSettings(element, options);
                }
            }
            return UnknownBackupDatasourceParameters.DeserializeUnknownBackupDatasourceParameters(element, options);
        }

        BinaryData IPersistableModel<BackupDataSourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupDataSourceSettings)} does not support '{options.Format}' format.");
            }
        }

        BackupDataSourceSettings IPersistableModel<BackupDataSourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupDataSourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupDataSourceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupDataSourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
