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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing a collection of <see cref="SphereCatalogResource"/> and their operations.
    /// Each <see cref="SphereCatalogResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SphereCatalogCollection"/> instance call the GetSphereCatalogs method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SphereCatalogCollection : ArmCollection, IEnumerable<SphereCatalogResource>, IAsyncEnumerable<SphereCatalogResource>
    {
        private readonly ClientDiagnostics _sphereCatalogCatalogsClientDiagnostics;
        private readonly CatalogsRestOperations _sphereCatalogCatalogsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SphereCatalogCollection"/> class for mocking. </summary>
        protected SphereCatalogCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereCatalogCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SphereCatalogCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereCatalogCatalogsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereCatalogResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SphereCatalogResource.ResourceType, out string sphereCatalogCatalogsApiVersion);
            _sphereCatalogCatalogsRestClient = new CatalogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereCatalogCatalogsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SphereCatalogResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string catalogName, SphereCatalogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sphereCatalogCatalogsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, catalogName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation<SphereCatalogResource>(new SphereCatalogOperationSource(Client), _sphereCatalogCatalogsClientDiagnostics, Pipeline, _sphereCatalogCatalogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, catalogName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SphereCatalogResource> CreateOrUpdate(WaitUntil waitUntil, string catalogName, SphereCatalogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sphereCatalogCatalogsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, catalogName, data, cancellationToken);
                var operation = new SphereArmOperation<SphereCatalogResource>(new SphereCatalogOperationSource(Client), _sphereCatalogCatalogsClientDiagnostics, Pipeline, _sphereCatalogCatalogsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, catalogName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual async Task<Response<SphereCatalogResource>> GetAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.Get");
            scope.Start();
            try
            {
                var response = await _sphereCatalogCatalogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCatalogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual Response<SphereCatalogResource> Get(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.Get");
            scope.Start();
            try
            {
                var response = _sphereCatalogCatalogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCatalogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Catalog resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereCatalogResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereCatalogResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereCatalogCatalogsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereCatalogCatalogsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SphereCatalogResource(Client, SphereCatalogData.DeserializeSphereCatalogData(e)), _sphereCatalogCatalogsClientDiagnostics, Pipeline, "SphereCatalogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereCatalogResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereCatalogResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereCatalogCatalogsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereCatalogCatalogsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SphereCatalogResource(Client, SphereCatalogData.DeserializeSphereCatalogData(e)), _sphereCatalogCatalogsClientDiagnostics, Pipeline, "SphereCatalogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sphereCatalogCatalogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual Response<bool> Exists(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.Exists");
            scope.Start();
            try
            {
                var response = _sphereCatalogCatalogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual async Task<NullableResponse<SphereCatalogResource>> GetIfExistsAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sphereCatalogCatalogsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SphereCatalogResource>(response.GetRawResponse());
                return Response.FromValue(new SphereCatalogResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        public virtual NullableResponse<SphereCatalogResource> GetIfExists(string catalogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(catalogName, nameof(catalogName));

            using var scope = _sphereCatalogCatalogsClientDiagnostics.CreateScope("SphereCatalogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sphereCatalogCatalogsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, catalogName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SphereCatalogResource>(response.GetRawResponse());
                return Response.FromValue(new SphereCatalogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SphereCatalogResource> IEnumerable<SphereCatalogResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SphereCatalogResource> IAsyncEnumerable<SphereCatalogResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
