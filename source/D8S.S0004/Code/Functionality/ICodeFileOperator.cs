using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0093.T000;
using R5T.T0132;
using R5T.T0221;


namespace D8S.S0004
{
    [FunctionalityMarker]
    public partial interface ICodeFileOperator : IFunctionalityMarker
    {
        public Task In_CodeFileContext(
            string codeFilePath,
            out IsSet<IHasFilePath> codeFilePathSet,
            IEnumerable<Func<CodeFileContext, Task>> operations)
        {
            var codeFileContext = new CodeFileContext
            {
                FilePath = codeFilePath,
            };

            return Instances.ContextOperator.In_Context(
                codeFileContext,
                operations);
        }

        public Task In_CodeFileContext(
            string codeFilePath,
            out IsSet<IHasFilePath> codeFilePathSet,
            params Func<CodeFileContext, Task>[] operations)
        {
            return this.In_CodeFileContext(
                codeFilePath,
                out codeFilePathSet,
                operations.AsEnumerable());
        }
    }
}
