// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedServicesRegistrationResource"/> and their operations.
    /// Each <see cref="ManagedServicesRegistrationResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="ManagedServicesRegistrationCollection"/> instance call the GetManagedServicesRegistrations method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class ManagedServicesRegistrationCollection : ArmCollection, IEnumerable<ManagedServicesRegistrationResource>, IAsyncEnumerable<ManagedServicesRegistrationResource>
    {
        private readonly ClientDiagnostics _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics;
        private readonly RegistrationDefinitionsRestOperations _managedServicesRegistrationRegistrationDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesRegistrationCollection"/> class for mocking. </summary>
        protected ManagedServicesRegistrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesRegistrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedServicesRegistrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServices", ManagedServicesRegistrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedServicesRegistrationResource.ResourceType, out string managedServicesRegistrationRegistrationDefinitionsApiVersion);
            _managedServicesRegistrationRegistrationDefinitionsRestClient = new RegistrationDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedServicesRegistrationRegistrationDefinitionsApiVersion);
        }

        /// <summary>
        /// Creates or updates a registration definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="data"> The parameters required to create a new registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedServicesRegistrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string registrationId, ManagedServicesRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateOrUpdateAsync(Id, registrationId, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServicesArmOperation<ManagedServicesRegistrationResource>(new ManagedServicesRegistrationOperationSource(Client), _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics, Pipeline, _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateCreateOrUpdateRequest(Id, registrationId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a registration definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="data"> The parameters required to create a new registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedServicesRegistrationResource> CreateOrUpdate(WaitUntil waitUntil, string registrationId, ManagedServicesRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateOrUpdate(Id, registrationId, data, cancellationToken);
                var operation = new ManagedServicesArmOperation<ManagedServicesRegistrationResource>(new ManagedServicesRegistrationOperationSource(Client), _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics, Pipeline, _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateCreateOrUpdateRequest(Id, registrationId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual async Task<Response<ManagedServicesRegistrationResource>> GetAsync(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationRegistrationDefinitionsRestClient.GetAsync(Id, registrationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual Response<ManagedServicesRegistrationResource> Get(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationRegistrationDefinitionsRestClient.Get(Id, registrationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of the registration definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter query parameter to filter managed services resources by. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedServicesRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedServicesRegistrationResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateListRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedServicesRegistrationResource(Client, ManagedServicesRegistrationData.DeserializeManagedServicesRegistrationData(e)), _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics, Pipeline, "ManagedServicesRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of the registration definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter query parameter to filter managed services resources by. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedServicesRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedServicesRegistrationResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateListRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedServicesRegistrationRegistrationDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedServicesRegistrationResource(Client, ManagedServicesRegistrationData.DeserializeManagedServicesRegistrationData(e)), _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics, Pipeline, "ManagedServicesRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationRegistrationDefinitionsRestClient.GetAsync(Id, registrationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual Response<bool> Exists(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationRegistrationDefinitionsRestClient.Get(Id, registrationId, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedServicesRegistrationResource>> GetIfExistsAsync(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationRegistrationDefinitionsRestClient.GetAsync(Id, registrationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedServicesRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedServicesRegistrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        public virtual NullableResponse<ManagedServicesRegistrationResource> GetIfExists(string registrationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(registrationId, nameof(registrationId));

            using var scope = _managedServicesRegistrationRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationRegistrationDefinitionsRestClient.Get(Id, registrationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedServicesRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedServicesRegistrationResource> IEnumerable<ManagedServicesRegistrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedServicesRegistrationResource> IAsyncEnumerable<ManagedServicesRegistrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
