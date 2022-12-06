using System;


namespace R5T.F0042.F002
{
	public class RepositoryFilesOperator : IRepositoryFilesOperator
	{
		#region Infrastructure

	    public static IRepositoryFilesOperator Instance { get; } = new RepositoryFilesOperator();

	    private RepositoryFilesOperator()
	    {
        }

	    #endregion
	}
}