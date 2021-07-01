﻿// <copyright file="StorageClientFactory.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Common.Clients
{
    using System;
    using global::Azure.Core;
    using global::Azure.Storage.Blobs;
    using Microsoft.Extensions.Options;
    using Microsoft.Teams.Apps.DIConnect.Common.Repositories;

    /// <summary>
    /// Storage client factory.
    /// </summary>
    public class StorageClientFactory : IStorageClientFactory
    {
        private readonly string storageConnectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageClientFactory"/> class.
        /// </summary>
        /// <param name="repositoryOptions">User data repository.</param>
        public StorageClientFactory(IOptions<RepositoryOptions> repositoryOptions)
        {
            this.storageConnectionString = repositoryOptions.Value.StorageAccountConnectionString;
        }

        /// <inheritdoc/>
        public BlobContainerClient CreateBlobContainerClient()
        {
            var options = new BlobClientOptions();

            // configure retries
            options.Retry.MaxRetries = 5; // default is 3
            options.Retry.Mode = RetryMode.Exponential; // default is fixed retry policy
            options.Retry.Delay = TimeSpan.FromSeconds(1); // default is 0.8s

            return new BlobContainerClient(
                this.storageConnectionString,
                Constants.BlobContainerName,
                options);
        }
    }
}
