// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a response to source upload request.
    /// </summary>
    public partial class SourceUploadDefinitionInner
    {
        /// <summary>
        /// Initializes a new instance of the SourceUploadDefinitionInner
        /// class.
        /// </summary>
        public SourceUploadDefinitionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceUploadDefinitionInner
        /// class.
        /// </summary>
        /// <param name="uploadUrl">The URL where the client can upload the
        /// source.</param>
        /// <param name="relativePath">The relative path to the source. This is
        /// used to submit the subsequent queue build request.</param>
        public SourceUploadDefinitionInner(string uploadUrl = default(string), string relativePath = default(string))
        {
            UploadUrl = uploadUrl;
            RelativePath = relativePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL where the client can upload the source.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUrl")]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Gets or sets the relative path to the source. This is used to
        /// submit the subsequent queue build request.
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

    }
}