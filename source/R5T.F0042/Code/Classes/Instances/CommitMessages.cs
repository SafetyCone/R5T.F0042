using System;


namespace R5T.F0042
{
    [Obsolete("See R5T.Z0036.CommitMessages.")]
    public class CommitMessages : ICommitMessages
	{
		#region Infrastructure

	    public static ICommitMessages Instance { get; } = new CommitMessages();

	    private CommitMessages()
	    {
        }

	    #endregion
	}
}