using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ILocalDeclarationStatements : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        public LocalDeclarationStatementSyntax app_Buiilder_Build => Instances.SyntaxGenerator.LocalDeclarationStatement(
            Instances.VariableDeclarations.app_Buiilder_Build);

        public LocalDeclarationStatementSyntax builder_WebApplication_CreateBuilder => Instances.SyntaxGenerator.LocalDeclarationStatement(
            Instances.VariableDeclarations.builder_WebApplication_CreateBuilder);

#pragma warning restore IDE1006 // Naming Styles
    }
}
