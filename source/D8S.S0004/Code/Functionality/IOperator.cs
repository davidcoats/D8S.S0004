using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using R5T.T0132;
using R5T.T0172;


namespace D8S.S0004
{
    [FunctionalityMarker]
    public partial interface IOperator : IFunctionalityMarker
    {
        public async Task<ICodeFilePath> In_OutputToSampleCodeFileContext_WithoutOpenInNotepadPlusPlus(
            Func<SyntaxNode> syntaxNodeGenerator)
        {
            var syntaxNode = syntaxNodeGenerator();

            var codeFilePath = Instances.FilePaths.Sample_CSharpFilePath;

            await Instances.SyntaxOperator.Write_ToFile(
                syntaxNode,
                codeFilePath);

            return codeFilePath;
        }

        public async Task<ICodeFilePath> In_OutputToSampleCodeFileContext(
            Func<SyntaxNode> syntaxNodeGenerator)
        {
            var codeFilePath = await this.In_OutputToSampleCodeFileContext_WithoutOpenInNotepadPlusPlus(
                syntaxNodeGenerator);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath);

            return codeFilePath;
        }

        public async Task<ICodeFilePath> In_OutputToSampleCodeFileContext_WithoutOpenInNotepadPlusPlus(
            Func<SyntaxToken> syntaxTokenGenerator)
        {
            var syntaxToken = syntaxTokenGenerator();

            var codeFilePath = Instances.FilePaths.Sample_CSharpFilePath;

            await Instances.SyntaxOperator.Write_ToFile(
                syntaxToken,
                codeFilePath);

            return codeFilePath;
        }

        public async Task<ICodeFilePath> In_OutputToSampleCodeFileContext(
            Func<SyntaxToken> syntaxTokenGenerator)
        {
            var codeFilePath = await this.In_OutputToSampleCodeFileContext_WithoutOpenInNotepadPlusPlus(
                syntaxTokenGenerator);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath);

            return codeFilePath;
        }
    }
}
