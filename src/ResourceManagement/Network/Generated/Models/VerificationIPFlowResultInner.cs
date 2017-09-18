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
    using System.Linq;

    /// <summary>
    /// Results of IP flow verification on the target resource.
    /// </summary>
    public partial class VerificationIPFlowResultInner
    {
        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowResultInner
        /// class.
        /// </summary>
        public VerificationIPFlowResultInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowResultInner
        /// class.
        /// </summary>
        /// <param name="access">Indicates whether the traffic is allowed or
        /// denied. Possible values include: 'Allow', 'Deny'</param>
        /// <param name="ruleName">Name of the rule. If input is not matched
        /// against any security rule, it is not displayed.</param>
        public VerificationIPFlowResultInner(string access = default(string), string ruleName = default(string))
        {
            Access = access;
            RuleName = ruleName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether the traffic is allowed or denied.
        /// Possible values include: 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets name of the rule. If input is not matched against any
        /// security rule, it is not displayed.
        /// </summary>
        [JsonProperty(PropertyName = "ruleName")]
        public string RuleName { get; set; }

    }
}
