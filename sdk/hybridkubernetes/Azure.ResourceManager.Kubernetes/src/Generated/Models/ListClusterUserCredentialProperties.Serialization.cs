// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Models
{
    public partial class ListClusterUserCredentialProperties : IUtf8JsonSerializable, IJsonModel<ListClusterUserCredentialProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ListClusterUserCredentialProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ListClusterUserCredentialProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListClusterUserCredentialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListClusterUserCredentialProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("authenticationMethod"u8);
            writer.WriteStringValue(AuthenticationMethod.ToString());
            writer.WritePropertyName("clientProxy"u8);
            writer.WriteBooleanValue(ClientProxy);
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

        ListClusterUserCredentialProperties IJsonModel<ListClusterUserCredentialProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListClusterUserCredentialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ListClusterUserCredentialProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListClusterUserCredentialProperties(document.RootElement, options);
        }

        internal static ListClusterUserCredentialProperties DeserializeListClusterUserCredentialProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AuthenticationMethod authenticationMethod = default;
            bool clientProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationMethod"u8))
                {
                    authenticationMethod = new AuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientProxy"u8))
                {
                    clientProxy = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ListClusterUserCredentialProperties(authenticationMethod, clientProxy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ListClusterUserCredentialProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListClusterUserCredentialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ListClusterUserCredentialProperties)} does not support '{options.Format}' format.");
            }
        }

        ListClusterUserCredentialProperties IPersistableModel<ListClusterUserCredentialProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ListClusterUserCredentialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeListClusterUserCredentialProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ListClusterUserCredentialProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ListClusterUserCredentialProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
