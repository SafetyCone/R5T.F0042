using System;


namespace R5T.F0042.F001
{
	public class TemplateFilePaths : ITemplateFilePaths
	{
		#region Infrastructure

	    public static ITemplateFilePaths Instance { get; } = new TemplateFilePaths();

	    private TemplateFilePaths()
	    {
        }

	    #endregion
	}
}