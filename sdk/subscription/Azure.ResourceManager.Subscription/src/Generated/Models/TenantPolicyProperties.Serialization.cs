// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Subscription;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class TenantPolicyProperties : IUtf8JsonSerializable, IJsonModel<TenantPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TenantPolicyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TenantPolicyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TenantPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TenantPolicyProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(BlockSubscriptionsLeavingTenant))
            {
                writer.WritePropertyName("blockSubscriptionsLeavingTenant"u8);
                writer.WriteBooleanValue(BlockSubscriptionsLeavingTenant.Value);
            }
            if (Optional.IsDefined(BlockSubscriptionsIntoTenant))
            {
                writer.WritePropertyName("blockSubscriptionsIntoTenant"u8);
                writer.WriteBooleanValue(BlockSubscriptionsIntoTenant.Value);
            }
            if (Optional.IsCollectionDefined(ExemptedPrincipals))
            {
                writer.WritePropertyName("exemptedPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in ExemptedPrincipals)
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

        TenantPolicyProperties IJsonModel<TenantPolicyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TenantPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TenantPolicyProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTenantPolicyProperties(document.RootElement, options);
        }

        internal static TenantPolicyProperties DeserializeTenantPolicyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string policyId = default;
            bool? blockSubscriptionsLeavingTenant = default;
            bool? blockSubscriptionsIntoTenant = default;
            IReadOnlyList<Guid> exemptedPrincipals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blockSubscriptionsLeavingTenant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSubscriptionsLeavingTenant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("blockSubscriptionsIntoTenant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSubscriptionsIntoTenant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exemptedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    exemptedPrincipals = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TenantPolicyProperties(policyId, blockSubscriptionsLeavingTenant, blockSubscriptionsIntoTenant, exemptedPrincipals ?? new ChangeTrackingList<Guid>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TenantPolicyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TenantPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TenantPolicyProperties)} does not support '{options.Format}' format.");
            }
        }

        TenantPolicyProperties IPersistableModel<TenantPolicyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TenantPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTenantPolicyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TenantPolicyProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TenantPolicyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
