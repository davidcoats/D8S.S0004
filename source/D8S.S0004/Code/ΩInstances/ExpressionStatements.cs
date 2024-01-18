using System;


namespace D8S.S0004
{
    public class ExpressionStatements : IExpressionStatements
    {
        #region Infrastructure

        public static IExpressionStatements Instance { get; } = new ExpressionStatements();


        private ExpressionStatements()
        {
        }

        #endregion
    }
}
