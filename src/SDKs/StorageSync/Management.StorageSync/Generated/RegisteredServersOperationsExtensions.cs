// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RegisteredServersOperations.
    /// </summary>
    public static partial class RegisteredServersOperationsExtensions
    {
            /// <summary>
            /// Get a given registered server list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            public static IEnumerable<RegisteredServer> ListByStorageSyncService(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName)
            {
                return operations.ListByStorageSyncServiceAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a given registered server list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RegisteredServer>> ListByStorageSyncServiceAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByStorageSyncServiceWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            public static RegisteredServer Get(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId)
            {
                return operations.GetAsync(resourceGroupName, storageSyncServiceName, serverId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegisteredServer> GetAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, serverId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a new registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='parameters'>
            /// Body of Registered Server object.
            /// </param>
            public static RegisteredServer Create(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, RegisteredServerCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, storageSyncServiceName, serverId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a new registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='parameters'>
            /// Body of Registered Server object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegisteredServer> CreateAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, RegisteredServerCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, serverId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            public static RegisteredServersDeleteHeaders Delete(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId)
            {
                return operations.DeleteAsync(resourceGroupName, storageSyncServiceName, serverId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegisteredServersDeleteHeaders> DeleteAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, serverId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Add a new registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='parameters'>
            /// Body of Registered Server object.
            /// </param>
            public static RegisteredServer BeginCreate(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, RegisteredServerCreateParameters parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, storageSyncServiceName, serverId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a new registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='parameters'>
            /// Body of Registered Server object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegisteredServer> BeginCreateAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, RegisteredServerCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, serverId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            public static RegisteredServersDeleteHeaders BeginDelete(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId)
            {
                return operations.BeginDeleteAsync(resourceGroupName, storageSyncServiceName, serverId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the given registered server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='serverId'>
            /// GUID identifying the on-premises server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegisteredServersDeleteHeaders> BeginDeleteAsync(this IRegisteredServersOperations operations, string resourceGroupName, string storageSyncServiceName, string serverId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, serverId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
