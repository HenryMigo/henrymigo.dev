// <copyright file="Permissions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenryMigo.Shared.Models
{
    /// <summary>
    /// Permissions clas.
    /// </summary>
    public partial class Permissions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the person is admin.
        /// </summary>
        public bool Admin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the person can push.
        /// </summary>
        public bool Push { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the person can pull.
        /// </summary>
        public bool Pull { get; set; }
    }
}
