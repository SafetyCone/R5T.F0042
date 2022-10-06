using System;

using R5T.T0131;


namespace R5T.F0042
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker,
		S0043.Library.IDirectoryPaths
	{
		private static readonly Lazy<string> zFilesDirectoryPath = new Lazy<string>(() => Instances.PathOperator.GetDirectoryPath(
			Instances.ExecutablePathOperator.GetExecutableDirectoryPath(),
			"Files", "R5T.S0043"));

		public string FilesDirectoryPath => IDirectoryPaths.zFilesDirectoryPath.Value;
	}
}