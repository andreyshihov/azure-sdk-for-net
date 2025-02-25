// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class CrossRegionRestoreDetails : IUtf8JsonSerializable, IJsonModel<CrossRegionRestoreDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CrossRegionRestoreDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CrossRegionRestoreDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CrossRegionRestoreDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceRegion"u8);
            writer.WriteStringValue(SourceRegion);
            writer.WritePropertyName("sourceBackupInstanceId"u8);
            writer.WriteStringValue(SourceBackupInstanceId);
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

        CrossRegionRestoreDetails IJsonModel<CrossRegionRestoreDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CrossRegionRestoreDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCrossRegionRestoreDetails(document.RootElement, options);
        }

        internal static CrossRegionRestoreDetails DeserializeCrossRegionRestoreDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation sourceRegion = default;
            ResourceIdentifier sourceBackupInstanceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRegion"u8))
                {
                    sourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceBackupInstanceId"u8))
                {
                    sourceBackupInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CrossRegionRestoreDetails(sourceRegion, sourceBackupInstanceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CrossRegionRestoreDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CrossRegionRestoreDetails)} does not support '{options.Format}' format.");
            }
        }

        CrossRegionRestoreDetails IPersistableModel<CrossRegionRestoreDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CrossRegionRestoreDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCrossRegionRestoreDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CrossRegionRestoreDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CrossRegionRestoreDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
