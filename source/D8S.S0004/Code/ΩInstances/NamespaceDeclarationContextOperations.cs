using System;


namespace D8S.S0004
{
    public class NamespaceDeclarationContextOperations : INamespaceDeclarationContextOperations
    {
        #region Infrastructure

        public static INamespaceDeclarationContextOperations Instance { get; } = new NamespaceDeclarationContextOperations();


        private NamespaceDeclarationContextOperations()
        {
        }

        #endregion
    }
}
