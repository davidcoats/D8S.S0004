using System;


namespace D8S.S0004
{
    public class SyntaxDescriptors : ISyntaxDescriptors
    {
        #region Infrastructure

        public static ISyntaxDescriptors Instance { get; } = new SyntaxDescriptors();


        private SyntaxDescriptors()
        {
        }

        #endregion
    }
}


namespace D8S.S0004.Invalid
{
    public class SyntaxDescriptors : ISyntaxDescriptors
    {
        #region Infrastructure

        public static ISyntaxDescriptors Instance { get; } = new SyntaxDescriptors();


        private SyntaxDescriptors()
        {
        }

        #endregion
    }
}
