using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface IVariableDeclarations : IValuesMarker
    {

#pragma warning disable IDE1006 // Naming Styles

        public VariableDeclarationSyntax app_Buiilder_Build => Instances.SyntaxGenerator.VariableDeclaration(
           Instances.Identifiers_Strings.app,
           Instances.Expressions.builder_Build);

        public VariableDeclarationSyntax builder_WebApplication_CreateBuilder => Instances.SyntaxGenerator.VariableDeclaration(
            Instances.Identifiers_Strings.builder,
            Instances.Expressions.WebApplication_CreateBuilder_Args);

#pragma warning restore IDE1006 // Naming Styles

    }
}
