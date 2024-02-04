using System;


namespace D8S.S0004
{
    public class CompilationUnitContextOperations : ICompilationUnitContextOperations
    {
        #region Infrastructure

        public static ICompilationUnitContextOperations Instance { get; } = new CompilationUnitContextOperations();


        private CompilationUnitContextOperations()
        {
        }

        #endregion
    }
}
