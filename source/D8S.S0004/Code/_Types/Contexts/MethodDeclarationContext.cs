using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0073.T001;
using R5T.T0137;


namespace D8S.S0004
{
    [ContextImplementationMarker]
    public class MethodDeclarationContext : IContextImplementationMarker,
        IWithCompilationUnit,
        IWithNamespaceDeclaration,
        IWithClassDeclaration,
        IWithMethodDeclaration,
        IWithMemberDeclarationType<MethodDeclarationSyntax>
    {
        public MethodDeclarationSyntax MethodDeclaration { get; set; }
        public ClassDeclarationSyntax ClassDeclaration { get; set; }
        public NamespaceDeclarationSyntax NamespaceDeclaration { get; set; }
        public CompilationUnitSyntax CompilationUnit { get; set; }
        public MethodDeclarationSyntax MemberDeclaration
        {
            get => this.MethodDeclaration;
            set => this.MethodDeclaration = value;
        }
    }
}
