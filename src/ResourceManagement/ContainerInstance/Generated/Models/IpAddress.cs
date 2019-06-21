// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IP address for the container group.
    /// </summary>
    public partial class IpAddress
    {
        /// <summary>
        /// Initializes a new instance of the IpAddress class.
        /// </summary>
        public IpAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpAddress class.
        /// </summary>
        /// <param name="ports">The list of ports exposed on the container
        /// group.</param>
        /// <param name="type">Specifies if the IP is exposed to the public
        /// internet or private VNET. Possible values include: 'Public',
        /// 'Private'</param>
        /// <param name="ip">The IP exposed to the public internet.</param>
        /// <param name="dnsNameLabel">The Dns name label for the IP.</param>
        /// <param name="fqdn">The FQDN for the IP.</param>
        public IpAddress(IList<Port> ports, string type, string ip = default(string), string dnsNameLabel = default(string), string fqdn = default(string))
        {
            Ports = ports;
            Type = type;
            Ip = ip;
            DnsNameLabel = dnsNameLabel;
            Fqdn = fqdn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of ports exposed on the container group.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<Port> Ports { get; set; }

        /// <summary>
        /// Gets or sets specifies if the IP is exposed to the public internet
        /// or private VNET. Possible values include: 'Public', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the IP exposed to the public internet.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the Dns name label for the IP.
        /// </summary>
        [JsonProperty(PropertyName = "dnsNameLabel")]
        public string DnsNameLabel { get; set; }

        /// <summary>
        /// Gets the FQDN for the IP.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Ports == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ports");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Ports != null)
            {
                foreach (var element in Ports)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
