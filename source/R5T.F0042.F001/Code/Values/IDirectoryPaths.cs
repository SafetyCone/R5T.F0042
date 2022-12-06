using System;

using R5T.T0131;


namespace R5T.F0042.F001
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker,
		F0091.IDirectoryPaths
	{
        public new string FilesDirectoryPath => IDirectoryPaths.zFilesDirectoryPath.Value;
        private static readonly Lazy<string> zFilesDirectoryPath = new Lazy<string>(
            FilesDirectoryOperator.Instance.GetFilesDirectoryPath);
    }
}