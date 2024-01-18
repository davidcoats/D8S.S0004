using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface INamespaces : IValuesMarker
    {
        /// <summary>
        /// <inheritdoc cref="INamespaceNames.D8S_S0004"/>
        /// The empty namespace.
        /// </summary>
        public NamespaceDeclarationSyntax D8S_S0004_Empty => Instances.SyntaxGenerator.Namespace(
            Instances.NamespaceNames_Strings.D8S_S0004);

        public NamespaceDeclarationSyntax D8S_S0004_Program_Main => Instances.SyntaxGenerator.Build(
            this.D8S_S0004_Empty,
            Instances.NamespaceDeclarationOperations_F001.Add_Class(
                Instances.ClassDeclarations.Program));

        public NamespaceDeclarationSyntax D8S_S0004_Program_Main_Asynchronous => Instances.SyntaxGenerator.Build(
            this.D8S_S0004_Empty,
            Instances.NamespaceDeclarationOperations_F001.Add_Class(
                Instances.ClassDeclarations.Program_Asynchronous));
    }
}
