using System;


namespace D8S.S0004
{
    public class CodeFileContextOperator : ICodeFileContextOperator
    {
        #region Infrastructure

        public static ICodeFileContextOperator Instance { get; } = new CodeFileContextOperator();


        private CodeFileContextOperator()
        {
        }

        #endregion
    }
}
