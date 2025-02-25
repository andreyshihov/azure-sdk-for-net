// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableBillingTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableBillingTenantResource"/> class for mocking. </summary>
        protected MockableBillingTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableBillingTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableBillingTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of BillingSubscriptionResources in the TenantResource. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of BillingSubscriptionResources and their operations over a BillingSubscriptionResource. </returns>
        public virtual BillingSubscriptionCollection GetBillingSubscriptions(string billingAccountName)
        {
            return new BillingSubscriptionCollection(Client, Id, billingAccountName);
        }

        /// <summary>
        /// Gets a subscription by its ID. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="billingSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingSubscriptionResource>> GetBillingSubscriptionAsync(string billingAccountName, string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            return await GetBillingSubscriptions(billingAccountName).GetAsync(billingSubscriptionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a subscription by its ID. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="billingSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingSubscriptionResource> GetBillingSubscription(string billingAccountName, string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            return GetBillingSubscriptions(billingAccountName).Get(billingSubscriptionName, cancellationToken);
        }

        /// <summary> Gets a collection of BillingSubscriptionAliasResources in the TenantResource. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of BillingSubscriptionAliasResources and their operations over a BillingSubscriptionAliasResource. </returns>
        public virtual BillingSubscriptionAliasCollection GetBillingSubscriptionAliases(string billingAccountName)
        {
            return new BillingSubscriptionAliasCollection(Client, Id, billingAccountName);
        }

        /// <summary>
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSubscriptionAliasResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingSubscriptionAliasResource>> GetBillingSubscriptionAliasAsync(string billingAccountName, string aliasName, CancellationToken cancellationToken = default)
        {
            return await GetBillingSubscriptionAliases(billingAccountName).GetAsync(aliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a subscription by its alias ID.  The operation is supported for seat based billing subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptionAliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptionsAliases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSubscriptionAliasResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="aliasName"> The ID that uniquely identifies a subscription alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingSubscriptionAliasResource> GetBillingSubscriptionAlias(string billingAccountName, string aliasName, CancellationToken cancellationToken = default)
        {
            return GetBillingSubscriptionAliases(billingAccountName).Get(aliasName, cancellationToken);
        }

        /// <summary> Gets a collection of BillingPaymentMethodResources in the TenantResource. </summary>
        /// <returns> An object representing collection of BillingPaymentMethodResources and their operations over a BillingPaymentMethodResource. </returns>
        public virtual BillingPaymentMethodCollection GetBillingPaymentMethods()
        {
            return GetCachedClient(client => new BillingPaymentMethodCollection(client, Id));
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingPaymentMethodResource>> GetBillingPaymentMethodAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return await GetBillingPaymentMethods().GetAsync(paymentMethodName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingPaymentMethodResource> GetBillingPaymentMethod(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return GetBillingPaymentMethods().Get(paymentMethodName, cancellationToken);
        }

        /// <summary> Gets a collection of BillingAccountPaymentMethodResources in the TenantResource. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of BillingAccountPaymentMethodResources and their operations over a BillingAccountPaymentMethodResource. </returns>
        public virtual BillingAccountPaymentMethodCollection GetBillingAccountPaymentMethods(string billingAccountName)
        {
            return new BillingAccountPaymentMethodCollection(Client, Id, billingAccountName);
        }

        /// <summary>
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingAccountPaymentMethodResource>> GetBillingAccountPaymentMethodAsync(string billingAccountName, string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return await GetBillingAccountPaymentMethods(billingAccountName).GetAsync(paymentMethodName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingAccountPaymentMethodResource> GetBillingAccountPaymentMethod(string billingAccountName, string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return GetBillingAccountPaymentMethods(billingAccountName).Get(paymentMethodName, cancellationToken);
        }

        /// <summary> Gets a collection of BillingPaymentMethodLinkResources in the TenantResource. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="billingProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="billingProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of BillingPaymentMethodLinkResources and their operations over a BillingPaymentMethodLinkResource. </returns>
        public virtual BillingPaymentMethodLinkCollection GetBillingPaymentMethodLinks(string billingAccountName, string billingProfileName)
        {
            return new BillingPaymentMethodLinkCollection(Client, Id, billingAccountName, billingProfileName);
        }

        /// <summary>
        /// Gets a payment method linked with a billing profile. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/paymentMethodLinks/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/> or <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/> or <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingPaymentMethodLinkResource>> GetBillingPaymentMethodLinkAsync(string billingAccountName, string billingProfileName, string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return await GetBillingPaymentMethodLinks(billingAccountName, billingProfileName).GetAsync(paymentMethodName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a payment method linked with a billing profile. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/paymentMethodLinks/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/> or <paramref name="paymentMethodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/> or <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingPaymentMethodLinkResource> GetBillingPaymentMethodLink(string billingAccountName, string billingProfileName, string paymentMethodName, CancellationToken cancellationToken = default)
        {
            return GetBillingPaymentMethodLinks(billingAccountName, billingProfileName).Get(paymentMethodName, cancellationToken);
        }
    }
}
