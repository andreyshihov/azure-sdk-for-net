// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A class representing a collection of <see cref="SenderUsernameResource"/> and their operations.
    /// Each <see cref="SenderUsernameResource"/> in the collection will belong to the same instance of <see cref="CommunicationDomainResource"/>.
    /// To get a <see cref="SenderUsernameResourceCollection"/> instance call the GetSenderUsernameResources method from an instance of <see cref="CommunicationDomainResource"/>.
    /// </summary>
    public partial class SenderUsernameResourceCollection : ArmCollection, IEnumerable<SenderUsernameResource>, IAsyncEnumerable<SenderUsernameResource>
    {
        private readonly ClientDiagnostics _senderUsernameResourceSenderUsernamesClientDiagnostics;
        private readonly SenderUsernamesRestOperations _senderUsernameResourceSenderUsernamesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SenderUsernameResourceCollection"/> class for mocking. </summary>
        protected SenderUsernameResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SenderUsernameResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SenderUsernameResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _senderUsernameResourceSenderUsernamesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", SenderUsernameResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SenderUsernameResource.ResourceType, out string senderUsernameResourceSenderUsernamesApiVersion);
            _senderUsernameResourceSenderUsernamesRestClient = new SenderUsernamesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, senderUsernameResourceSenderUsernamesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CommunicationDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CommunicationDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add a new SenderUsername resource under the parent Domains resource or update an existing SenderUsername resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SenderUsernameResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string senderUsername, SenderUsernameResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _senderUsernameResourceSenderUsernamesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<SenderUsernameResource>(Response.FromValue(new SenderUsernameResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a new SenderUsername resource under the parent Domains resource or update an existing SenderUsername resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SenderUsernameResource> CreateOrUpdate(WaitUntil waitUntil, string senderUsername, SenderUsernameResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _senderUsernameResourceSenderUsernamesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, data, cancellationToken);
                var operation = new CommunicationArmOperation<SenderUsernameResource>(Response.FromValue(new SenderUsernameResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a valid sender username for a domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual async Task<Response<SenderUsernameResource>> GetAsync(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _senderUsernameResourceSenderUsernamesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SenderUsernameResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a valid sender username for a domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual Response<SenderUsernameResource> Get(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _senderUsernameResourceSenderUsernamesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SenderUsernameResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all valid sender usernames for a domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_ListByDomains</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SenderUsernameResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SenderUsernameResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _senderUsernameResourceSenderUsernamesRestClient.CreateListByDomainsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _senderUsernameResourceSenderUsernamesRestClient.CreateListByDomainsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SenderUsernameResource(Client, SenderUsernameResourceData.DeserializeSenderUsernameResourceData(e)), _senderUsernameResourceSenderUsernamesClientDiagnostics, Pipeline, "SenderUsernameResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all valid sender usernames for a domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_ListByDomains</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SenderUsernameResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SenderUsernameResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _senderUsernameResourceSenderUsernamesRestClient.CreateListByDomainsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _senderUsernameResourceSenderUsernamesRestClient.CreateListByDomainsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SenderUsernameResource(Client, SenderUsernameResourceData.DeserializeSenderUsernameResourceData(e)), _senderUsernameResourceSenderUsernamesClientDiagnostics, Pipeline, "SenderUsernameResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _senderUsernameResourceSenderUsernamesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual Response<bool> Exists(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _senderUsernameResourceSenderUsernamesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual async Task<NullableResponse<SenderUsernameResource>> GetIfExistsAsync(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _senderUsernameResourceSenderUsernamesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SenderUsernameResource>(response.GetRawResponse());
                return Response.FromValue(new SenderUsernameResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/senderUsernames/{senderUsername}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SenderUsernames_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SenderUsernameResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="senderUsername"> The valid sender Username. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="senderUsername"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="senderUsername"/> is null. </exception>
        public virtual NullableResponse<SenderUsernameResource> GetIfExists(string senderUsername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(senderUsername, nameof(senderUsername));

            using var scope = _senderUsernameResourceSenderUsernamesClientDiagnostics.CreateScope("SenderUsernameResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _senderUsernameResourceSenderUsernamesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, senderUsername, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SenderUsernameResource>(response.GetRawResponse());
                return Response.FromValue(new SenderUsernameResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SenderUsernameResource> IEnumerable<SenderUsernameResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SenderUsernameResource> IAsyncEnumerable<SenderUsernameResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
