// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class GetGroupIdListForLdapUserResult : IUtf8JsonSerializable, IJsonModel<GetGroupIdListForLdapUserResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetGroupIdListForLdapUserResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetGroupIdListForLdapUserResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetGroupIdListForLdapUserResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetGroupIdListForLdapUserResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(GroupIdsForLdapUser))
            {
                writer.WritePropertyName("groupIdsForLdapUser"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIdsForLdapUser)
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

        GetGroupIdListForLdapUserResult IJsonModel<GetGroupIdListForLdapUserResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetGroupIdListForLdapUserResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetGroupIdListForLdapUserResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetGroupIdListForLdapUserResult(document.RootElement, options);
        }

        internal static GetGroupIdListForLdapUserResult DeserializeGetGroupIdListForLdapUserResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> groupIdsForLdapUser = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupIdsForLdapUser"u8))
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
                    groupIdsForLdapUser = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetGroupIdListForLdapUserResult(groupIdsForLdapUser ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetGroupIdListForLdapUserResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetGroupIdListForLdapUserResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetGroupIdListForLdapUserResult)} does not support '{options.Format}' format.");
            }
        }

        GetGroupIdListForLdapUserResult IPersistableModel<GetGroupIdListForLdapUserResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetGroupIdListForLdapUserResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetGroupIdListForLdapUserResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetGroupIdListForLdapUserResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetGroupIdListForLdapUserResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
