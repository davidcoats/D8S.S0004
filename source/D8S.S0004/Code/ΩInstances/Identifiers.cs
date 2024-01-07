using System;


namespace D8S.S0004.Strings
{
    public class Identifiers : IIdentifiers
    {
        #region Infrastructure

        public static IIdentifiers Instance { get; } = new Identifiers();


        private Identifiers()
        {
        }

        #endregion
    }
}
