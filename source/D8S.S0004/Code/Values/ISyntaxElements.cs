using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ISyntaxElements : IValuesMarker
    {
        /// <summary>
        /// The default class declaration, using the <see cref="ISyntaxDescriptors.Test"/> class name.
        /// </summary>
        public ClassDeclarationSyntax Class_Test => Instances.SyntaxGenerator.Class(
            Instances.SyntaxDescriptors.Test);

        public IdentifierNameSyntax Console_IdentifierName => Instances.IdentifierNames.Console;
    }
}
