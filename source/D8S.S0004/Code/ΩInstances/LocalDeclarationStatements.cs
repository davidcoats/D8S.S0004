using System;


namespace D8S.S0004
{
    public class LocalDeclarationStatements : ILocalDeclarationStatements
    {
        #region Infrastructure

        public static ILocalDeclarationStatements Instance { get; } = new LocalDeclarationStatements();


        private LocalDeclarationStatements()
        {
        }

        #endregion
    }
}
