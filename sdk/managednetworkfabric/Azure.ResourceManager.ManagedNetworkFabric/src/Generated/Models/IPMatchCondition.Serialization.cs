// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPMatchCondition : IUtf8JsonSerializable, IJsonModel<IPMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPMatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceDestinationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SourceDestinationType.Value.ToString());
            }
            if (Optional.IsDefined(PrefixType))
            {
                writer.WritePropertyName("prefixType"u8);
                writer.WriteStringValue(PrefixType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPPrefixValues))
            {
                writer.WritePropertyName("ipPrefixValues"u8);
                writer.WriteStartArray();
                foreach (var item in IPPrefixValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPGroupNames))
            {
                writer.WritePropertyName("ipGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in IPGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        IPMatchCondition IJsonModel<IPMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPMatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPMatchCondition(document.RootElement, options);
        }

        internal static IPMatchCondition DeserializeIPMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceDestinationType? type = default;
            IPMatchConditionPrefixType? prefixType = default;
            IList<string> ipPrefixValues = default;
            IList<string> ipGroupNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SourceDestinationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("prefixType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prefixType = new IPMatchConditionPrefixType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipPrefixValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipPrefixValues = array;
                    continue;
                }
                if (property.NameEquals("ipGroupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipGroupNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPMatchCondition(type, prefixType, ipPrefixValues ?? new ChangeTrackingList<string>(), ipGroupNames ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IPMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        IPMatchCondition IPersistableModel<IPMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IPMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
