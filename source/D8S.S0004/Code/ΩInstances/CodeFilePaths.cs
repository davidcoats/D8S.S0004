using System;


namespace D8S.S0004
{
    /// <summary>
    /// Test
    /// </summary>
    public class CodeFilePaths : ICodeFilePaths
    {
        #region Infrastructure

        public static ICodeFilePaths Instance { get; } = new CodeFilePaths();


        private CodeFilePaths()
        {
        }

        #endregion
    }
}


namespace D8S.S0004.Platform
{
    public class CodeFilePaths : ICodeFilePaths
    {
        #region Infrastructure

        public static ICodeFilePaths Instance { get; } = new CodeFilePaths();


        private CodeFilePaths()
        {
        }

        #endregion
    }
}
