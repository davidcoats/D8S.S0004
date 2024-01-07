using System;


namespace D8S.S0004
{
    public class ClassDeclarationOperations : IClassDeclarationOperations
    {
        #region Infrastructure

        public static IClassDeclarationOperations Instance { get; } = new ClassDeclarationOperations();


        private ClassDeclarationOperations()
        {
        }

        #endregion
    }
}
