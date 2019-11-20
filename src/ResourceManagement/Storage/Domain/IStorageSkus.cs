// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using Microsoft.Azure.Management.Storage.Fluent.Models;

namespace Microsoft.Azure.Management.Storage.Fluent
{
    /// <summary>
    /// Entry point to storage service SKUs.
    /// </summary>
    public interface IStorageSkus :
        ResourceManager.Fluent.Core.IBeta,
        ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<SkuInformation>,
        ResourceManager.Fluent.Core.IHasInner<ISkusOperations>,
        ResourceManager.Fluent.Core.IHasManager<IStorageManager>
    {
    }
}