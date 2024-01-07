using System;


namespace D8S.S0004
{
    public class SyntaxElements : ISyntaxElements
    {
        #region Infrastructure

        public static ISyntaxElements Instance { get; } = new SyntaxElements();


        private SyntaxElements()
        {
        }

        #endregion
    }
}
