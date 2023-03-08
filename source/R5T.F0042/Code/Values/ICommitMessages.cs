using System;

using R5T.T0131;


namespace R5T.F0042
{
    [Obsolete("See R5T.Z0036.ICommitMessages.")]
    [ValuesMarker]
	public partial interface ICommitMessages : IValuesMarker
	{
		[Obsolete("See R5T.Z0036.ICommitMessages.InitialCommit.")]
		public string InitialCommit => "Initial commit.";
	}
}