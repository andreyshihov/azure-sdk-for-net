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

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing a collection of <see cref="LabUserResource"/> and their operations.
    /// Each <see cref="LabUserResource"/> in the collection will belong to the same instance of <see cref="LabResource"/>.
    /// To get a <see cref="LabUserCollection"/> instance call the GetLabUsers method from an instance of <see cref="LabResource"/>.
    /// </summary>
    public partial class LabUserCollection : ArmCollection, IEnumerable<LabUserResource>, IAsyncEnumerable<LabUserResource>
    {
        private readonly ClientDiagnostics _labUserUsersClientDiagnostics;
        private readonly UsersRestOperations _labUserUsersRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabUserCollection"/> class for mocking. </summary>
        protected LabUserCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabUserCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabUserCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labUserUsersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", LabUserResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabUserResource.ResourceType, out string labUserUsersApiVersion);
            _labUserUsersRestClient = new UsersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labUserUsersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Operation to create or update a lab user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabUserResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string userName, LabUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labUserUsersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabUserResource>(new LabUserOperationSource(Client), _labUserUsersClientDiagnostics, Pipeline, _labUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Operation to create or update a lab user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabUserResource> CreateOrUpdate(WaitUntil waitUntil, string userName, LabUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labUserUsersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, data, cancellationToken);
                var operation = new LabServicesArmOperation<LabUserResource>(new LabUserOperationSource(Client), _labUserUsersClientDiagnostics, Pipeline, _labUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Returns the properties of a lab user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual async Task<Response<LabUserResource>> GetAsync(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.Get");
            scope.Start();
            try
            {
                var response = await _labUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties of a lab user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual Response<LabUserResource> Get(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.Get");
            scope.Start();
            try
            {
                var response = _labUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all users for a lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_ListByLab</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabUserResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _labUserUsersRestClient.CreateListByLabRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _labUserUsersRestClient.CreateListByLabNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LabUserResource(Client, LabUserData.DeserializeLabUserData(e)), _labUserUsersClientDiagnostics, Pipeline, "LabUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of all users for a lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_ListByLab</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabUserResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _labUserUsersRestClient.CreateListByLabRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _labUserUsersRestClient.CreateListByLabNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LabUserResource(Client, LabUserData.DeserializeLabUserData(e)), _labUserUsersClientDiagnostics, Pipeline, "LabUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual Response<bool> Exists(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.Exists");
            scope.Start();
            try
            {
                var response = _labUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual async Task<NullableResponse<LabUserResource>> GetIfExistsAsync(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _labUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LabUserResource>(response.GetRawResponse());
                return Response.FromValue(new LabUserResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        public virtual NullableResponse<LabUserResource> GetIfExists(string userName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userName, nameof(userName));

            using var scope = _labUserUsersClientDiagnostics.CreateScope("LabUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _labUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LabUserResource>(response.GetRawResponse());
                return Response.FromValue(new LabUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabUserResource> IEnumerable<LabUserResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabUserResource> IAsyncEnumerable<LabUserResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
