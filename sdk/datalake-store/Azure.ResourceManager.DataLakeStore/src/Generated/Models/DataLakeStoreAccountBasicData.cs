// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Basic Data Lake Store account information, returned on list calls. </summary>
    public partial class DataLakeStoreAccountBasicData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountBasicData"/>. </summary>
        internal DataLakeStoreAccountBasicData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountBasicData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accountId"> The unique identifier associated with this Data Lake Store account. </param>
        /// <param name="provisioningState"> The provisioning status of the Data Lake Store account. </param>
        /// <param name="state"> The state of the Data Lake Store account. </param>
        /// <param name="createdOn"> The account creation time. </param>
        /// <param name="lastModifiedOn"> The account last modified time. </param>
        /// <param name="endpoint"> The full CName endpoint for this account. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountBasicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? accountId, DataLakeStoreAccountStatus? provisioningState, DataLakeStoreAccountState? state, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string endpoint, AzureLocation? location, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AccountId = accountId;
            ProvisioningState = provisioningState;
            State = state;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Endpoint = endpoint;
            Location = location;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique identifier associated with this Data Lake Store account. </summary>
        public Guid? AccountId { get; }
        /// <summary> The provisioning status of the Data Lake Store account. </summary>
        public DataLakeStoreAccountStatus? ProvisioningState { get; }
        /// <summary> The state of the Data Lake Store account. </summary>
        public DataLakeStoreAccountState? State { get; }
        /// <summary> The account creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The account last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The full CName endpoint for this account. </summary>
        public string Endpoint { get; }
        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
