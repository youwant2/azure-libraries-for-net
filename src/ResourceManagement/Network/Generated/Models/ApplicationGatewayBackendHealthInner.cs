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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of ApplicationGatewayBackendHealthPool resources.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthInner class.
        /// </summary>
        public ApplicationGatewayBackendHealthInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthInner class.
        /// </summary>
        public ApplicationGatewayBackendHealthInner(IList<ApplicationGatewayBackendHealthPool> backendAddressPools = default(IList<ApplicationGatewayBackendHealthPool>))
        {
            BackendAddressPools = backendAddressPools;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPools")]
        public IList<ApplicationGatewayBackendHealthPool> BackendAddressPools { get; set; }

    }
}
