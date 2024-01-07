using System;

using R5T.T0131;


namespace D8S.S0004.Invalid
{
    [ValuesMarker]
    public partial interface ISyntaxDescriptors : IValuesMarker
    {
        /// <summary>
        /// <para><value>"D8S.S0004.Test"</value></para>
        /// A complex type name useful in testing.
        /// </summary>
        public string D8S_S0004_Test_WithPeriods => "D8S.S0004.Test";

        /// <summary>
        /// <para><value>"D8S-S0004-Test"</value></para>
        /// A complex type name useful in testing.
        /// </summary>
        public string D8S_S0004_Test_WithDashes => "D8S-S0004-Test";
    }
}
