// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownExportSummary))]
    public partial class ExportSummary : IUtf8JsonSerializable, IJsonModel<ExportSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExportSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endDateTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endDateTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ExportedRowCount))
            {
                if (ExportedRowCount != null)
                {
                    writer.WritePropertyName("exportedRowCount"u8);
                    writer.WriteNumberValue(ExportedRowCount.Value);
                }
                else
                {
                    writer.WriteNull("exportedRowCount");
                }
            }
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format.ToString());
            if (options.Format != "W" && Optional.IsDefined(LabelingJobId))
            {
                if (LabelingJobId != null)
                {
                    writer.WritePropertyName("labelingJobId"u8);
                    writer.WriteStringValue(LabelingJobId);
                }
                else
                {
                    writer.WriteNull("labelingJobId");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startDateTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startDateTime");
                }
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

        ExportSummary IJsonModel<ExportSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportSummary(document.RootElement, options);
        }

        internal static ExportSummary DeserializeExportSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("format", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CSV": return CsvExportSummary.DeserializeCsvExportSummary(element, options);
                    case "Coco": return CocoExportSummary.DeserializeCocoExportSummary(element, options);
                    case "Dataset": return DatasetExportSummary.DeserializeDatasetExportSummary(element, options);
                }
            }
            return UnknownExportSummary.DeserializeUnknownExportSummary(element, options);
        }

        BinaryData IPersistableModel<ExportSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportSummary)} does not support '{options.Format}' format.");
            }
        }

        ExportSummary IPersistableModel<ExportSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
