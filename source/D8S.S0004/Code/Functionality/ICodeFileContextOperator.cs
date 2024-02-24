using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using R5T.L0093.T000;
using R5T.T0132;
using R5T.T0221;


namespace D8S.S0004
{
    [FunctionalityMarker]
    public partial interface ICodeFileContextOperator : IFunctionalityMarker
    {
        public Task In_SyntaxNodeCodeFileContext<TSyntaxNode>(
            string codeFilePath,
            out IsSet<IHasFilePath> filePathSet,
            IEnumerable<Func<SyntaxNodeCodeFileContext<TSyntaxNode>, Task>> operations)
            where TSyntaxNode : SyntaxNode
        {
            var context = new SyntaxNodeCodeFileContext<TSyntaxNode>
            {
                FilePath = codeFilePath,
            };

            return Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public Task In_SyntaxNodeCodeFileContext<TSyntaxNode>(
            string codeFilePath,
            out IsSet<IHasFilePath> filePathSet,
            params Func<SyntaxNodeCodeFileContext<TSyntaxNode>, Task>[] operations)
            where TSyntaxNode : SyntaxNode
        {
            return this.In_SyntaxNodeCodeFileContext(
                codeFilePath,
                out filePathSet,
                operations.AsEnumerable());
        }
    }
}
