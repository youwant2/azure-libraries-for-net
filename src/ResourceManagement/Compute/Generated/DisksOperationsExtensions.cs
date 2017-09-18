// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DisksOperations.
    /// </summary>
    public static partial class DisksOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='disk'>
            /// Disk object supplied in the body of the Put disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskInner> CreateOrUpdateAsync(this IDisksOperations operations, string resourceGroupName, string diskName, DiskInner disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskName, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates (patches) a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='disk'>
            /// Disk object supplied in the body of the Patch disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskInner> UpdateAsync(this IDisksOperations operations, string resourceGroupName, string diskName, DiskUpdateInner disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, diskName, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskInner> GetAsync(this IDisksOperations operations, string resourceGroupName, string diskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, diskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> DeleteAsync(this IDisksOperations operations, string resourceGroupName, string diskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, diskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the disks under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskInner>> ListByResourceGroupAsync(this IDisksOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the disks under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskInner>> ListAsync(this IDisksOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants access to a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get disk access operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessUriInner> GrantAccessAsync(this IDisksOperations operations, string resourceGroupName, string diskName, GrantAccessDataInner grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GrantAccessWithHttpMessagesAsync(resourceGroupName, diskName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Revokes access to a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> RevokeAccessAsync(this IDisksOperations operations, string resourceGroupName, string diskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RevokeAccessWithHttpMessagesAsync(resourceGroupName, diskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='disk'>
            /// Disk object supplied in the body of the Put disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskInner> BeginCreateOrUpdateAsync(this IDisksOperations operations, string resourceGroupName, string diskName, DiskInner disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskName, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates (patches) a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='disk'>
            /// Disk object supplied in the body of the Patch disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskInner> BeginUpdateAsync(this IDisksOperations operations, string resourceGroupName, string diskName, DiskUpdateInner disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, diskName, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> BeginDeleteAsync(this IDisksOperations operations, string resourceGroupName, string diskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, diskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants access to a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get disk access operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessUriInner> BeginGrantAccessAsync(this IDisksOperations operations, string resourceGroupName, string diskName, GrantAccessDataInner grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGrantAccessWithHttpMessagesAsync(resourceGroupName, diskName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Revokes access to a disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='diskName'>
            /// The name of the disk within the given subscription and resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> BeginRevokeAccessAsync(this IDisksOperations operations, string resourceGroupName, string diskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRevokeAccessWithHttpMessagesAsync(resourceGroupName, diskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the disks under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskInner>> ListByResourceGroupNextAsync(this IDisksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the disks under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskInner>> ListNextAsync(this IDisksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
