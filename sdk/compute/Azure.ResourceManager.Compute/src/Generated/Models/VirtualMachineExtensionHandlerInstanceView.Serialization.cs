// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineExtensionHandlerInstanceView : IUtf8JsonSerializable, IJsonModel<VirtualMachineExtensionHandlerInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineExtensionHandlerInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineExtensionHandlerInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineExtensionHandlerInstanceViewType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VirtualMachineExtensionHandlerInstanceViewType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        VirtualMachineExtensionHandlerInstanceView IJsonModel<VirtualMachineExtensionHandlerInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineExtensionHandlerInstanceView(document.RootElement, options);
        }

        internal static VirtualMachineExtensionHandlerInstanceView DeserializeVirtualMachineExtensionHandlerInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string typeHandlerVersion = default;
            InstanceViewStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineExtensionHandlerInstanceView(type, typeHandlerVersion, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineExtensionHandlerInstanceView IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionHandlerInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineExtensionHandlerInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionHandlerInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineExtensionHandlerInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
