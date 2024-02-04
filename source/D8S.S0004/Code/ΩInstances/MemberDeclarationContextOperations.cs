using System;


namespace D8S.S0004
{
    public class MemberDeclarationContextOperations : IMemberDeclarationContextOperations
    {
        #region Infrastructure

        public static IMemberDeclarationContextOperations Instance { get; } = new MemberDeclarationContextOperations();


        private MemberDeclarationContextOperations()
        {
        }

        #endregion
    }
}
