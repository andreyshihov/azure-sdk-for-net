// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppJobScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppJobScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(JobScaleRuleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(JobScaleRuleType);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
                {
                    writer.WriteObjectValue(item);
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

        ContainerAppJobScaleRule IJsonModel<ContainerAppJobScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobScaleRule(document.RootElement, options);
        }

        internal static ContainerAppJobScaleRule DeserializeContainerAppJobScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            BinaryData metadata = default;
            IList<ContainerAppScaleRuleAuth> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRuleAuth> array = new List<ContainerAppScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRuleAuth.DeserializeContainerAppScaleRuleAuth(item, options));
                    }
                    auth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppJobScaleRule(name, type, metadata, auth ?? new ChangeTrackingList<ContainerAppScaleRuleAuth>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJobScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppJobScaleRule IPersistableModel<ContainerAppJobScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobScaleRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
