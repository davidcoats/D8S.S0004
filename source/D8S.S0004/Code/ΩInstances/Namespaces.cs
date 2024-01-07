using System;


namespace D8S.S0004
{
    public class Namespaces : INamespaces
    {
        #region Infrastructure

        public static INamespaces Instance { get; } = new Namespaces();


        private Namespaces()
        {
        }

        #endregion
    }
}
