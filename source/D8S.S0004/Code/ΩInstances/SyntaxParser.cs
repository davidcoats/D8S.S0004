using System;


namespace D8S.S0004
{
    public class SyntaxParser : ISyntaxParser
    {
        #region Infrastructure

        public static ISyntaxParser Instance { get; } = new SyntaxParser();


        private SyntaxParser()
        {
        }

        #endregion
    }
}
