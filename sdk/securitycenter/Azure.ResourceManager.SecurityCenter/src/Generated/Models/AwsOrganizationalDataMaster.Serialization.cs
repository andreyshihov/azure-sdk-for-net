// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AwsOrganizationalDataMaster : IUtf8JsonSerializable, IJsonModel<AwsOrganizationalDataMaster>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AwsOrganizationalDataMaster>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AwsOrganizationalDataMaster>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StacksetName))
            {
                writer.WritePropertyName("stacksetName"u8);
                writer.WriteStringValue(StacksetName);
            }
            if (Optional.IsCollectionDefined(ExcludedAccountIds))
            {
                writer.WritePropertyName("excludedAccountIds"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedAccountIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
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

        AwsOrganizationalDataMaster IJsonModel<AwsOrganizationalDataMaster>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsOrganizationalDataMaster(document.RootElement, options);
        }

        internal static AwsOrganizationalDataMaster DeserializeAwsOrganizationalDataMaster(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stacksetName = default;
            IList<string> excludedAccountIds = default;
            OrganizationMembershipType organizationMembershipType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stacksetName"u8))
                {
                    stacksetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedAccountIds"u8))
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
                    excludedAccountIds = array;
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AwsOrganizationalDataMaster(organizationMembershipType, serializedAdditionalRawData, stacksetName, excludedAccountIds ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<AwsOrganizationalDataMaster>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support '{options.Format}' format.");
            }
        }

        AwsOrganizationalDataMaster IPersistableModel<AwsOrganizationalDataMaster>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAwsOrganizationalDataMaster(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AwsOrganizationalDataMaster>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
