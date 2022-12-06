using System;
using System.Globalization;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.F0042
{
	[FunctionalityMarker]
	public partial interface IRemoteRepositoryOperator : IFunctionalityMarker
	{
		public async Task CloneToLocal_Simple(
			string remoteRepositoryUrl,
			string localRepositoryDirectoryPath)
		{
			await F0041.GitOperator.Instance.Clone_NonIdempotent_Simple(
				remoteRepositoryUrl,
				localRepositoryDirectoryPath);
		}

		/// <inheritdoc cref="F0041.IGitOperator.Clone_NonIdempotent(string, string)"/>
        public async Task<string> CloneToLocal(
            string repositoryOwnerName,
            string repositoryName)
        {
            var localRepositoryDirectoryPath = await F0041.GitOperator.Instance.Clone_NonIdempotent(
                repositoryName,
                repositoryOwnerName);

            return localRepositoryDirectoryPath;
        }

        /// <summary>
        /// Creates a new GitHub repository, erroring if the repository already exists.
        /// </summary>
        /// <returns>The GitHub HTML URL of the repository.</returns>
        public async Task<string> CreateRepository_NonIdempotent(
			string owner,
			string name,
			string description,
			bool isPrivate)
		{
            var repositorySpecification = RepositoryOperator.Instance.Get_RepositorySpecification(
                owner,
				name,
				description,
                isPrivate);

            var gitHubRepository = await Instances.GitHubOperator.CreateRepository_NonIdempotent(repositorySpecification);

			var repositoryUrl = F0041.RepositoryOperator.Instance.GetRepositoryUrl(gitHubRepository);
			return repositoryUrl;
        }

		/// <summary>
		/// Delets a GitHub repository, erroring if the repository already does not exist.
		/// </summary>
		/// <param name="gitHubRepositoryName">The exact, actual, GitHub repository name. (Already adjusted for privacy, for example.)</param>
		public async Task DeleteRepository_NonIdempotent(
			string owner,
			string gitHubRepositoryName)
		{
			await Instances.GitHubOperator.DeleteRepository_NonIdempotent(
				owner,
				gitHubRepositoryName);
		}

        public async Task DeleteRepository_Idempotent(
            string owner,
            string gitHubRepositoryName)
        {
            await Instances.GitHubOperator.DeleteRepository_Idempotent(
                owner,
                gitHubRepositoryName);
        }

        public async Task<bool> RepositoryExists(string repositoryOwnerName, string repositoryName)
		{
			var output = await Instances.GitHubOperator.RepositoryExists(
				repositoryOwnerName,
				repositoryName);

			return output;
		}

		public Task VerifyRepositoryDoesNotExist(string repositoryOwnerName, string repositoryName)
		{
			return Instances.GitHubOperator.VerifyRepositoryDoesNotExist(repositoryOwnerName, repositoryName);
		}
	}
}