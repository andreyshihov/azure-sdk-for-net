// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownFeatureSupportRequest))]
    public partial class FeatureSupportContent : IUtf8JsonSerializable, IJsonModel<FeatureSupportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FeatureSupportContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FeatureSupportContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSupportContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("featureType"u8);
            writer.WriteStringValue(FeatureType);
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

        FeatureSupportContent IJsonModel<FeatureSupportContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSupportContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFeatureSupportContent(document.RootElement, options);
        }

        internal static FeatureSupportContent DeserializeFeatureSupportContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("featureType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupGoals": return BackupGoalFeatureSupportContent.DeserializeBackupGoalFeatureSupportContent(element, options);
                    case "AzureVMResourceBackup": return VmResourceFeatureSupportContent.DeserializeVmResourceFeatureSupportContent(element, options);
                }
            }
            return UnknownFeatureSupportRequest.DeserializeUnknownFeatureSupportRequest(element, options);
        }

        BinaryData IPersistableModel<FeatureSupportContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FeatureSupportContent)} does not support '{options.Format}' format.");
            }
        }

        FeatureSupportContent IPersistableModel<FeatureSupportContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFeatureSupportContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FeatureSupportContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FeatureSupportContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
