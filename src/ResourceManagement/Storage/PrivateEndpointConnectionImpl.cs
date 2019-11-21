// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Storage.Fluent.Models;

namespace Microsoft.Azure.Management.Storage.Fluent
{
    internal partial class PrivateEndpointConnectionImpl : IPrivateEndpointConnection
    {
        private readonly PrivateEndpointConnectionInner inner;

        internal PrivateEndpointConnectionImpl(PrivateEndpointConnectionInner inner)
        {
            this.inner = inner;
        }

        public PrivateEndpoint PrivateEndpoint()
        {
            return inner.PrivateEndpoint;
        }

        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState()
        {
            return inner.PrivateLinkServiceConnectionState;
        }

        public PrivateEndpointConnectionProvisioningState ProvisioningState()
        {
            return inner.ProvisioningState;
        }
    }
}
