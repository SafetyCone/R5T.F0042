using System;

using R5T.T0131;


namespace R5T.F0042.F001
{
	[ValuesMarker]
	public partial interface ITemplateFilePaths : IValuesMarker
	{
        private static readonly Lazy<string> zGitIgnoreTemplateFile = new Lazy<string>(() =>
            FilesDirectoryOperator.Instance.GetFilePath(
                FileNames.Instance.GitIgnoreTemplate));
        public string GitIgnoreTemplateFile => ITemplateFilePaths.zGitIgnoreTemplateFile.Value;
    }
}