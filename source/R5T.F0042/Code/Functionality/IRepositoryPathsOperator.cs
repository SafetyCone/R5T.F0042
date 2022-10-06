using System;

using R5T.T0132;


namespace R5T.F0042
{
	[FunctionalityMarker]
	public partial interface IRepositoryPathsOperator : IFunctionalityMarker
	{
		public string GetGitIgnoreFilePath(string repositoryDirectoryPath)
        {
			var gitIgnoreFilePath = Instances.PathOperator.GetFilePath(
				repositoryDirectoryPath,
				Instances.FileNames.GitIgnore);

			return gitIgnoreFilePath;
		}

		public string GetLicenseFilePath(string repositoryDirectoryPath)
        {
			var licenseFilePath = Instances.PathOperator.GetFilePath(
				repositoryDirectoryPath,
				Instances.FileNames.License);

			return licenseFilePath;
		}

		public string GetSourceDirectoryPath(string repositoryDirectoryPath)
        {
			var repositorySourceDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				repositoryDirectoryPath,
				Instances.DirectoryNames.RepositorySourceDirectoryName);

			return repositorySourceDirectoryPath;
		}
	}
}