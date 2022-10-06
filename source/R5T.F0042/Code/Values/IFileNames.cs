using System;

using R5T.T0131;


namespace R5T.F0042
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string GitIgnore => ".gitignore";
		public string License => "LICENSE";
	}
}