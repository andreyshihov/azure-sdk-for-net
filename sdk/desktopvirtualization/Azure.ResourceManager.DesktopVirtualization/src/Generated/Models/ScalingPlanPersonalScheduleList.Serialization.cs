// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    internal partial class ScalingPlanPersonalScheduleList : IUtf8JsonSerializable, IJsonModel<ScalingPlanPersonalScheduleList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingPlanPersonalScheduleList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScalingPlanPersonalScheduleList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPersonalScheduleList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPersonalScheduleList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        ScalingPlanPersonalScheduleList IJsonModel<ScalingPlanPersonalScheduleList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPersonalScheduleList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPersonalScheduleList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingPlanPersonalScheduleList(document.RootElement, options);
        }

        internal static ScalingPlanPersonalScheduleList DeserializeScalingPlanPersonalScheduleList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ScalingPlanPersonalScheduleData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScalingPlanPersonalScheduleData> array = new List<ScalingPlanPersonalScheduleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScalingPlanPersonalScheduleData.DeserializeScalingPlanPersonalScheduleData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScalingPlanPersonalScheduleList(value ?? new ChangeTrackingList<ScalingPlanPersonalScheduleData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScalingPlanPersonalScheduleList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPersonalScheduleList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPersonalScheduleList)} does not support '{options.Format}' format.");
            }
        }

        ScalingPlanPersonalScheduleList IPersistableModel<ScalingPlanPersonalScheduleList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPersonalScheduleList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScalingPlanPersonalScheduleList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPersonalScheduleList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingPlanPersonalScheduleList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
