// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Storage.Fluent
{
    /// <summary>
    /// An immutable client-side representation of a private endpoint connection resource in Azure storage account.
    /// </summary>
    public interface IPrivateEndpointConnection
    {
        /// <summary>
        /// Gets the resource of private end point.
        /// </summary>
        Models.PrivateEndpoint PrivateEndpoint { get; }

        /// <summary>
        /// Gets a collection of information about the state of the
        /// connection between service consumer and provider.
        /// </summary>
        Models.PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; }

        /// <summary>
        /// Gets the provisioning state of the private endpoint
        /// connection resource. Possible values include: 'Succeeded',
        /// 'Creating', 'Deleting', 'Failed'
        /// </summary>
        Models.PrivateEndpointConnectionProvisioningState ProvisioningState { get; }
    }
}
