// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DWCopyCommandDefaultValue : IUtf8JsonSerializable, IJsonModel<DWCopyCommandDefaultValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DWCopyCommandDefaultValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DWCopyCommandDefaultValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandDefaultValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ColumnName);
#else
                using (JsonDocument document = JsonDocument.Parse(ColumnName))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DefaultValue);
#else
                using (JsonDocument document = JsonDocument.Parse(DefaultValue))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        DWCopyCommandDefaultValue IJsonModel<DWCopyCommandDefaultValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandDefaultValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDWCopyCommandDefaultValue(document.RootElement, options);
        }

        internal static DWCopyCommandDefaultValue DeserializeDWCopyCommandDefaultValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData columnName = default;
            BinaryData defaultValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DWCopyCommandDefaultValue(columnName, defaultValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DWCopyCommandDefaultValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandDefaultValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{options.Format}' format.");
            }
        }

        DWCopyCommandDefaultValue IPersistableModel<DWCopyCommandDefaultValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandDefaultValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDWCopyCommandDefaultValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DWCopyCommandDefaultValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DWCopyCommandDefaultValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
