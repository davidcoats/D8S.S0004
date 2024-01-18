using System;


namespace D8S.S0004
{
    public class InvocationExpressions : IInvocationExpressions
    {
        #region Infrastructure

        public static IInvocationExpressions Instance { get; } = new InvocationExpressions();


        private InvocationExpressions()
        {
        }

        #endregion
    }
}
