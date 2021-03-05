// <copyright file="GitHubRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System;

namespace HenryMigo.Shared.Models
{
    /// <summary>
    /// GitHubRepo model.
    /// </summary>
    public partial class GitHubRepo
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets NodeId.
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets FullName.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo is private.
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// Gets or sets Owner.
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Gets or sets HtmlUrl.
        /// </summary>
        public Uri HtmlUrl { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public object Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo can be forked.
        /// </summary>
        public bool Fork { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets ForksUrl.
        /// </summary>
        public Uri ForksUrl { get; set; }

        /// <summary>
        /// Gets or sets KeysUrl.
        /// </summary>
        public string KeysUrl { get; set; }

        /// <summary>
        /// Gets or sets CollaboratorsUrl.
        /// </summary>
        public string CollaboratorsUrl { get; set; }

        /// <summary>
        /// Gets or sets TeamsUrl.
        /// </summary>
        public Uri TeamsUrl { get; set; }

        /// <summary>
        /// Gets or sets HooksUrl.
        /// </summary>
        public Uri HooksUrl { get; set; }

        /// <summary>
        /// Gets or sets IssueEventsUrl.
        /// </summary>
        public string IssueEventsUrl { get; set; }

        /// <summary>
        /// Gets or sets EventsUrl.
        /// </summary>
        public Uri EventsUrl { get; set; }

        /// <summary>
        /// Gets or sets AssigneesUrl.
        /// </summary>
        public string AssigneesUrl { get; set; }

        /// <summary>
        /// Gets or sets BranchesUrl.
        /// </summary>
        public string BranchesUrl { get; set; }

        /// <summary>
        /// Gets or sets TagsUrl.
        /// </summary>
        public Uri TagsUrl { get; set; }

        /// <summary>
        /// Gets or sets BlobsUrl.
        /// </summary>
        public string BlobsUrl { get; set; }

        /// <summary>
        /// Gets or sets GitTagsUrl.
        /// </summary>
        public string GitTagsUrl { get; set; }

        /// <summary>
        /// Gets or sets GitRefsUrl.
        /// </summary>
        public string GitRefsUrl { get; set; }

        /// <summary>
        /// Gets or sets TreesUrl.
        /// </summary>
        public string TreesUrl { get; set; }

        /// <summary>
        /// Gets or sets StatusesUrl.
        /// </summary>
        public string StatusesUrl { get; set; }

        /// <summary>
        /// Gets or sets LanguagesUrl.
        /// </summary>
        public Uri LanguagesUrl { get; set; }

        /// <summary>
        /// Gets or sets StargazersUrl.
        /// </summary>
        public Uri StargazersUrl { get; set; }

        /// <summary>
        /// Gets or sets ContributorsUrl.
        /// </summary>
        public Uri ContributorsUrl { get; set; }

        /// <summary>
        /// Gets or sets SubscribersUrl.
        /// </summary>
        public Uri SubscribersUrl { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionUrl.
        /// </summary>
        public Uri SubscriptionUrl { get; set; }

        /// <summary>
        /// Gets or sets CommitsUrl.
        /// </summary>
        public string CommitsUrl { get; set; }

        /// <summary>
        /// Gets or sets GitCommitsUrl.
        /// </summary>
        public string GitCommitsUrl { get; set; }

        /// <summary>
        /// Gets or sets CommentsUrl.
        /// </summary>
        public string CommentsUrl { get; set; }

        /// <summary>
        /// Gets or sets IssueCommentUrl.
        /// </summary>
        public string IssueCommentUrl { get; set; }

        /// <summary>
        /// Gets or sets ContentsUrl.
        /// </summary>
        public string ContentsUrl { get; set; }

        /// <summary>
        /// Gets or sets CompareUrl.
        /// </summary>
        public string CompareUrl { get; set; }

        /// <summary>
        /// Gets or sets MergesUrl.
        /// </summary>
        public Uri MergesUrl { get; set; }

        /// <summary>
        /// Gets or sets ArchiveUrl.
        /// </summary>
        public string ArchiveUrl { get; set; }

        /// <summary>
        /// Gets or sets DownloadsUrl.
        /// </summary>
        public Uri DownloadsUrl { get; set; }

        /// <summary>
        /// Gets or sets IssuesUrl.
        /// </summary>
        public string IssuesUrl { get; set; }

        /// <summary>
        /// Gets or sets PullsUrl.
        /// </summary>
        public string PullsUrl { get; set; }

        /// <summary>
        /// Gets or sets MilestonesUrl.
        /// </summary>
        public string MilestonesUrl { get; set; }

        /// <summary>
        /// Gets or sets NotificationsUrl.
        /// </summary>
        public string NotificationsUrl { get; set; }

        /// <summary>
        /// Gets or sets LabelsUrl.
        /// </summary>
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Gets or sets ReleasesUrl.
        /// </summary>
        public string ReleasesUrl { get; set; }

        /// <summary>
        /// Gets or sets DeploymentsUrl.
        /// </summary>
        public Uri DeploymentsUrl { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets PushedAt.
        /// </summary>
        public DateTimeOffset PushedAt { get; set; }

        /// <summary>
        /// Gets or sets GitUrl.
        /// </summary>
        public string GitUrl { get; set; }

        /// <summary>
        /// Gets or sets SshUrl.
        /// </summary>
        public string SshUrl { get; set; }

        /// <summary>
        /// Gets or sets CloneUrl.
        /// </summary>
        public Uri CloneUrl { get; set; }

        /// <summary>
        /// Gets or sets SvnUrl.
        /// </summary>
        public Uri SvnUrl { get; set; }

        /// <summary>
        /// Gets or sets Homepage.
        /// </summary>
        public object Homepage { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets StargazersCount.
        /// </summary>
        public long StargazersCount { get; set; }

        /// <summary>
        /// Gets or sets WatchersCount.
        /// </summary>
        public long WatchersCount { get; set; }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo has issues.
        /// </summary>
        public bool HasIssues { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo has projects.
        /// </summary>
        public bool HasProjects { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo has downloads.
        /// </summary>
        public bool HasDownloads { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo has wiki.
        /// </summary>
        public bool HasWiki { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo has pages.
        /// </summary>
        public bool HasPages { get; set; }

        /// <summary>
        /// Gets or sets ForksCount.
        /// </summary>
        public long ForksCount { get; set; }

        /// <summary>
        /// Gets or sets MirrorUrl.
        /// </summary>
        public object MirrorUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo is archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repo is disabled.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets OpenIssuesCount.
        /// </summary>
        public long OpenIssuesCount { get; set; }

        /// <summary>
        /// Gets or sets License.
        /// </summary>
        public object License { get; set; }

        /// <summary>
        /// Gets or sets Forks.
        /// </summary>
        public long Forks { get; set; }

        /// <summary>
        /// Gets or sets OpenIssues.
        /// </summary>
        public long OpenIssues { get; set; }

        /// <summary>
        /// Gets or sets Watchers.
        /// </summary>
        public long Watchers { get; set; }

        /// <summary>
        /// Gets or sets DefaultBranch.
        /// </summary>
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Gets or sets Permissions.
        /// </summary>
        public Permissions Permissions { get; set; }
    }
}
