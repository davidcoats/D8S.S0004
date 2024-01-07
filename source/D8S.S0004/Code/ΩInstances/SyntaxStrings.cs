using System;


namespace D8S.S0004
{
    public class SyntaxStrings : ISyntaxStrings
    {
        #region Infrastructure

        public static ISyntaxStrings Instance { get; } = new SyntaxStrings();


        private SyntaxStrings()
        {
        }

        #endregion
    }
}


namespace D8S.S0004.Invalid
{
    public class SyntaxStrings : ISyntaxStrings
    {
        #region Infrastructure

        public static ISyntaxStrings Instance { get; } = new SyntaxStrings();


        private SyntaxStrings()
        {
        }

        #endregion
    }
}
