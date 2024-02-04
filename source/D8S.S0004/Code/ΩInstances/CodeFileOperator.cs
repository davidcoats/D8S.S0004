using System;


namespace D8S.S0004
{
    public class CodeFileOperator : ICodeFileOperator
    {
        #region Infrastructure

        public static ICodeFileOperator Instance { get; } = new CodeFileOperator();


        private CodeFileOperator()
        {
        }

        #endregion
    }
}
