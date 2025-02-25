// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Contains configuration options specific to the scalar quantization compression method used during indexing and querying. </summary>
    public partial class ScalarQuantizationCompressionConfiguration : VectorSearchCompressionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ScalarQuantizationCompressionConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScalarQuantizationCompressionConfiguration(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = VectorSearchCompressionKind.ScalarQuantization;
        }

        /// <summary> Initializes a new instance of <see cref="ScalarQuantizationCompressionConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of compression method being configured for use with vector search. </param>
        /// <param name="rerankWithOriginalVectors"> If set to true, once the ordered set of results calculated using compressed vectors are obtained, they will be reranked again by recalculating the full-precision similarity scores. This will improve recall at the expense of latency. </param>
        /// <param name="defaultOversampling"> Default oversampling factor. Oversampling will internally request more documents (specified by this multiplier) in the initial search. This increases the set of results that will be reranked using recomputed similarity scores from full-precision vectors. Minimum value is 1, meaning no oversampling (1x). This parameter can only be set when rerankWithOriginalVectors is true. Higher values improve recall at the expense of latency. </param>
        /// <param name="parameters"> Contains the parameters specific to Scalar Quantization. </param>
        internal ScalarQuantizationCompressionConfiguration(string name, VectorSearchCompressionKind kind, bool? rerankWithOriginalVectors, double? defaultOversampling, ScalarQuantizationParameters parameters) : base(name, kind, rerankWithOriginalVectors, defaultOversampling)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Contains the parameters specific to Scalar Quantization. </summary>
        public ScalarQuantizationParameters Parameters { get; set; }
    }
}
