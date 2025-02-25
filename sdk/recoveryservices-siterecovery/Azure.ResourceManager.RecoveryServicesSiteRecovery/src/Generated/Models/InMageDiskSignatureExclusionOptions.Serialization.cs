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
    public partial class InMageDiskSignatureExclusionOptions : IUtf8JsonSerializable, IJsonModel<InMageDiskSignatureExclusionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageDiskSignatureExclusionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageDiskSignatureExclusionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskSignatureExclusionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskSignatureExclusionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskSignature))
            {
                writer.WritePropertyName("diskSignature"u8);
                writer.WriteStringValue(DiskSignature);
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

        InMageDiskSignatureExclusionOptions IJsonModel<InMageDiskSignatureExclusionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskSignatureExclusionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskSignatureExclusionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageDiskSignatureExclusionOptions(document.RootElement, options);
        }

        internal static InMageDiskSignatureExclusionOptions DeserializeInMageDiskSignatureExclusionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskSignature = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSignature"u8))
                {
                    diskSignature = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageDiskSignatureExclusionOptions(diskSignature, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageDiskSignatureExclusionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskSignatureExclusionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageDiskSignatureExclusionOptions)} does not support '{options.Format}' format.");
            }
        }

        InMageDiskSignatureExclusionOptions IPersistableModel<InMageDiskSignatureExclusionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskSignatureExclusionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageDiskSignatureExclusionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageDiskSignatureExclusionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageDiskSignatureExclusionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
