// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FileSystemHttpLogsConfig : IUtf8JsonSerializable, IJsonModel<FileSystemHttpLogsConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileSystemHttpLogsConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FileSystemHttpLogsConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemHttpLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemHttpLogsConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionInMb))
            {
                writer.WritePropertyName("retentionInMb"u8);
                writer.WriteNumberValue(RetentionInMb.Value);
            }
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("retentionInDays"u8);
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        FileSystemHttpLogsConfig IJsonModel<FileSystemHttpLogsConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemHttpLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemHttpLogsConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemHttpLogsConfig(document.RootElement, options);
        }

        internal static FileSystemHttpLogsConfig DeserializeFileSystemHttpLogsConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? retentionInMb = default;
            int? retentionInDays = default;
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retentionInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FileSystemHttpLogsConfig(retentionInMb, retentionInDays, enabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FileSystemHttpLogsConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemHttpLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileSystemHttpLogsConfig)} does not support '{options.Format}' format.");
            }
        }

        FileSystemHttpLogsConfig IPersistableModel<FileSystemHttpLogsConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemHttpLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileSystemHttpLogsConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileSystemHttpLogsConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileSystemHttpLogsConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
