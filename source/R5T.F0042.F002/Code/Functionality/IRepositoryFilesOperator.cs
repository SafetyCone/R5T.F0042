using System;

using R5T.T0132;


namespace R5T.F0042.F002
{
	[FunctionalityMarker]
	public partial interface IRepositoryFilesOperator : IFunctionalityMarker
	{
        /// <summary>
        /// Creates a .gitignore file in the repository, erroring if the file already exists.
        /// </summary>
        /// <returns>The file path of the created gitignore file.</returns>
        public string Create_GitIgnoreFile_NonIdempotent(string repositoryDirectoryPath)
        {
            var sourceGitIgnoreFilePath = Instances.TemplateFilePaths.GitIgnoreTemplateFile;
            var destinationGitIgnoreFilePath = Instances.RepositoryPathsOperator.GetGitIgnoreFilePath(repositoryDirectoryPath);

            Instances.FileSystemOperator.CopyFile_OverwriteForbidden(
                sourceGitIgnoreFilePath,
                destinationGitIgnoreFilePath);

            return destinationGitIgnoreFilePath;
        }

        /// <summary>
        /// Sets the .gitignore file for the repository (overwriting any existing file).
        /// </summary>
        /// <inheritdoc cref="Create_GitIgnoreFile_NonIdempotent(string)" path="/returns"/>
        public string Set_GitIgnoreFile(string repositoryDirectoryPath)
        {
            var sourceGitIgnoreFilePath = Instances.TemplateFilePaths.GitIgnoreTemplateFile;
            var destinationGitIgnoreFilePath = Instances.RepositoryPathsOperator.GetGitIgnoreFilePath(repositoryDirectoryPath);

            Instances.FileSystemOperator.CopyFile_OverwriteAllowed(
                sourceGitIgnoreFilePath,
                destinationGitIgnoreFilePath);

            return destinationGitIgnoreFilePath;
        }
    }
}