// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Base type for similarity algorithms. Similarity algorithms are used to calculate scores that tie queries to documents. The higher the score, the more relevant the document is to that specific query. Those scores are used to rank the search results. </summary>
    public partial class Similarity
    {

        /// <summary> Initializes a new instance of Similarity. </summary>
        /// <param name="oDataType"> . </param>
        internal Similarity(string oDataType)
        {
            ODataType = oDataType;
        }

        internal string ODataType { get; set; }
    }
}
