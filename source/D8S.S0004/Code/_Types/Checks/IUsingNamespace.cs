using System;

using R5T.T0244;


namespace D8S.S0004
{
    /// <summary>
    /// Check indicating that a namespace is being using in a syntax unit.
    /// The name of the namespace being used is encoded in the name of the <see cref="IUsingNamespace"/>-typed variable.
    /// </summary>
    [CheckMarker]
    public interface IUsingNamespace : ICheckMarker
    {
    }
}
