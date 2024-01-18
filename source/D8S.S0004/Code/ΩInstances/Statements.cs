using System;


namespace D8S.S0004
{
    public class Statements : IStatements
    {
        #region Infrastructure

        public static IStatements Instance { get; } = new Statements();


        private Statements()
        {
        }

        #endregion
    }
}
