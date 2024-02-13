using System;


namespace D8S.S0004.O001
{
    public class CodeFileContextOperationSetOperator : ICodeFileContextOperationSetOperator
    {
        #region Infrastructure

        public static ICodeFileContextOperationSetOperator Instance { get; } = new CodeFileContextOperationSetOperator();


        private CodeFileContextOperationSetOperator()
        {
        }

        #endregion
    }
}
