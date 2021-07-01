﻿// <copyright file="BotOptions.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Common.Services.CommonBot
{
    /// <summary>
    /// Options used for holding metadata for the bot.
    /// </summary>
    public class BotOptions
    {
        /// <summary>
        /// Gets or sets the Microsoft app ID for the user bot.
        /// </summary>
        public string UserAppId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app password for the user bot.
        /// </summary>
        public string UserAppPassword { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app ID for the author bot.
        /// </summary>
        public string AuthorAppId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app password for the author bot.
        /// </summary>
        public string AuthorAppPassword { get; set; }

        /// <summary>
        /// Gets or sets admin team id. Where team notification will be sent for approval to enable any ERG group searchable for all end users.
        /// </summary>
        public string AdminTeamId { get; set; }

        /// <summary>
        /// Gets or sets application base Uri.
        /// </summary>
        public string AppBaseUri { get; set; }

        /// <summary>
        /// Gets or sets application manifest id.
        /// </summary>
        public string ManifestId { get; set; }
    }
}