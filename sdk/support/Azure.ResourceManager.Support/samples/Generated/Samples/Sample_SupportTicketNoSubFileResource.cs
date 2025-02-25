// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Support;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SupportTicketNoSubFileResource
    {
        // Get details of a subscription file
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfASubscriptionFile()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/GetFileDetails.json
            // this example is just showing the usage of "FilesNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubFileResource created on azure
            // for more information of creating SupportTicketNoSubFileResource, please refer to the document of SupportTicketNoSubFileResource
            string fileWorkspaceName = "testworkspace";
            string fileName = "test.txt";
            ResourceIdentifier supportTicketNoSubFileResourceId = SupportTicketNoSubFileResource.CreateResourceIdentifier(fileWorkspaceName, fileName);
            SupportTicketNoSubFileResource supportTicketNoSubFile = client.GetSupportTicketNoSubFileResource(supportTicketNoSubFileResourceId);

            // invoke the operation
            SupportTicketNoSubFileResource result = await supportTicketNoSubFile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportFileDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a file workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/CreateFile.json
            // this example is just showing the usage of "FilesNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubFileResource created on azure
            // for more information of creating SupportTicketNoSubFileResource, please refer to the document of SupportTicketNoSubFileResource
            string fileWorkspaceName = "testworkspace";
            string fileName = "test.txt";
            ResourceIdentifier supportTicketNoSubFileResourceId = SupportTicketNoSubFileResource.CreateResourceIdentifier(fileWorkspaceName, fileName);
            SupportTicketNoSubFileResource supportTicketNoSubFile = client.GetSupportTicketNoSubFileResource(supportTicketNoSubFileResourceId);

            // invoke the operation
            SupportFileDetailData data = new SupportFileDetailData()
            {
                ChunkSize = 41423,
                FileSize = 41423,
                NumberOfChunks = 1,
            };
            ArmOperation<SupportTicketNoSubFileResource> lro = await supportTicketNoSubFile.UpdateAsync(WaitUntil.Completed, data);
            SupportTicketNoSubFileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportFileDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UploadFile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Upload_UploadFile()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/UploadFile.json
            // this example is just showing the usage of "FilesNoSubscription_Upload" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubFileResource created on azure
            // for more information of creating SupportTicketNoSubFileResource, please refer to the document of SupportTicketNoSubFileResource
            string fileWorkspaceName = "testworkspaceName";
            string fileName = "test.txt";
            ResourceIdentifier supportTicketNoSubFileResourceId = SupportTicketNoSubFileResource.CreateResourceIdentifier(fileWorkspaceName, fileName);
            SupportTicketNoSubFileResource supportTicketNoSubFile = client.GetSupportTicketNoSubFileResource(supportTicketNoSubFileResourceId);

            // invoke the operation
            UploadFileContent content = new UploadFileContent()
            {
                Content = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAMAAAAoLQ9TAAAABGdBTUEAALGPC/xhBQAAAAFzUkdCAK7OHOkAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABd",
                ChunkIndex = 0,
            };
            await supportTicketNoSubFile.UploadAsync(content);

            Console.WriteLine($"Succeeded");
        }
    }
}
