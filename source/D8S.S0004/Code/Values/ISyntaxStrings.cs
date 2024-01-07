using System;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ISyntaxStrings : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Invalid.ISyntaxStrings _Invalid => Invalid.SyntaxStrings.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
