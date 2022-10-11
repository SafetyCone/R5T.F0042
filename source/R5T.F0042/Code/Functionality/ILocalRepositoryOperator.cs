using System;

using R5T.T0132;


namespace R5T.F0042
{
	[FunctionalityMarker]
	public partial interface ILocalRepositoryOperator : IFunctionalityMarker
	{
		public bool RepositoryExists(string repositoryOwnerName, string repositoryName)
		{
			var repositoryDirectoryPath = Instances.RepositoryDirectoryPathOperator.GetRepositoryDirectory(
				repositoryOwnerName,
				repositoryName);

			var output = this.RepositoryExists(repositoryDirectoryPath);
			return output;
		}

		public bool RepositoryExists(string repositoryDirectoryPath)
		{
			var output = Instances.FileSystemOperator.DirectoryExists(repositoryDirectoryPath);
			return output;
		}

		public void VerifyRepositoryDoesNotExist(string repositoryOwnerName, string repositoryName)
		{
			var repositoryDirectoryPath = Instances.RepositoryDirectoryPathOperator.GetRepositoryDirectory(
				repositoryOwnerName,
				repositoryName);

			this.VerifyRepositoryDoesNotExist(repositoryDirectoryPath);
		}

		public void VerifyRepositoryDoesNotExist(string repositoryDirectoryPath)
		{
			var directoryExists = Instances.FileSystemOperator.DirectoryExists(repositoryDirectoryPath);
			if (directoryExists)
			{
				throw new Exception($"Repository exists. Directory exists: {repositoryDirectoryPath}");
			}
		}
	}
}