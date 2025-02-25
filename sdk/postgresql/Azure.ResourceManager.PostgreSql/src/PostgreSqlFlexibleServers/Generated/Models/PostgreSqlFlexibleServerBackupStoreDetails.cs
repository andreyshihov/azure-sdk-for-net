// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Details about the target where the backup content will be stored. </summary>
    public partial class PostgreSqlFlexibleServerBackupStoreDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/>. </summary>
        /// <param name="sasUriList"> List of SAS uri of storage containers where backup data is to be streamed/copied. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUriList"/> is null. </exception>
        public PostgreSqlFlexibleServerBackupStoreDetails(IEnumerable<string> sasUriList)
        {
            Argument.AssertNotNull(sasUriList, nameof(sasUriList));

            SasUriList = sasUriList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/>. </summary>
        /// <param name="sasUriList"> List of SAS uri of storage containers where backup data is to be streamed/copied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerBackupStoreDetails(IList<string> sasUriList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasUriList = sasUriList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerBackupStoreDetails()
        {
        }

        /// <summary> List of SAS uri of storage containers where backup data is to be streamed/copied. </summary>
        public IList<string> SasUriList { get; }
    }
}
