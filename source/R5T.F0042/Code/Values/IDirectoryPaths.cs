using System;

using R5T.T0131;


namespace R5T.F0042
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker,
		F0057.IDirectoryPaths
	{
		private static readonly Lazy<string> zFilesDirectoryPath = new Lazy<string>(() => Instances.PathOperator.GetDirectoryPath(
			Instances.ExecutablePathOperator.GetExecutableDirectoryPath(),
			"Files", "R5T.F0042"));

		public string FilesDirectoryPath => IDirectoryPaths.zFilesDirectoryPath.Value;
	}
}