// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHDInsightContainersModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Containers.HDInsightClusterPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="deploymentId"> A unique id generated by the RP to identify the resource. </param>
        /// <param name="managedResourceGroupName"> A resource group created by RP, to hold the resources created by RP on-behalf of customers. It will also be used to generate aksManagedResourceGroupName by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. Please make sure it meets resource group name restriction. </param>
        /// <param name="aksManagedResourceGroupName"> A resource group created by AKS, to hold the infrastructure resources created by AKS on-behalf of customers. It is generated by cluster pool name and managed resource group name by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. </param>
        /// <param name="clusterPoolVersion"> CLuster pool profile. </param>
        /// <param name="computeProfile"> CLuster pool compute profile. </param>
        /// <param name="aksClusterProfile"> Properties of underlying AKS cluster. </param>
        /// <param name="networkSubnetId"> Cluster pool network profile. </param>
        /// <param name="logAnalyticsProfile"> Cluster pool log analytics profile to enable OMS agent for AKS cluster. </param>
        /// <param name="status"> Business status of the resource. </param>
        /// <returns> A new <see cref="Containers.HDInsightClusterPoolData"/> instance for mocking. </returns>
        public static HDInsightClusterPoolData HDInsightClusterPoolData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HDInsightProvisioningStatus? provisioningState = null, string deploymentId = null, string managedResourceGroupName = null, string aksManagedResourceGroupName = null, string clusterPoolVersion = null, ClusterPoolComputeProfile computeProfile = null, AksClusterProfile aksClusterProfile = null, ResourceIdentifier networkSubnetId = null, ClusterPoolLogAnalyticsProfile logAnalyticsProfile = null, string status = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HDInsightClusterPoolData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                provisioningState,
                deploymentId,
                managedResourceGroupName,
                aksManagedResourceGroupName,
                clusterPoolVersion != null ? new ClusterPoolProfile(clusterPoolVersion, serializedAdditionalRawData: null) : null,
                computeProfile,
                aksClusterProfile,
                networkSubnetId != null ? new ClusterPoolNetworkProfile(networkSubnetId, serializedAdditionalRawData: null) : null,
                logAnalyticsProfile,
                status,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterPoolComputeProfile"/>. </summary>
        /// <param name="vmSize"> The virtual machine SKU. </param>
        /// <param name="count"> The number of virtual machines. </param>
        /// <returns> A new <see cref="Models.ClusterPoolComputeProfile"/> instance for mocking. </returns>
        public static ClusterPoolComputeProfile ClusterPoolComputeProfile(string vmSize = null, int? count = null)
        {
            return new ClusterPoolComputeProfile(vmSize, count, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AksClusterProfile"/>. </summary>
        /// <param name="aksClusterResourceId"> ARM Resource ID of the AKS cluster. </param>
        /// <param name="aksClusterAgentPoolIdentityProfile"> Identity properties of the AKS cluster agentpool MSI. </param>
        /// <param name="aksVersion"> AKS control plane and default node pool version of this ClusterPool. </param>
        /// <returns> A new <see cref="Models.AksClusterProfile"/> instance for mocking. </returns>
        public static AksClusterProfile AksClusterProfile(ResourceIdentifier aksClusterResourceId = null, HDInsightIdentityProfile aksClusterAgentPoolIdentityProfile = null, string aksVersion = null)
        {
            return new AksClusterProfile(aksClusterResourceId, aksClusterAgentPoolIdentityProfile, aksVersion, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Containers.HDInsightClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="clusterType"> The type of cluster. </param>
        /// <param name="deploymentId"> A unique id generated by the RP to identify the resource. </param>
        /// <param name="computeNodes"> The compute profile. </param>
        /// <param name="clusterProfile"> Cluster profile. </param>
        /// <param name="status"> Business status of the resource. </param>
        /// <returns> A new <see cref="Containers.HDInsightClusterData"/> instance for mocking. </returns>
        public static HDInsightClusterData HDInsightClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, HDInsightProvisioningStatus? provisioningState = null, string clusterType = null, string deploymentId = null, IEnumerable<ClusterComputeNodeProfile> computeNodes = null, ClusterProfile clusterProfile = null, string status = null)
        {
            tags ??= new Dictionary<string, string>();
            computeNodes ??= new List<ClusterComputeNodeProfile>();

            return new HDInsightClusterData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                provisioningState,
                clusterType,
                deploymentId,
                computeNodes != null ? new ComputeProfile(computeNodes?.ToList(), serializedAdditionalRawData: null) : null,
                clusterProfile,
                status,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterProfile"/>. </summary>
        /// <param name="clusterVersion"> Version with 3/4 part. </param>
        /// <param name="ossVersion"> Version with three part. </param>
        /// <param name="components"> Component list of this cluster type and version. </param>
        /// <param name="identityProfile"> Identity Profile with details of an MSI. </param>
        /// <param name="authorizationProfile"> Authorization profile with details of AAD user Ids and group Ids authorized for data plane access. </param>
        /// <param name="secretsProfile"> The cluster secret profile. </param>
        /// <param name="serviceConfigsProfiles"> The service configs profiles. </param>
        /// <param name="connectivityProfile"> Cluster connectivity profile. </param>
        /// <param name="logAnalyticsProfile"> Cluster log analytics profile to enable or disable OMS agent for cluster. </param>
        /// <param name="isEnabled"> Cluster Prometheus profile. </param>
        /// <param name="sshProfile"> Ssh profile for the cluster. </param>
        /// <param name="autoscaleProfile"> This is the Autoscale profile for the cluster. This will allow customer to create cluster enabled with Autoscale. </param>
        /// <param name="kafkaProfile"> Kafka cluster profile. </param>
        /// <param name="trinoProfile"> Trino Cluster profile. </param>
        /// <param name="llapProfile"> LLAP cluster profile. </param>
        /// <param name="flinkProfile"> The Flink cluster profile. </param>
        /// <param name="sparkProfile"> The spark cluster profile. </param>
        /// <param name="stubProfile"> Stub cluster profile. </param>
        /// <param name="scriptActionProfiles"> The script action profile list. </param>
        /// <returns> A new <see cref="Models.ClusterProfile"/> instance for mocking. </returns>
        public static ClusterProfile ClusterProfile(string clusterVersion = null, string ossVersion = null, IEnumerable<ClusterComponentItem> components = null, HDInsightIdentityProfile identityProfile = null, AuthorizationProfile authorizationProfile = null, ClusterSecretsProfile secretsProfile = null, IEnumerable<ClusterServiceConfigsProfile> serviceConfigsProfiles = null, ClusterConnectivityProfile connectivityProfile = null, ClusterLogAnalyticsProfile logAnalyticsProfile = null, bool? isEnabled = null, ClusterSshProfile sshProfile = null, ClusterAutoscaleProfile autoscaleProfile = null, IDictionary<string, BinaryData> kafkaProfile = null, TrinoProfile trinoProfile = null, IDictionary<string, BinaryData> llapProfile = null, FlinkProfile flinkProfile = null, SparkProfile sparkProfile = null, IDictionary<string, BinaryData> stubProfile = null, IEnumerable<ScriptActionProfile> scriptActionProfiles = null)
        {
            components ??= new List<ClusterComponentItem>();
            serviceConfigsProfiles ??= new List<ClusterServiceConfigsProfile>();
            kafkaProfile ??= new Dictionary<string, BinaryData>();
            llapProfile ??= new Dictionary<string, BinaryData>();
            stubProfile ??= new Dictionary<string, BinaryData>();
            scriptActionProfiles ??= new List<ScriptActionProfile>();

            return new ClusterProfile(
                clusterVersion,
                ossVersion,
                components?.ToList(),
                identityProfile,
                authorizationProfile,
                secretsProfile,
                serviceConfigsProfiles?.ToList(),
                connectivityProfile,
                logAnalyticsProfile,
                isEnabled.HasValue ? new ClusterPrometheusProfile(isEnabled.Value, serializedAdditionalRawData: null) : null,
                sshProfile,
                autoscaleProfile,
                kafkaProfile,
                trinoProfile,
                llapProfile,
                flinkProfile,
                sparkProfile,
                stubProfile,
                scriptActionProfiles?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterComponentItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <returns> A new <see cref="Models.ClusterComponentItem"/> instance for mocking. </returns>
        public static ClusterComponentItem ClusterComponentItem(string name = null, string version = null)
        {
            return new ClusterComponentItem(name, version, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterConnectivityProfile"/>. </summary>
        /// <param name="webFqdn"> Web connectivity endpoint details. </param>
        /// <param name="ssh"> List of SSH connectivity endpoints. </param>
        /// <returns> A new <see cref="Models.ClusterConnectivityProfile"/> instance for mocking. </returns>
        public static ClusterConnectivityProfile ClusterConnectivityProfile(string webFqdn = null, IEnumerable<SshConnectivityEndpoint> ssh = null)
        {
            ssh ??= new List<SshConnectivityEndpoint>();

            return new ClusterConnectivityProfile(webFqdn != null ? new WebConnectivityEndpoint(webFqdn, serializedAdditionalRawData: null) : null, ssh?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SshConnectivityEndpoint"/>. </summary>
        /// <param name="endpoint"> SSH connectivity endpoint. </param>
        /// <returns> A new <see cref="Models.SshConnectivityEndpoint"/> instance for mocking. </returns>
        public static SshConnectivityEndpoint SshConnectivityEndpoint(string endpoint = null)
        {
            return new SshConnectivityEndpoint(endpoint, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterSshProfile"/>. </summary>
        /// <param name="count"> Number of ssh pods per cluster. </param>
        /// <param name="podPrefix"> Prefix of the pod names. Pod number will be appended to the prefix. The ingress URLs for the pods will be available at &lt;clusterFqdn&gt;/&lt;sshBasePath&gt;/&lt;prefix&gt;-&lt;number&gt;. </param>
        /// <returns> A new <see cref="Models.ClusterSshProfile"/> instance for mocking. </returns>
        public static ClusterSshProfile ClusterSshProfile(int count = default, string podPrefix = null)
        {
            return new ClusterSshProfile(count, podPrefix, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterResizeContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="targetWorkerNodeCount"> Target node count of worker node. </param>
        /// <returns> A new <see cref="Models.ClusterResizeContent"/> instance for mocking. </returns>
        public static ClusterResizeContent ClusterResizeContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? targetWorkerNodeCount = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ClusterResizeContent(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                targetWorkerNodeCount,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HDInsightClusterPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="clusterProfile"> Cluster resource patch properties. </param>
        /// <returns> A new <see cref="Models.HDInsightClusterPatch"/> instance for mocking. </returns>
        public static HDInsightClusterPatch HDInsightClusterPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, UpdatableClusterProfile clusterProfile = null)
        {
            tags ??= new Dictionary<string, string>();

            return new HDInsightClusterPatch(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                clusterProfile,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterJob"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of cluster job.
        /// Please note <see cref="ClusterJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.FlinkJobProperties"/>.
        /// </param>
        /// <returns> A new <see cref="Models.ClusterJob"/> instance for mocking. </returns>
        public static ClusterJob ClusterJob(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ClusterJobProperties properties = null)
        {
            return new ClusterJob(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterServiceConfigResult"/>. </summary>
        /// <param name="serviceName"> Service Config Name. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="content"> Content in the service config file. </param>
        /// <param name="componentName"> Component Name. </param>
        /// <param name="serviceConfigListResultPropertiesType"> Config type. </param>
        /// <param name="path"> Config file path. </param>
        /// <param name="customKeys"> The custom keys. </param>
        /// <param name="defaultKeys"> The default keys. </param>
        /// <returns> A new <see cref="Models.ClusterServiceConfigResult"/> instance for mocking. </returns>
        public static ClusterServiceConfigResult ClusterServiceConfigResult(string serviceName = null, string fileName = null, string content = null, string componentName = null, string serviceConfigListResultPropertiesType = null, string path = null, IReadOnlyDictionary<string, string> customKeys = null, IReadOnlyDictionary<string, ClusterServiceConfigValueEntity> defaultKeys = null)
        {
            customKeys ??= new Dictionary<string, string>();
            defaultKeys ??= new Dictionary<string, ClusterServiceConfigValueEntity>();

            return new ClusterServiceConfigResult(
                serviceName,
                fileName,
                content,
                componentName,
                serviceConfigListResultPropertiesType,
                path,
                customKeys,
                defaultKeys,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterServiceConfigValueEntity"/>. </summary>
        /// <param name="value"> Config value. </param>
        /// <param name="description"> Config description. </param>
        /// <returns> A new <see cref="Models.ClusterServiceConfigValueEntity"/> instance for mocking. </returns>
        public static ClusterServiceConfigValueEntity ClusterServiceConfigValueEntity(string value = null, string description = null)
        {
            return new ClusterServiceConfigValueEntity(value, description, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HDInsightNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicator of availability of the Microsoft.HDInsight resource name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The error message of unavailability. </param>
        /// <returns> A new <see cref="Models.HDInsightNameAvailabilityResult"/> instance for mocking. </returns>
        public static HDInsightNameAvailabilityResult HDInsightNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new HDInsightNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterInstanceViewResult"/>. </summary>
        /// <param name="name"> Name of the instance view. </param>
        /// <param name="status"> Status of the instance view. </param>
        /// <param name="serviceStatuses"> List of statuses of relevant services that make up the HDInsight on aks cluster to surface to the customer. </param>
        /// <returns> A new <see cref="Models.ClusterInstanceViewResult"/> instance for mocking. </returns>
        public static ClusterInstanceViewResult ClusterInstanceViewResult(string name = null, ClusterInstanceViewStatus status = null, IEnumerable<HDInsightServiceStatus> serviceStatuses = null)
        {
            serviceStatuses ??= new List<HDInsightServiceStatus>();

            return new ClusterInstanceViewResult(name, status, serviceStatuses?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterInstanceViewStatus"/>. </summary>
        /// <param name="ready"> The cluster ready status. </param>
        /// <param name="reason"> The status reason. </param>
        /// <param name="message"> The additional message. </param>
        /// <returns> A new <see cref="Models.ClusterInstanceViewStatus"/> instance for mocking. </returns>
        public static ClusterInstanceViewStatus ClusterInstanceViewStatus(string ready = null, string reason = null, string message = null)
        {
            return new ClusterInstanceViewStatus(ready, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HDInsightServiceStatus"/>. </summary>
        /// <param name="kind"> Kind of the service. E.g. "Zookeeper". </param>
        /// <param name="ready"> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </param>
        /// <param name="message"> A message describing the error if any. </param>
        /// <returns> A new <see cref="Models.HDInsightServiceStatus"/> instance for mocking. </returns>
        public static HDInsightServiceStatus HDInsightServiceStatus(string kind = null, string ready = null, string message = null)
        {
            return new HDInsightServiceStatus(kind, ready, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterPoolVersion"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterPoolVersionValue"> Cluster pool version is a 2-part version. </param>
        /// <param name="aksVersion"> AKS version. </param>
        /// <param name="isPreview"> Indicate if this version is in preview or not. </param>
        /// <returns> A new <see cref="Models.ClusterPoolVersion"/> instance for mocking. </returns>
        public static ClusterPoolVersion ClusterPoolVersion(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string clusterPoolVersionValue = null, string aksVersion = null, bool? isPreview = null)
        {
            return new ClusterPoolVersion(
                id,
                name,
                resourceType,
                systemData,
                clusterPoolVersionValue,
                aksVersion,
                isPreview,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HDInsightClusterVersion"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterType"> The type of cluster. </param>
        /// <param name="clusterVersion"> Version with three part. </param>
        /// <param name="ossVersion"> Version with three part. </param>
        /// <param name="clusterPoolVersion"> The two part cluster pool version. If the cluster version is before cluster pool version on-board, the return value will be empty string. </param>
        /// <param name="isPreview"> Indicate if this version is in preview or not. </param>
        /// <param name="components"> Component list of this cluster type and version. </param>
        /// <returns> A new <see cref="Models.HDInsightClusterVersion"/> instance for mocking. </returns>
        public static HDInsightClusterVersion HDInsightClusterVersion(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string clusterType = null, string clusterVersion = null, string ossVersion = null, string clusterPoolVersion = null, bool? isPreview = null, IEnumerable<ClusterComponentItem> components = null)
        {
            components ??= new List<ClusterComponentItem>();

            return new HDInsightClusterVersion(
                id,
                name,
                resourceType,
                systemData,
                clusterType,
                clusterVersion,
                ossVersion,
                clusterPoolVersion,
                isPreview,
                components?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FlinkJobProperties"/>. </summary>
        /// <param name="jobName"> Name of job. </param>
        /// <param name="jobJarDirectory"> A string property that specifies the directory where the job JAR is located. </param>
        /// <param name="jarName"> A string property that represents the name of the job JAR. </param>
        /// <param name="entryClass"> A string property that specifies the entry class for the Flink job. </param>
        /// <param name="args"> A string property representing additional JVM arguments for the Flink job. It should be space separated value. </param>
        /// <param name="savePointName"> A string property that represents the name of the savepoint for the Flink job. </param>
        /// <param name="action"> A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values =&gt; NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE. </param>
        /// <param name="flinkConfiguration"> Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory. It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well. </param>
        /// <param name="jobId"> Unique id for identifying a job. </param>
        /// <param name="status"> Status of job. </param>
        /// <param name="jobOutput"> Output of job. </param>
        /// <param name="actionResult"> Action result of job. </param>
        /// <param name="lastSavePoint"> The last savepoint. </param>
        /// <returns> A new <see cref="Models.FlinkJobProperties"/> instance for mocking. </returns>
        public static FlinkJobProperties FlinkJobProperties(string jobName = null, string jobJarDirectory = null, string jarName = null, string entryClass = null, string args = null, string savePointName = null, FlinkJobAction? action = null, IDictionary<string, string> flinkConfiguration = null, string jobId = null, string status = null, string jobOutput = null, string actionResult = null, string lastSavePoint = null)
        {
            flinkConfiguration ??= new Dictionary<string, string>();

            return new FlinkJobProperties(
                ClusterJobType.FlinkJob,
                serializedAdditionalRawData: null,
                jobName,
                jobJarDirectory,
                jarName,
                entryClass,
                args,
                savePointName,
                action,
                flinkConfiguration,
                jobId,
                status,
                jobOutput,
                actionResult,
                lastSavePoint);
        }
    }
}
