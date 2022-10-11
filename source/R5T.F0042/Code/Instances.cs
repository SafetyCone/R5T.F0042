using System;

using R5T.F0041;
using R5T.F0046;
using R5T.F0057;


namespace R5T.F0042
{
    public static class Instances
    {
        public static ICommitMessages CommitMessages { get; } = F0042.CommitMessages.Instance;
        public static IDirectoryNames DirectoryNames { get; } = F0042.DirectoryNames.Instance;
        public static IRepositoryDirectoryPathOperator RepositoryDirectoryPathOperator { get; } = F0057.RepositoryDirectoryPathOperator.Instance;
        public static IDirectoryPaths DirectoryPaths { get; } = F0042.DirectoryPaths.Instance;
        public static F0002.IExecutablePathOperator ExecutablePathOperator { get; } = F0002.ExecutablePathOperator.Instance;
        public static IFileNames FileNames { get; } = F0042.FileNames.Instance;
        public static F0002.IFileSystemOperator FileSystemOperator { get; } = F0002.FileSystemOperator.Instance;
        public static IGitHubOperator GitHubOperator { get; } = F0041.GitHubOperator.Instance;
        public static IGitOperator GitOperator { get; } = F0041.GitOperator.Instance;
        public static ILocalRepositoryOperator LocalRepositoryOperator { get; } = F0042.LocalRepositoryOperator.Instance;
        public static F0002.IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static IRemoteRepositoryOperator RemoteRepositoryOperator { get; } = F0042.RemoteRepositoryOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = F0046.RepositoryNameOperator.Instance;
        public static F0041.IRepositoryOperator OctokitRepositoryOperator { get; } = F0041.RepositoryOperator.Instance;
        public static IRepositoryPathsOperator RepositoryPathsOperator { get; } = F0042.RepositoryPathsOperator.Instance;
        public static ITemplateFilePaths TemplateFilePaths { get; } = F0042.TemplateFilePaths.Instance;
    }
}