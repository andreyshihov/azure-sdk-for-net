// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// An Activity Log Alert rule condition that is met when all its member conditions are met.
    /// Each condition can be of one of the following types:
    /// __Important__: Each type has its unique subset of properties. Properties from different types CANNOT exist in one condition.
    ///    * __Leaf Condition -__ must contain 'field' and either 'equals' or 'containsAny'.
    ///   _Please note, 'anyOf' should __not__ be set in a Leaf Condition._
    ///   * __AnyOf Condition -__ must contain __only__ 'anyOf' (which is an array of Leaf Conditions).
    ///   _Please note, 'field', 'equals' and 'containsAny' should __not__ be set in an AnyOf Condition._
    ///
    /// </summary>
    public partial class ActivityLogAlertAnyOfOrLeafCondition : AlertRuleLeafCondition
    {
        /// <summary> Initializes a new instance of <see cref="ActivityLogAlertAnyOfOrLeafCondition"/>. </summary>
        public ActivityLogAlertAnyOfOrLeafCondition()
        {
            AnyOf = new ChangeTrackingList<AlertRuleLeafCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="ActivityLogAlertAnyOfOrLeafCondition"/>. </summary>
        /// <param name="field">
        /// The name of the Activity Log event's field that this condition will examine.
        /// The possible values for this field are (case-insensitive): 'resourceId', 'category', 'caller', 'level', 'operationName', 'resourceGroup', 'resourceProvider', 'status', 'subStatus', 'resourceType', or anything beginning with 'properties'.
        /// </param>
        /// <param name="equalsValue"> The value of the event's field will be compared to this value (case-insensitive) to determine if the condition is met. </param>
        /// <param name="containsAny"> The value of the event's field will be compared to the values in this array (case-insensitive) to determine if the condition is met. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="anyOf"> An Activity Log Alert rule condition that is met when at least one of its member leaf conditions are met. </param>
        internal ActivityLogAlertAnyOfOrLeafCondition(string field, string equalsValue, IList<string> containsAny, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<AlertRuleLeafCondition> anyOf) : base(field, equalsValue, containsAny, serializedAdditionalRawData)
        {
            AnyOf = anyOf;
        }

        /// <summary> An Activity Log Alert rule condition that is met when at least one of its member leaf conditions are met. </summary>
        public IList<AlertRuleLeafCondition> AnyOf { get; }
    }
}
