using System;


namespace R5T.F0042
{
	public class RepositoryPathsOperator : IRepositoryPathsOperator
	{
		#region Infrastructure

	    public static IRepositoryPathsOperator Instance { get; } = new RepositoryPathsOperator();

	    private RepositoryPathsOperator()
	    {
        }

	    #endregion
	}
}