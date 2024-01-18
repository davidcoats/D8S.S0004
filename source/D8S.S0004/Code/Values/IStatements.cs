using System;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface IStatements : IValuesMarker,
        IExpressionStatements,
        ILocalDeclarationStatements
    {

    }
}
