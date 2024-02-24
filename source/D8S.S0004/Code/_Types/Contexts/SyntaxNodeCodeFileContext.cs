using System;

using Microsoft.CodeAnalysis;

using R5T.L0073.T001;
using R5T.L0093.T000;
using R5T.T0137;


namespace D8S.S0004
{
    [ContextImplementationMarker]
    public class SyntaxNodeCodeFileContext<TSyntaxNode> : IContextImplementationMarker,
        IWithSyntaxNode<TSyntaxNode>,
        IWithFilePath
        where TSyntaxNode : SyntaxNode
    {
        public TSyntaxNode SyntaxNode { get; set; }
        public string FilePath { get; set; }
    }
}
