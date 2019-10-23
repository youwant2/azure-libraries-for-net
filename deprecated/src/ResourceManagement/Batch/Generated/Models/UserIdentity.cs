// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The definition of the user identity under which the task is run.
    /// </summary>
    /// <remarks>
    /// Specify either the userName or autoUser property, but not both.
    /// </remarks>
    public partial class UserIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserIdentity class.
        /// </summary>
        public UserIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserIdentity class.
        /// </summary>
        /// <param name="userName">The name of the user identity under which
        /// the task is run.</param>
        /// <param name="autoUser">The auto user under which the task is
        /// run.</param>
        public UserIdentity(string userName = default(string), AutoUserSpecification autoUser = default(AutoUserSpecification))
        {
            UserName = userName;
            AutoUser = autoUser;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the user identity under which the task is
        /// run.
        /// </summary>
        /// <remarks>
        /// The userName and autoUser properties are mutually exclusive; you
        /// must specify one but not both.
        /// </remarks>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the auto user under which the task is run.
        /// </summary>
        /// <remarks>
        /// The userName and autoUser properties are mutually exclusive; you
        /// must specify one but not both.
        /// </remarks>
        [JsonProperty(PropertyName = "autoUser")]
        public AutoUserSpecification AutoUser { get; set; }

    }
}