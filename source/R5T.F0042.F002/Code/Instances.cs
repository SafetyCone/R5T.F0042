using System;


namespace R5T.F0042.F002
{
    public static class Instances
    {
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0057.IRepositoryPathsOperator RepositoryPathsOperator => F0057.RepositoryPathsOperator.Instance;
        public static F001.ITemplateFilePaths TemplateFilePaths => F001.TemplateFilePaths.Instance;
    }
}