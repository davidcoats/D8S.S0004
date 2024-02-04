using System;


namespace D8S.S0004
{
    public class ClassDeclarationContextOperations : IClassDeclarationContextOperations
    {
        #region Infrastructure

        public static IClassDeclarationContextOperations Instance { get; } = new ClassDeclarationContextOperations();


        private ClassDeclarationContextOperations()
        {
        }

        #endregion
    }
}
