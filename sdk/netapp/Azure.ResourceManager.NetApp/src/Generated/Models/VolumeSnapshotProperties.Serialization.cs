// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class VolumeSnapshotProperties : IUtf8JsonSerializable, IJsonModel<VolumeSnapshotProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VolumeSnapshotProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VolumeSnapshotProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeSnapshotProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SnapshotPolicyId))
            {
                writer.WritePropertyName("snapshotPolicyId"u8);
                writer.WriteStringValue(SnapshotPolicyId);
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

        VolumeSnapshotProperties IJsonModel<VolumeSnapshotProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeSnapshotProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVolumeSnapshotProperties(document.RootElement, options);
        }

        internal static VolumeSnapshotProperties DeserializeVolumeSnapshotProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier snapshotPolicyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotPolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    snapshotPolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VolumeSnapshotProperties(snapshotPolicyId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VolumeSnapshotProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VolumeSnapshotProperties)} does not support '{options.Format}' format.");
            }
        }

        VolumeSnapshotProperties IPersistableModel<VolumeSnapshotProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVolumeSnapshotProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VolumeSnapshotProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VolumeSnapshotProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
