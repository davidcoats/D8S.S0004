using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0131;


namespace D8S.S0004
{
    [ValuesMarker]
    public partial interface ICompilationUnits : IValuesMarker
    {
        public CompilationUnitSyntax D8S_S0004_Program_Main_Asynchronous => Instances.SyntaxGenerator.Create_CompilationUnit(
            //Instances.CompilationUnitOperations.Add_UsingDirective(
            //    Instances.UsingDirectives.System
            //),
            Instances.CompilationUnitOperations.Add_Namespace(
                Instances.NamespaceNames_Strings.D8S_S0004,
                Instances.NamespaceDeclarationOperations.Add_Class(
                    Instances.ClassNames_Strings.Program,
                    //Instances.ClassDeclarationOperations.Add_Method(
                    //    Instances.Types.Task,
                    //    Instances.MethodNames_Strings.Main,
                    //    (methodDeclaration, _) =>
                    //    {
                    //        return Instances.SyntaxGenerator.Build(
                    //            methodDeclaration,
                    //            Instances.MemberDeclarationOperations.In_ModifyModifiersContext<MethodDeclarationSyntax>(
                    //                Instances.ModifiersOperations.Add_Static,
                    //                Instances.ModifiersOperations.Add_Async),
                    //            Instances.MethodDeclarationOperations.Set_ReturnTypeSeparatingSpacing_Space);
                    //    },
                    //    (methodDeclaration, _) =>
                    //    {
                    //        return Instances.SyntaxGenerator.Build(
                    //            methodDeclaration,
                    //            Instances.MethodDeclarationOperations.Add_Statement(
                    //                Instances.ExpressionStatements.Console_WriteLine_HelloWorld
                    //            )
                    //        );
                    //    },
                    //    (methodDeclaration, context) =>
                    //    {
                    //        context.CompilationUnit = Instances.CompilationUnitOperator._Platform.Add_UsingDirective(
                    //            context.CompilationUnit,
                    //            Instances.UsingDirectives.System_Threading_Tasks);

                    //        return methodDeclaration;
                    //    }
                    //)
                    Instances.ClassDeclarationOperations.Add_Main_Asynchonrous
                )
            )
        );

        /// <summary>
        /// <para><inheritdoc cref="ICodeFilePaths.ExampleClasses" path="/descendant::value"/></para>
        /// </summary>
        public CompilationUnitSyntax ExampleClasses => Instances.CompilationUnitOperator.Load_Synchronous(
            Instances.CodeFilePaths.ExampleClasses);

        /// <summary>
        /// <para><inheritdoc cref="ICodeFilePaths.ExampleClasses" path="/descendant::value"/></para>
        /// Raw, in that no post-parse transformations are applied.
        /// </summary>
        public CompilationUnitSyntax ExampleClasses_Raw => Instances.CompilationUnitOperator.Load_Raw_Synchronous(
            Instances.CodeFilePaths.ExampleClasses);
    }
}
