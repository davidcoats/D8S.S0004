using System;


namespace D8S.S0004
{
    public class IdentifierNames : IIdentifierNames
    {
        #region Infrastructure

        public static IIdentifierNames Instance { get; } = new IdentifierNames();


        private IdentifierNames()
        {
        }

        #endregion
    }
}
