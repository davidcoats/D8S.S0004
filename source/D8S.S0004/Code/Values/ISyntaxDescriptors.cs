using System;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ISyntaxDescriptors : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Invalid.ISyntaxDescriptors _Invalid => Invalid.SyntaxDescriptors.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>"Test"</value></para>
        /// Member name useful in testing.
        /// </summary>
        public string Test => "Test";

        /// <summary>
        /// <para><value>"D8S_S0004_Test"</value></para>
        /// A complex type name useful in testing.
        /// </summary>
        public string D8S_S0004_Test_WithUnderscores => "D8S_S0004_Test";
    }
}
