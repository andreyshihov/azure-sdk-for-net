// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.IoT.Hub.Service;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DeviceCapabilities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsIotEdgeDevice))
            {
                writer.WritePropertyName("iotEdge"u8);
                writer.WriteBooleanValue(IsIotEdgeDevice.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceCapabilities DeserializeDeviceCapabilities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? iotEdge = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iotEdge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iotEdge = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DeviceCapabilities(iotEdge);
        }
    }
}
