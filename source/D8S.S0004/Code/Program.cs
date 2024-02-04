using System;
using System.Threading.Tasks;


namespace D8S.S0004
{
    class Program
    {
        static async Task Main()
        {
            //Experiments.Instance.Scratch();
            //Experiments.Instance.Create_FirstSyntaxNode();
            //Experiments.Instance.Write_FirstSyntaxNode_ToFile_Synchronous();
            //await Experiments.Instance.Write_FirstSyntaxNode_ToFile();
            //await Experiments.Instance.Write_FirstSyntaxNode_InOutputToSampleCodeFileContext();
            //Experiments.Instance.Can_ClassName_BeComplex();
            //Experiments.Instance.Format_ClassDeclaration();
            //Experiments.Instance.RoundTrip_DeserializationSerialization_Raw();
            //Experiments.Instance.ReplaceSyntax_HasDepthFirstTraversalOrder();
            //Experiments.Instance.NodeTokensContainTrailingTrivia();
            //Experiments.Instance.DoesReplaceTokensSkipNotFoundTokens();
            //Experiments.Instance.DoesCompilationUnitContainALastNoneToken();
            //await Experiments.Instance.Build_SyntaxElement();
            //await Experiments.Instance.Try_SetSeparatingSpacing();
            //await Experiments.Instance.Try_Indentation();
            await Experiments.Instance.UseContextOperationsToBuildProgramFile();
        }
    }
}
