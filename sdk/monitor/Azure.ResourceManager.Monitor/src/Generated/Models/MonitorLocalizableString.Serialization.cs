// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorLocalizableString : IUtf8JsonSerializable, IJsonModel<MonitorLocalizableString>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorLocalizableString>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorLocalizableString>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorLocalizableString>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorLocalizableString)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(LocalizedValue))
            {
                writer.WritePropertyName("localizedValue"u8);
                writer.WriteStringValue(LocalizedValue);
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

        MonitorLocalizableString IJsonModel<MonitorLocalizableString>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorLocalizableString>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorLocalizableString)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorLocalizableString(document.RootElement, options);
        }

        internal static MonitorLocalizableString DeserializeMonitorLocalizableString(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string value = default;
            string localizedValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"u8))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorLocalizableString(value, localizedValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorLocalizableString>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorLocalizableString>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorLocalizableString)} does not support '{options.Format}' format.");
            }
        }

        MonitorLocalizableString IPersistableModel<MonitorLocalizableString>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorLocalizableString>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorLocalizableString(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorLocalizableString)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorLocalizableString>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
