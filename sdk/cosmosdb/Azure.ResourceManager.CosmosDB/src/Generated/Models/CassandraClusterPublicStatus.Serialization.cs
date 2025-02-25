// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterPublicStatus : IUtf8JsonSerializable, IJsonModel<CassandraClusterPublicStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterPublicStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterPublicStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterPublicStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterPublicStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(ReaperStatus))
            {
                writer.WritePropertyName("reaperStatus"u8);
                writer.WriteObjectValue(ReaperStatus);
            }
            if (Optional.IsCollectionDefined(ConnectionErrors))
            {
                writer.WritePropertyName("connectionErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataCenters))
            {
                writer.WritePropertyName("dataCenters"u8);
                writer.WriteStartArray();
                foreach (var item in DataCenters)
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

        CassandraClusterPublicStatus IJsonModel<CassandraClusterPublicStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterPublicStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterPublicStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterPublicStatus(document.RootElement, options);
        }

        internal static CassandraClusterPublicStatus DeserializeCassandraClusterPublicStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? eTag = default;
            CassandraReaperStatus reaperStatus = default;
            IReadOnlyList<CassandraConnectionError> connectionErrors = default;
            IReadOnlyList<CassandraError> errors = default;
            IReadOnlyList<CassandraClusterPublicStatusDataCentersItem> dataCenters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reaperStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reaperStatus = CassandraReaperStatus.DeserializeCassandraReaperStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("connectionErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraConnectionError> array = new List<CassandraConnectionError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraConnectionError.DeserializeCassandraConnectionError(item, options));
                    }
                    connectionErrors = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraError> array = new List<CassandraError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraError.DeserializeCassandraError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("dataCenters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraClusterPublicStatusDataCentersItem> array = new List<CassandraClusterPublicStatusDataCentersItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraClusterPublicStatusDataCentersItem.DeserializeCassandraClusterPublicStatusDataCentersItem(item, options));
                    }
                    dataCenters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterPublicStatus(
                eTag,
                reaperStatus,
                connectionErrors ?? new ChangeTrackingList<CassandraConnectionError>(),
                errors ?? new ChangeTrackingList<CassandraError>(),
                dataCenters ?? new ChangeTrackingList<CassandraClusterPublicStatusDataCentersItem>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraClusterPublicStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterPublicStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterPublicStatus)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterPublicStatus IPersistableModel<CassandraClusterPublicStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterPublicStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterPublicStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterPublicStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterPublicStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
