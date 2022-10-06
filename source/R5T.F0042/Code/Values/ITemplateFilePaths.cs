using System;

using R5T.T0131;


namespace R5T.F0042
{
	[DraftValuesMarker]
	public partial interface ITemplateFilePaths : IDraftValuesMarker
	{
		private static readonly Lazy<string> zGitIgnoreTemplateFile = new Lazy<string>(() => Instances.PathOperator.GetFilePath(
			Instances.DirectoryPaths.FilesDirectoryPath,
			"gitignore-template.txt"));

		public string GitIgnoreTemplateFile => ITemplateFilePaths.zGitIgnoreTemplateFile.Value;
	}
}