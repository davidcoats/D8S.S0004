using System;


namespace D8S.S0004
{
    public class StatementContextOperations : IStatementContextOperations
    {
        #region Infrastructure

        public static IStatementContextOperations Instance { get; } = new StatementContextOperations();


        private StatementContextOperations()
        {
        }

        #endregion
    }
}
