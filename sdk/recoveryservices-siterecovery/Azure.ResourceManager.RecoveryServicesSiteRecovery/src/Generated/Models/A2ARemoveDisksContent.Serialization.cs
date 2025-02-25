// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ARemoveDisksContent : IUtf8JsonSerializable, IJsonModel<A2ARemoveDisksContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ARemoveDisksContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ARemoveDisksContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARemoveDisksContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ARemoveDisksContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VmDisksUris))
            {
                writer.WritePropertyName("vmDisksUris"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisksUris)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisksIds))
            {
                writer.WritePropertyName("vmManagedDisksIds"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisksIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        A2ARemoveDisksContent IJsonModel<A2ARemoveDisksContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARemoveDisksContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ARemoveDisksContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ARemoveDisksContent(document.RootElement, options);
        }

        internal static A2ARemoveDisksContent DeserializeA2ARemoveDisksContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Uri> vmDisksUris = default;
            IList<string> vmManagedDisksIds = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmDisksUris"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    vmDisksUris = array;
                    continue;
                }
                if (property.NameEquals("vmManagedDisksIds"u8))
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
                    vmManagedDisksIds = array;
                    continue;
                }
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
            return new A2ARemoveDisksContent(instanceType, serializedAdditionalRawData, vmDisksUris ?? new ChangeTrackingList<Uri>(), vmManagedDisksIds ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<A2ARemoveDisksContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARemoveDisksContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2ARemoveDisksContent)} does not support '{options.Format}' format.");
            }
        }

        A2ARemoveDisksContent IPersistableModel<A2ARemoveDisksContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARemoveDisksContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2ARemoveDisksContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2ARemoveDisksContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2ARemoveDisksContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
