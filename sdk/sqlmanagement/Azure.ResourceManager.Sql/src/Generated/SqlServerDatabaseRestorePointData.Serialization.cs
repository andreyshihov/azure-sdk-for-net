// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDatabaseRestorePointData : IUtf8JsonSerializable, IJsonModel<SqlServerDatabaseRestorePointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerDatabaseRestorePointData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerDatabaseRestorePointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseRestorePointData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("restorePointType"u8);
                writer.WriteStringValue(RestorePointType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(EarliestRestoreOn))
            {
                writer.WritePropertyName("earliestRestoreDate"u8);
                writer.WriteStringValue(EarliestRestoreOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RestorePointCreatedOn))
            {
                writer.WritePropertyName("restorePointCreationDate"u8);
                writer.WriteStringValue(RestorePointCreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RestorePointLabel))
            {
                writer.WritePropertyName("restorePointLabel"u8);
                writer.WriteStringValue(RestorePointLabel);
            }
            writer.WriteEndObject();
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

        SqlServerDatabaseRestorePointData IJsonModel<SqlServerDatabaseRestorePointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseRestorePointData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerDatabaseRestorePointData(document.RootElement, options);
        }

        internal static SqlServerDatabaseRestorePointData DeserializeSqlServerDatabaseRestorePointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            RestorePointType? restorePointType = default;
            DateTimeOffset? earliestRestoreDate = default;
            DateTimeOffset? restorePointCreationDate = default;
            string restorePointLabel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("restorePointType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointType = property0.Value.GetString().ToRestorePointType();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointCreationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointCreationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointLabel"u8))
                        {
                            restorePointLabel = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServerDatabaseRestorePointData(
                id,
                name,
                type,
                systemData,
                location,
                restorePointType,
                earliestRestoreDate,
                restorePointCreationDate,
                restorePointLabel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerDatabaseRestorePointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseRestorePointData)} does not support '{options.Format}' format.");
            }
        }

        SqlServerDatabaseRestorePointData IPersistableModel<SqlServerDatabaseRestorePointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseRestorePointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerDatabaseRestorePointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseRestorePointData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerDatabaseRestorePointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
