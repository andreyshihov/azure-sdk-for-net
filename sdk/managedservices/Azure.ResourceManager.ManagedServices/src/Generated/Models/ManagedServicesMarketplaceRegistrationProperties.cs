// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The properties of the marketplace registration definition. </summary>
    public partial class ManagedServicesMarketplaceRegistrationProperties
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

        /// <summary> Initializes a new instance of <see cref="ManagedServicesMarketplaceRegistrationProperties"/>. </summary>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizations"/> is null. </exception>
        internal ManagedServicesMarketplaceRegistrationProperties(Guid managedByTenantId, IEnumerable<ManagedServicesAuthorization> authorizations)
        {
            Argument.AssertNotNull(authorizations, nameof(authorizations));

            ManagedByTenantId = managedByTenantId;
            Authorizations = authorizations.ToList();
            EligibleAuthorizations = new ChangeTrackingList<ManagedServicesEligibleAuthorization>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesMarketplaceRegistrationProperties"/>. </summary>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="offerDisplayName"> The marketplace offer display name. </param>
        /// <param name="publisherDisplayName"> The marketplace publisher display name. </param>
        /// <param name="planDisplayName"> The marketplace plan display name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesMarketplaceRegistrationProperties(Guid managedByTenantId, IReadOnlyList<ManagedServicesAuthorization> authorizations, IReadOnlyList<ManagedServicesEligibleAuthorization> eligibleAuthorizations, string offerDisplayName, string publisherDisplayName, string planDisplayName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManagedByTenantId = managedByTenantId;
            Authorizations = authorizations;
            EligibleAuthorizations = eligibleAuthorizations;
            OfferDisplayName = offerDisplayName;
            PublisherDisplayName = publisherDisplayName;
            PlanDisplayName = planDisplayName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesMarketplaceRegistrationProperties"/> for deserialization. </summary>
        internal ManagedServicesMarketplaceRegistrationProperties()
        {
        }

        /// <summary> The identifier of the managedBy tenant. </summary>
        public Guid ManagedByTenantId { get; }
        /// <summary> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<ManagedServicesAuthorization> Authorizations { get; }
        /// <summary> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<ManagedServicesEligibleAuthorization> EligibleAuthorizations { get; }
        /// <summary> The marketplace offer display name. </summary>
        public string OfferDisplayName { get; }
        /// <summary> The marketplace publisher display name. </summary>
        public string PublisherDisplayName { get; }
        /// <summary> The marketplace plan display name. </summary>
        public string PlanDisplayName { get; }
    }
}
