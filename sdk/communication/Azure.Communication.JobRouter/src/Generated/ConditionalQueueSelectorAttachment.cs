// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a set of queue selectors that will be attached if the given condition resolves to true. </summary>
    public partial class ConditionalQueueSelectorAttachment : QueueSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="ConditionalQueueSelectorAttachment"/>. </summary>
        /// <param name="condition"> The condition that must be true for the queue selectors to be attached. </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="condition"/> or <paramref name="queueSelectors"/> is null. </exception>
        internal ConditionalQueueSelectorAttachment(RouterRule condition, IEnumerable<RouterQueueSelector> queueSelectors)
        {
            Argument.AssertNotNull(condition, nameof(condition));
            Argument.AssertNotNull(queueSelectors, nameof(queueSelectors));

            Kind = QueueSelectorAttachmentKind.Conditional;
            Condition = condition;
            QueueSelectors = queueSelectors.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConditionalQueueSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="condition"> The condition that must be true for the queue selectors to be attached. </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        internal ConditionalQueueSelectorAttachment(QueueSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, RouterRule condition, IList<RouterQueueSelector> queueSelectors) : base(kind, serializedAdditionalRawData)
        {
            Condition = condition;
            QueueSelectors = queueSelectors;
        }

        /// <summary> Initializes a new instance of <see cref="ConditionalQueueSelectorAttachment"/> for deserialization. </summary>
        internal ConditionalQueueSelectorAttachment()
        {
        }

        /// <summary>
        /// The condition that must be true for the queue selectors to be attached.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </summary>
        public RouterRule Condition { get; }
    }
}
