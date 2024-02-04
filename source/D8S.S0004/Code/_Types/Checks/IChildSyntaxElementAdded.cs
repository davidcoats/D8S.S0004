using System;

using R5T.T0244;


namespace D8S.S0004
{
    /// <summary>
    /// Check indicating that a child syntax element was added to its parent.
    /// What child syntax element should be clear in context,
    /// and the type of the child syntax element is left to be specified by the variable name.
    /// </summary>
    [CheckMarker]
    public interface IChildSyntaxElementAdded : ICheckMarker
    {
    }
}
