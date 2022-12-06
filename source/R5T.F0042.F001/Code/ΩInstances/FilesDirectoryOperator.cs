using System;


namespace R5T.F0042.F001
{
	public class FilesDirectoryOperator : IFilesDirectoryOperator
	{
		#region Infrastructure

	    public static IFilesDirectoryOperator Instance { get; } = new FilesDirectoryOperator();

	    private FilesDirectoryOperator()
	    {
        }

	    #endregion
	}
}