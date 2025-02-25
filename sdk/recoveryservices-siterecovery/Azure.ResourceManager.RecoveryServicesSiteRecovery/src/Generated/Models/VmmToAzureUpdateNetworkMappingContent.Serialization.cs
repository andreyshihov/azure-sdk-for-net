// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmToAzureUpdateNetworkMappingContent : IUtf8JsonSerializable, IJsonModel<VmmToAzureUpdateNetworkMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmmToAzureUpdateNetworkMappingContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmmToAzureUpdateNetworkMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmToAzureUpdateNetworkMappingContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VmmToAzureUpdateNetworkMappingContent IJsonModel<VmmToAzureUpdateNetworkMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmToAzureUpdateNetworkMappingContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmToAzureUpdateNetworkMappingContent(document.RootElement, options);
        }

        internal static VmmToAzureUpdateNetworkMappingContent DeserializeVmmToAzureUpdateNetworkMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmmToAzureUpdateNetworkMappingContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmmToAzureUpdateNetworkMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmmToAzureUpdateNetworkMappingContent)} does not support '{options.Format}' format.");
            }
        }

        VmmToAzureUpdateNetworkMappingContent IPersistableModel<VmmToAzureUpdateNetworkMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmmToAzureUpdateNetworkMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmmToAzureUpdateNetworkMappingContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmmToAzureUpdateNetworkMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
