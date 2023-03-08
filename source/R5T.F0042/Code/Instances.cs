using System;


namespace R5T.F0042
{
    public static class Instances
    {
        public static Z0036.ICommitMessages CommitMessages => Z0036.CommitMessages.Instance;
        public static IDirectoryNames DirectoryNames => F0042.DirectoryNames.Instance;
        public static F0057.IRepositoryDirectoryPathOperator RepositoryDirectoryPathOperator => F0057.RepositoryDirectoryPathOperator.Instance;
        public static IDirectoryPaths DirectoryPaths => F0042.DirectoryPaths.Instance;
        public static F0002.IExecutablePathOperator ExecutablePathOperator => F0002.ExecutablePathOperator.Instance;
        public static IFileNames FileNames => F0042.FileNames.Instance;
        public static F0002.IFileSystemOperator FileSystemOperator => F0002.FileSystemOperator.Instance;
        public static F0041.IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static F0041.IGitOperator GitOperator => F0041.GitOperator.Instance;
        public static ILocalRepositoryOperator LocalRepositoryOperator => F0042.LocalRepositoryOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IRemoteRepositoryOperator RemoteRepositoryOperator => F0042.RemoteRepositoryOperator.Instance;
        public static F0046.IRepositoryNameOperator RepositoryNameOperator => F0046.RepositoryNameOperator.Instance;
        public static F0041.IRepositoryOperator OctokitRepositoryOperator => F0041.RepositoryOperator.Instance;
        public static IRepositoryPathsOperator RepositoryPathsOperator => F0042.RepositoryPathsOperator.Instance;
        public static ITemplateFilePaths TemplateFilePaths => F0042.TemplateFilePaths.Instance;
    }
}