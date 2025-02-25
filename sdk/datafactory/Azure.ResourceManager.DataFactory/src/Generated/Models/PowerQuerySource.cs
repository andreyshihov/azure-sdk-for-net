// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Power query source. </summary>
    public partial class PowerQuerySource : DataFlowSource
    {
        /// <summary> Initializes a new instance of <see cref="PowerQuerySource"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PowerQuerySource(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of <see cref="PowerQuerySource"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="flowlet"> Flowlet Reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="schemaLinkedService"> Schema linked service reference. </param>
        /// <param name="script"> source script. </param>
        internal PowerQuerySource(string name, string description, DatasetReference dataset, DataFactoryLinkedServiceReference linkedService, DataFlowReference flowlet, IDictionary<string, BinaryData> serializedAdditionalRawData, DataFactoryLinkedServiceReference schemaLinkedService, string script) : base(name, description, dataset, linkedService, flowlet, serializedAdditionalRawData, schemaLinkedService)
        {
            Script = script;
        }

        /// <summary> Initializes a new instance of <see cref="PowerQuerySource"/> for deserialization. </summary>
        internal PowerQuerySource()
        {
        }

        /// <summary> source script. </summary>
        public string Script { get; set; }
    }
}
