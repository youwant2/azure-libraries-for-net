// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSL certificates of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewaySslCertificateInner : Microsoft.Azure.Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewaySslCertificateInner class.
        /// </summary>
        public ApplicationGatewaySslCertificateInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewaySslCertificateInner class.
        /// </summary>
        /// <param name="data">Base-64 encoded pfx certificate. Only applicable
        /// in PUT Request.</param>
        /// <param name="password">Password for the pfx file specified in data.
        /// Only applicable in PUT request.</param>
        /// <param name="publicCertData">Base-64 encoded Public cert data
        /// corresponding to pfx specified in data. Only applicable in GET
        /// request.</param>
        /// <param name="provisioningState">Provisioning state of the SSL
        /// certificate resource Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewaySslCertificateInner(string id = default(string), string data = default(string), string password = default(string), string publicCertData = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Data = data;
            Password = password;
            PublicCertData = publicCertData;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base-64 encoded pfx certificate. Only applicable in
        /// PUT Request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets password for the pfx file specified in data. Only
        /// applicable in PUT request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets base-64 encoded Public cert data corresponding to pfx
        /// specified in data. Only applicable in GET request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicCertData")]
        public string PublicCertData { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the SSL certificate resource
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
