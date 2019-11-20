// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Entry point for storage resource usage management API.
    /// </summary>
    public interface IUsages :
        ResourceManager.Fluent.Core.IHasInner<IUsagesOperations>,
        ResourceManager.Fluent.Core.IHasManager<IStorageManager>
    {
        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <returns>list of resources</returns>
        IEnumerable<IStorageUsage> ListByLocation(string location);

        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <returns>list of resources</returns>
        Task<IPagedCollection<IStorageUsage>> ListByLocationAsync(string location, CancellationToken cancellationToken = default(CancellationToken));
    }
}