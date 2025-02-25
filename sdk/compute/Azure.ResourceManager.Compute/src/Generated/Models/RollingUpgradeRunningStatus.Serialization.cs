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
    public partial class RollingUpgradeRunningStatus : IUtf8JsonSerializable, IJsonModel<RollingUpgradeRunningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollingUpgradeRunningStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RollingUpgradeRunningStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradeRunningStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradeRunningStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastAction))
            {
                writer.WritePropertyName("lastAction"u8);
                writer.WriteStringValue(LastAction.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastActionOn))
            {
                writer.WritePropertyName("lastActionTime"u8);
                writer.WriteStringValue(LastActionOn.Value, "O");
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

        RollingUpgradeRunningStatus IJsonModel<RollingUpgradeRunningStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradeRunningStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RollingUpgradeRunningStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollingUpgradeRunningStatus(document.RootElement, options);
        }

        internal static RollingUpgradeRunningStatus DeserializeRollingUpgradeRunningStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RollingUpgradeStatusCode? code = default;
            DateTimeOffset? startTime = default;
            RollingUpgradeActionType? lastAction = default;
            DateTimeOffset? lastActionTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = property.Value.GetString().ToRollingUpgradeStatusCode();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAction = property.Value.GetString().ToRollingUpgradeActionType();
                    continue;
                }
                if (property.NameEquals("lastActionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RollingUpgradeRunningStatus(code, startTime, lastAction, lastActionTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RollingUpgradeRunningStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradeRunningStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradeRunningStatus)} does not support '{options.Format}' format.");
            }
        }

        RollingUpgradeRunningStatus IPersistableModel<RollingUpgradeRunningStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RollingUpgradeRunningStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRollingUpgradeRunningStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RollingUpgradeRunningStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RollingUpgradeRunningStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
