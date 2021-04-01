// <copyright file="Owner.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System;

namespace HenryMigo.Shared.Models
{
    /// <summary>
    /// Owner class.
    /// </summary>
    public partial class Owner
    {
        /// <summary>
        /// Gets or sets login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets NodeId.
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets AvatarUrl.
        /// </summary>
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Gets or sets GravatarId.
        /// </summary>
        public string GravatarId { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets HtmlUrl.
        /// </summary>
        public Uri HtmlUrl { get; set; }

        /// <summary>
        /// Gets or sets FollowersUrl.
        /// </summary>
        public Uri FollowersUrl { get; set; }

        /// <summary>
        /// Gets or sets FollowingUrl.
        /// </summary>
        public string FollowingUrl { get; set; }

        /// <summary>
        /// Gets or sets GistsUrl.
        /// </summary>
        public string GistsUrl { get; set; }

        /// <summary>
        /// Gets or sets StarredUrl.
        /// </summary>
        public string StarredUrl { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionsUrl.
        /// </summary>
        public Uri SubscriptionsUrl { get; set; }

        /// <summary>
        /// Gets or sets OrganizationsUrl.
        /// </summary>
        public Uri OrganizationsUrl { get; set; }

        /// <summary>
        /// Gets or sets ReposUrl.
        /// </summary>
        public Uri ReposUrl { get; set; }

        /// <summary>
        /// Gets or sets EventsUrl.
        /// </summary>
        public string EventsUrl { get; set; }

        /// <summary>
        /// Gets or sets ReceivedEventsUrl.
        /// </summary>
        public Uri ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the person is site admin.
        /// </summary>
        public bool SiteAdmin { get; set; }
    }
}
