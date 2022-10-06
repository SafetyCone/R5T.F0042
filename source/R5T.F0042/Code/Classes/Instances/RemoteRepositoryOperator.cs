using System;


namespace R5T.F0042
{
	public class RemoteRepositoryOperator : IRemoteRepositoryOperator
	{
		#region Infrastructure

	    public static IRemoteRepositoryOperator Instance { get; } = new RemoteRepositoryOperator();

	    private RemoteRepositoryOperator()
	    {
        }

	    #endregion
	}
}