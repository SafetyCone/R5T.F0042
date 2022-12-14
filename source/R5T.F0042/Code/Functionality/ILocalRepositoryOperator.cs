using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.F0042
{
	[FunctionalityMarker]
	public partial interface ILocalRepositoryOperator : IFunctionalityMarker
	{
		public async Task<string> CloneFromRemote(
			string repositoryOwnerName,
			string repositoryName)
		{
			var localRepositoryDirectoryPath = await F0041.GitOperator.Instance.Clone_NonIdempotent(
				repositoryName,
				repositoryOwnerName);

			return localRepositoryDirectoryPath;
		}

		/// <summary>
		/// Non-idempotently deletes a local repository directory.
		/// An exception is thrown if the local repository does not exist.
		/// </summary>
		/// <returns>
		/// The repository local directory path.
		/// </returns>
		public string Delete(
			string repositoryOwnerName,
			string repositoryName)
		{
            var localRepositoryDirectoryPath = F0057.RepositoryDirectoryPathOperator.Instance.GetRepositoryDirectoryPath(repositoryOwnerName, repositoryName);

			this.Delete(localRepositoryDirectoryPath);

			return localRepositoryDirectoryPath;
        }

        public void Delete_Idempotent(
            string localRepositoryDirectoryPath)
        {
            F0000.FileSystemOperator.Instance.DeleteDirectory_Idempotent(localRepositoryDirectoryPath);
        }

        public void Delete(
			string localRepositoryDirectoryPath)
		{
            F0000.FileSystemOperator.Instance.DeleteDirectory_NonIdempotent(localRepositoryDirectoryPath);
        }

		public bool RepositoryExists(string repositoryOwnerName, string repositoryName)
		{
			var repositoryDirectoryPath = Instances.RepositoryDirectoryPathOperator.GetRepositoryDirectoryPath(
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
			var repositoryDirectoryPath = Instances.RepositoryDirectoryPathOperator.GetRepositoryDirectoryPath(
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