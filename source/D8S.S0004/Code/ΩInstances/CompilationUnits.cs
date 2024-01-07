using System;


namespace D8S.S0004
{
    public class CompilationUnits : ICompilationUnits
    {
        #region Infrastructure

        public static ICompilationUnits Instance { get; } = new CompilationUnits();


        private CompilationUnits()
        {
        }

        #endregion
    }
}
