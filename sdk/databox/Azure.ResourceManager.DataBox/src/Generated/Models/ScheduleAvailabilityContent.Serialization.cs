// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownScheduleAvailabilityRequest))]
    public partial class ScheduleAvailabilityContent : IUtf8JsonSerializable, IJsonModel<ScheduleAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleAvailabilityContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleAvailabilityContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAvailabilityContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageLocation"u8);
            writer.WriteStringValue(StorageLocation);
            writer.WritePropertyName("skuName"u8);
            writer.WriteStringValue(SkuName.ToSerialString());
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
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

        ScheduleAvailabilityContent IJsonModel<ScheduleAvailabilityContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAvailabilityContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleAvailabilityContent(document.RootElement, options);
        }

        internal static ScheduleAvailabilityContent DeserializeScheduleAvailabilityContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("skuName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataBoxScheduleAvailabilityContent.DeserializeDataBoxScheduleAvailabilityContent(element, options);
                    case "DataBoxDisk": return DiskScheduleAvailabilityContent.DeserializeDiskScheduleAvailabilityContent(element, options);
                    case "DataBoxHeavy": return HeavyScheduleAvailabilityContent.DeserializeHeavyScheduleAvailabilityContent(element, options);
                }
            }
            return UnknownScheduleAvailabilityRequest.DeserializeUnknownScheduleAvailabilityRequest(element, options);
        }

        BinaryData IPersistableModel<ScheduleAvailabilityContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleAvailabilityContent)} does not support '{options.Format}' format.");
            }
        }

        ScheduleAvailabilityContent IPersistableModel<ScheduleAvailabilityContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleAvailabilityContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleAvailabilityContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleAvailabilityContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
