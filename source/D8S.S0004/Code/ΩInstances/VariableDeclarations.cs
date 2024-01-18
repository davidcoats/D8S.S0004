using System;


namespace D8S.S0004
{
    public class VariableDeclarations : IVariableDeclarations
    {
        #region Infrastructure

        public static IVariableDeclarations Instance { get; } = new VariableDeclarations();


        private VariableDeclarations()
        {
        }

        #endregion
    }
}
