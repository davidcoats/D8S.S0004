using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface IExpressionStatements : IValuesMarker,
        R5T.L0073.IExpressionStatements
    {
#pragma warning disable IDE1006 // Naming Styles

        public ExpressionStatementSyntax app_Run => Instances.SyntaxGenerator.ExpressionStatement(
            Instances.Expressions.app_Run
        );

#pragma warning restore IDE1006 // Naming Styles
    }
}
