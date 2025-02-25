// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Tokenizer that uses regex pattern matching to construct distinct tokens. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class PatternTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of <see cref="PatternTokenizer"/>. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PatternTokenizer(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.PatternTokenizer";
        }

        /// <summary> Initializes a new instance of <see cref="PatternTokenizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="pattern"> A regular expression pattern to match token separators. Default is an expression that matches one or more non-word characters. </param>
        /// <param name="flagsInternal"> Regular expression flags. </param>
        /// <param name="group"> The zero-based ordinal of the matching group in the regular expression pattern to extract into tokens. Use -1 if you want to use the entire pattern to split the input into tokens, irrespective of matching groups. Default is -1. </param>
        internal PatternTokenizer(string oDataType, string name, string pattern, string flagsInternal, int? group) : base(oDataType, name)
        {
            Pattern = pattern;
            FlagsInternal = flagsInternal;
            Group = group;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.PatternTokenizer";
        }

        /// <summary> A regular expression pattern to match token separators. Default is an expression that matches one or more non-word characters. </summary>
        public string Pattern { get; set; }
        /// <summary> The zero-based ordinal of the matching group in the regular expression pattern to extract into tokens. Use -1 if you want to use the entire pattern to split the input into tokens, irrespective of matching groups. Default is -1. </summary>
        public int? Group { get; set; }
    }
}
