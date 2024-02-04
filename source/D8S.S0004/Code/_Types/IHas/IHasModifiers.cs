using System;

using Microsoft.CodeAnalysis;

using R5T.T0240;


namespace D8S.S0004
{
    [HasXMarker]
    public interface IHasModifiers : IHasXMarker
    {
        public SyntaxTokenList Modifiers { get; }
    }
}
