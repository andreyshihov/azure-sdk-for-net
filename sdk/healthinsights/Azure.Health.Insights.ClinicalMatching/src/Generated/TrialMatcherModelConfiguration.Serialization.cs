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

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherModelConfiguration : IUtf8JsonSerializable, IJsonModel<TrialMatcherModelConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrialMatcherModelConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrialMatcherModelConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherModelConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Verbose))
            {
                writer.WritePropertyName("verbose"u8);
                writer.WriteBooleanValue(Verbose.Value);
            }
            if (Optional.IsDefined(IncludeEvidence))
            {
                writer.WritePropertyName("includeEvidence"u8);
                writer.WriteBooleanValue(IncludeEvidence.Value);
            }
            writer.WritePropertyName("clinicalTrials"u8);
            writer.WriteObjectValue(ClinicalTrials);
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

        TrialMatcherModelConfiguration IJsonModel<TrialMatcherModelConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherModelConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrialMatcherModelConfiguration(document.RootElement, options);
        }

        internal static TrialMatcherModelConfiguration DeserializeTrialMatcherModelConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? verbose = default;
            bool? includeEvidence = default;
            ClinicalTrials clinicalTrials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verbose"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verbose = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeEvidence = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clinicalTrials"u8))
                {
                    clinicalTrials = ClinicalTrials.DeserializeClinicalTrials(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrialMatcherModelConfiguration(verbose, includeEvidence, clinicalTrials, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrialMatcherModelConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherModelConfiguration)} does not support '{options.Format}' format.");
            }
        }

        TrialMatcherModelConfiguration IPersistableModel<TrialMatcherModelConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrialMatcherModelConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherModelConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrialMatcherModelConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherModelConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherModelConfiguration(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
