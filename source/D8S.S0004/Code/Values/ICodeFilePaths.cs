using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ICodeFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.ICodeFilePaths _Platform => Platform.CodeFilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.ICodeFilePaths.ExampleClasses"/>
        public ICodeFilePath ExampleClasses => _Platform.ExampleClasses.ToCodeFilePath();

        /// <inheritdoc cref="Platform.ICodeFilePaths.ExampleInterface"/>
        public ICodeFilePath ExampleInterface => _Platform.ExampleInterface.ToCodeFilePath();
    }
}
