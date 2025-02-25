// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Profile of schedule based Autoscale. </summary>
    public partial class ScheduleBasedConfig
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

        /// <summary> Initializes a new instance of <see cref="ScheduleBasedConfig"/>. </summary>
        /// <param name="timeZone"> User has to specify the timezone on which the schedule has to be set for schedule based autoscale configuration. </param>
        /// <param name="defaultCount"> Setting default node count of current schedule configuration. Default node count specifies the number of nodes which are default when an specified scaling operation is executed (scale up/scale down). </param>
        /// <param name="schedules"> This specifies the schedules where scheduled based Autoscale to be enabled, the user has a choice to set multiple rules within the schedule across days and times (start/end). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZone"/> or <paramref name="schedules"/> is null. </exception>
        public ScheduleBasedConfig(string timeZone, int defaultCount, IEnumerable<AutoscaleSchedule> schedules)
        {
            Argument.AssertNotNull(timeZone, nameof(timeZone));
            Argument.AssertNotNull(schedules, nameof(schedules));

            TimeZone = timeZone;
            DefaultCount = defaultCount;
            Schedules = schedules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ScheduleBasedConfig"/>. </summary>
        /// <param name="timeZone"> User has to specify the timezone on which the schedule has to be set for schedule based autoscale configuration. </param>
        /// <param name="defaultCount"> Setting default node count of current schedule configuration. Default node count specifies the number of nodes which are default when an specified scaling operation is executed (scale up/scale down). </param>
        /// <param name="schedules"> This specifies the schedules where scheduled based Autoscale to be enabled, the user has a choice to set multiple rules within the schedule across days and times (start/end). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduleBasedConfig(string timeZone, int defaultCount, IList<AutoscaleSchedule> schedules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeZone = timeZone;
            DefaultCount = defaultCount;
            Schedules = schedules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScheduleBasedConfig"/> for deserialization. </summary>
        internal ScheduleBasedConfig()
        {
        }

        /// <summary> User has to specify the timezone on which the schedule has to be set for schedule based autoscale configuration. </summary>
        public string TimeZone { get; set; }
        /// <summary> Setting default node count of current schedule configuration. Default node count specifies the number of nodes which are default when an specified scaling operation is executed (scale up/scale down). </summary>
        public int DefaultCount { get; set; }
        /// <summary> This specifies the schedules where scheduled based Autoscale to be enabled, the user has a choice to set multiple rules within the schedule across days and times (start/end). </summary>
        public IList<AutoscaleSchedule> Schedules { get; }
    }
}
