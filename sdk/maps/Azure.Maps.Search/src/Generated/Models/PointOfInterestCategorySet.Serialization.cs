// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    public partial class PointOfInterestCategorySet
    {
        internal static PointOfInterestCategorySet DeserializePointOfInterestCategorySet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
            }
            return new PointOfInterestCategorySet(id);
        }
    }
}
