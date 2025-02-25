// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for starting data flow debug session. </summary>
    public partial class DataFlowDebugPackage
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowDebugPackage"/>. </summary>
        public DataFlowDebugPackage()
        {
            DataFlows = new ChangeTrackingList<DataFlowDebugResource>();
            Datasets = new ChangeTrackingList<DatasetDebugResource>();
            LinkedServices = new ChangeTrackingList<LinkedServiceDebugResource>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugPackage"/>. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlow"> Data flow instance. </param>
        /// <param name="dataFlows"> List of Data flows. </param>
        /// <param name="datasets"> List of datasets. </param>
        /// <param name="linkedServices"> List of linked services. </param>
        /// <param name="staging"> Staging info for debug session. </param>
        /// <param name="debugSettings"> Data flow debug settings. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFlowDebugPackage(string sessionId, DataFlowDebugResource dataFlow, IList<DataFlowDebugResource> dataFlows, IList<DatasetDebugResource> datasets, IList<LinkedServiceDebugResource> linkedServices, DataFlowStagingInfo staging, DataFlowDebugPackageDebugSettings debugSettings, IDictionary<string, object> additionalProperties)
        {
            SessionId = sessionId;
            DataFlow = dataFlow;
            DataFlows = dataFlows;
            Datasets = datasets;
            LinkedServices = linkedServices;
            Staging = staging;
            DebugSettings = debugSettings;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> Data flow instance. </summary>
        public DataFlowDebugResource DataFlow { get; set; }
        /// <summary> List of Data flows. </summary>
        public IList<DataFlowDebugResource> DataFlows { get; }
        /// <summary> List of datasets. </summary>
        public IList<DatasetDebugResource> Datasets { get; }
        /// <summary> List of linked services. </summary>
        public IList<LinkedServiceDebugResource> LinkedServices { get; }
        /// <summary> Staging info for debug session. </summary>
        public DataFlowStagingInfo Staging { get; set; }
        /// <summary> Data flow debug settings. </summary>
        public DataFlowDebugPackageDebugSettings DebugSettings { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
