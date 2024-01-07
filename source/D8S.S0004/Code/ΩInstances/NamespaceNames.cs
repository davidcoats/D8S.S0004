using System;


namespace D8S.S0004
{
    public class NamespaceNames : INamespaceNames
    {
        #region Infrastructure

        public static INamespaceNames Instance { get; } = new NamespaceNames();


        private NamespaceNames()
        {
        }

        #endregion
    }
}
