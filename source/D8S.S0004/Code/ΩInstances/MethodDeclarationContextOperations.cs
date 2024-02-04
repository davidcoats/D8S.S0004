using System;


namespace D8S.S0004
{
    public class MethodDeclarationContextOperations : IMethodDeclarationContextOperations
    {
        #region Infrastructure

        public static IMethodDeclarationContextOperations Instance { get; } = new MethodDeclarationContextOperations();


        private MethodDeclarationContextOperations()
        {
        }

        #endregion
    }
}
