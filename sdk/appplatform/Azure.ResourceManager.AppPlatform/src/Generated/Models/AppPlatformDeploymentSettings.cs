// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Deployment settings payload. </summary>
    public partial class AppPlatformDeploymentSettings
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

        /// <summary> Initializes a new instance of <see cref="AppPlatformDeploymentSettings"/>. </summary>
        public AppPlatformDeploymentSettings()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            AddonConfigs = new ChangeTrackingDictionary<string, IDictionary<string, BinaryData>>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformDeploymentSettings"/>. </summary>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the required CPU and Memory, the old field cpu and memoryInGB will be deprecated later. </param>
        /// <param name="environmentVariables"> Collection of environment variables. </param>
        /// <param name="addonConfigs"> Collection of addons. </param>
        /// <param name="livenessProbe"> Periodic probe of App Instance liveness. App Instance will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </param>
        /// <param name="readinessProbe"> Periodic probe of App Instance service readiness. App Instance will be removed from service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </param>
        /// <param name="startupProbe"> StartupProbe indicates that the App Instance has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a App Instance's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </param>
        /// <param name="terminationGracePeriodInSeconds"> Optional duration in seconds the App Instance needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the App Instance are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 90 seconds. </param>
        /// <param name="containerProbeSettings"> Container liveness and readiness probe settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformDeploymentSettings(AppPlatformDeploymentResourceRequirements resourceRequests, IDictionary<string, string> environmentVariables, IDictionary<string, IDictionary<string, BinaryData>> addonConfigs, AppInstanceProbe livenessProbe, AppInstanceProbe readinessProbe, AppInstanceProbe startupProbe, int? terminationGracePeriodInSeconds, ContainerProbeSettings containerProbeSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceRequests = resourceRequests;
            EnvironmentVariables = environmentVariables;
            AddonConfigs = addonConfigs;
            LivenessProbe = livenessProbe;
            ReadinessProbe = readinessProbe;
            StartupProbe = startupProbe;
            TerminationGracePeriodInSeconds = terminationGracePeriodInSeconds;
            ContainerProbeSettings = containerProbeSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the required CPU and Memory, the old field cpu and memoryInGB will be deprecated later. </summary>
        public AppPlatformDeploymentResourceRequirements ResourceRequests { get; set; }
        /// <summary> Collection of environment variables. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        /// <summary> Collection of addons. </summary>
        public IDictionary<string, IDictionary<string, BinaryData>> AddonConfigs { get; }
        /// <summary> Periodic probe of App Instance liveness. App Instance will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </summary>
        public AppInstanceProbe LivenessProbe { get; set; }
        /// <summary> Periodic probe of App Instance service readiness. App Instance will be removed from service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </summary>
        public AppInstanceProbe ReadinessProbe { get; set; }
        /// <summary> StartupProbe indicates that the App Instance has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a App Instance's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes. </summary>
        public AppInstanceProbe StartupProbe { get; set; }
        /// <summary> Optional duration in seconds the App Instance needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the App Instance are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 90 seconds. </summary>
        public int? TerminationGracePeriodInSeconds { get; set; }
        /// <summary> Container liveness and readiness probe settings. </summary>
        internal ContainerProbeSettings ContainerProbeSettings { get; set; }
        /// <summary> Indicates whether disable the liveness and readiness probe. </summary>
        public bool? IsProbeDisabled
        {
            get => ContainerProbeSettings is null ? default : ContainerProbeSettings.IsProbeDisabled;
            set
            {
                if (ContainerProbeSettings is null)
                    ContainerProbeSettings = new ContainerProbeSettings();
                ContainerProbeSettings.IsProbeDisabled = value;
            }
        }
    }
}
