using System;


namespace D8S.S0004
{
    public class Expressions : IExpressions
    {
        #region Infrastructure

        public static IExpressions Instance { get; } = new Expressions();


        private Expressions()
        {
        }

        #endregion
    }
}
