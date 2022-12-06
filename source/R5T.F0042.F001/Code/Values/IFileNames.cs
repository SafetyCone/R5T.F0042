using System;

using R5T.T0131;


namespace R5T.F0042.F001
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string GitIgnoreTemplate => "gitignore-template.txt";
	}
}