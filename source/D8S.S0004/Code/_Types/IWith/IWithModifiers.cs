using System;

using Microsoft.CodeAnalysis;

using R5T.T0240;


namespace D8S.S0004
{
    [WithXMarker]
    public interface IWithModifiers : IHasXMarker,
        IHasModifiers
    {
        new public SyntaxTokenList Modifiers { get; set; }
    }
}
