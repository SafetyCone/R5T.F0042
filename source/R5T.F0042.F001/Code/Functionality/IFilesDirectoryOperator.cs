using System;

using R5T.T0132;


namespace R5T.F0042.F001
{
	[FunctionalityMarker]
	public partial interface IFilesDirectoryOperator : IFunctionalityMarker,
		F0091.IFilesDirectoryOperator
	{
        public new string GetFilesDirectoryPath()
        {
            var filesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                F0091.DirectoryPaths.Instance.FilesDirectoryPath,
                DirectoryNames.Instance.ProjectSpecificFilesDirectory);

            return filesDirectoryPath;
        }

        public string GetFilePath(string fileName)
        {
            var filePath = Instances.PathOperator.GetFilePath(
                DirectoryPaths.Instance.FilesDirectoryPath,
                fileName);

            return filePath;
        }
    }
}