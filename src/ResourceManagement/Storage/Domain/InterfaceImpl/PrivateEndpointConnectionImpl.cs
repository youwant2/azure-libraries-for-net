// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Storage.Fluent
{
    internal partial class PrivateEndpointConnectionImpl
    {
        /// <summary>
        /// Gets the resource of private end point.
        /// </summary>
        Models.PrivateEndpoint IPrivateEndpointConnection.PrivateEndpoint
        {
            get
            {
                return PrivateEndpoint();
            }
        }

        /// <summary>
        /// Gets a collection of information about the state of the
        /// connection between service consumer and provider.
        /// </summary>
        Models.PrivateLinkServiceConnectionState IPrivateEndpointConnection.PrivateLinkServiceConnectionState
        {
            get
            {
                return PrivateLinkServiceConnectionState();
            }
        }

        /// <summary>
        /// Gets the provisioning state of the private endpoint
        /// connection resource. Possible values include: 'Succeeded',
        /// 'Creating', 'Deleting', 'Failed'
        /// </summary>
        Models.PrivateEndpointConnectionProvisioningState IPrivateEndpointConnection.ProvisioningState
        {
            get
            {
                return ProvisioningState();
            }
        }
    }
}
