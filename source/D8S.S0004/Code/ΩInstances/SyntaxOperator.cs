using System;


namespace D8S.S0004
{
    public class SyntaxOperator : ISyntaxOperator
    {
        #region Infrastructure

        public static ISyntaxOperator Instance { get; } = new SyntaxOperator();


        private SyntaxOperator()
        {
        }

        #endregion
    }
}
