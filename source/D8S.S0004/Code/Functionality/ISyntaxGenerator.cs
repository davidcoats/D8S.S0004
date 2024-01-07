using System;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace D8S.S0004
{
    [FunctionalityMarker]
    public partial interface ISyntaxGenerator : IFunctionalityMarker,
        Common.ISyntaxGenerator
    {
        
    }
}
