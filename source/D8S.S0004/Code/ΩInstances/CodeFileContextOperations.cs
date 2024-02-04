using System;


namespace D8S.S0004
{
    public class CodeFileContextOperations : ICodeFileContextOperations
    {
        #region Infrastructure

        public static ICodeFileContextOperations Instance { get; } = new CodeFileContextOperations();


        private CodeFileContextOperations()
        {
        }

        #endregion
    }
}
