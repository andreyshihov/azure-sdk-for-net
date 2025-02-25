// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlUpsertSettings : IUtf8JsonSerializable, IJsonModel<SqlUpsertSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlUpsertSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlUpsertSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlUpsertSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlUpsertSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UseTempDB))
            {
                writer.WritePropertyName("useTempDB"u8);
                JsonSerializer.Serialize(writer, UseTempDB);
            }
            if (Optional.IsDefined(InterimSchemaName))
            {
                writer.WritePropertyName("interimSchemaName"u8);
                JsonSerializer.Serialize(writer, InterimSchemaName);
            }
            if (Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                JsonSerializer.Serialize(writer, Keys);
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

        SqlUpsertSettings IJsonModel<SqlUpsertSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlUpsertSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlUpsertSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlUpsertSettings(document.RootElement, options);
        }

        internal static SqlUpsertSettings DeserializeSqlUpsertSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> useTempDB = default;
            DataFactoryElement<string> interimSchemaName = default;
            DataFactoryElement<IList<string>> keys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("useTempDB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTempDB = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("interimSchemaName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interimSchemaName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keys = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlUpsertSettings(useTempDB, interimSchemaName, keys, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlUpsertSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlUpsertSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlUpsertSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlUpsertSettings IPersistableModel<SqlUpsertSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlUpsertSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlUpsertSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlUpsertSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlUpsertSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
