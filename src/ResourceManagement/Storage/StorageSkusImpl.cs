// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The implementation for  StorageSkus.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnN0b3JhZ2UuaW1wbGVtZW50YXRpb24uU3RvcmFnZVNrdXNJbXBs
    internal partial class StorageSkusImpl  :
        IStorageSkus
    {
        private readonly IStorageManager manager;

        ///GENMHASH:C852FF1A7022E39B3C33C4B996B5E6D6:226463FFB9926F982826109D59B16399
        ISkusOperations IHasInner<ISkusOperations>.Inner => this.manager.Inner.Skus;

        ///GENMHASH:9214F7412070763856E97C3FDAD23FE3:7EAB2D725263FF7A98C969FF3A63C592
        internal StorageSkusImpl(IStorageManager storageManager)
        {
            this.manager = storageManager;
        }

        ///GENMHASH:B6961E0C7CB3A9659DE0E1489F44A936:168EFDB95EECDB98D4BDFCCA32101AC1
        public IStorageManager Manager()
        {
            return this.manager;
        }

        ///GENMHASH:7D6013E8B95E991005ED921F493EFCE4:EFF74B68F06CBC4611C3EEE115E1A032
        public IEnumerable<SkuInformation> List()
        {
            return Extensions.Synchronize(() => manager.Inner.Skus.ListAsync(CancellationToken.None));
        }

        ///GENMHASH:7F5BEBF638B801886F5E13E6CCFF6A4E:11D194372CF16B8AF88A146421D05EAF
        public async Task<IPagedCollection<SkuInformation>> ListAsync(bool loadAllPages = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            var skuInformationItems = await manager.Inner.Skus.ListAsync(cancellationToken);
            return PagedCollection<SkuInformation, SkuInformation>.CreateFromEnumerable(skuInformationItems);
        }
    }
}