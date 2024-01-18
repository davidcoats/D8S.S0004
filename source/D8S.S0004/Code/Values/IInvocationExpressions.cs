using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface IInvocationExpressions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        public InvocationExpressionSyntax app_Run => Instances.SyntaxGenerator.InvocationExpression(
            Instances.SyntaxGenerator.SimpleMemberAccessExpression(
                Instances.IdentifierNames.app,
                Instances.IdentifierNames.Run)
        );

#pragma warning restore IDE1006 // Naming Styles
    }
}
