using System;

using R5T.T0131;


namespace D8S.S0004.Invalid
{
    /// <summary>
    /// Syntax strings that are invalid (unparsable).
    /// </summary>
    [ValuesMarker]
    public partial interface ISyntaxStrings : IValuesMarker
    {
        /// <summary>
        /// <code>
        /// classTest{}
        /// </code>
        /// Syntax produced by <see cref="Microsoft.CodeAnalysis.CSharp.SyntaxFactory.ClassDeclaration(string)"/>, using the class name <see cref="S0004.ISyntaxDescriptors.Test"/>.
        /// </summary>
        public string Class_Test_WithoutTrivia => "classTest{}";
    }
}
