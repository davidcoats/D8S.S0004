using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0073.T001;
using R5T.L0073.T003;
using R5T.L0073.T004;
using R5T.L0091.T000;
using R5T.T0221;
using R5T.T0241;


namespace D8S.S0004
{
    [ContextOperationsMarker]
    public partial interface ICompilationUnitContextOperations : IContextOperationsMarker,
        R5T.L0073.O003.ICompilationUnitContextOperations,
        R5T.L0073.O004.ICompilationUnitContextOperations
    {
        public Func<TContext, Task> In_NamespaceDeclarationContext<TContext>(
            string namespaceName,
            out (IsSet<IHasCompilationUnit>, IsSet<IHasNamespaceDeclaration>) propertiesSet,
            out IChecked<IChildSyntaxElementAdded> namespaceDeclarationResultAdded,
            IEnumerable<Func<NamespaceDeclarationContext, Task>> operations)
            where TContext : IWithCompilationUnit
        {
            namespaceDeclarationResultAdded = Checked.Check<IChildSyntaxElementAdded>();

            var modifiedOperations = operations.Append(
                Instances.NamespaceDeclarationContextOperations.Add_NamespaceDeclaration_ToCompilationUnit);

            return this.In_NamespaceDeclarationContext<TContext>(
                out _,
                modifiedOperations);
        }

        public Func<TContext, Task> In_NamespaceDeclarationContext<TContext>(
            string namespaceName,
            out (IsSet<IHasCompilationUnit>, IsSet<IHasNamespaceDeclaration>) propertiesSet,
            out IChecked<IChildSyntaxElementAdded> namespaceDeclarationResultAdded,
            params Func<NamespaceDeclarationContext, Task>[] operations)
            where TContext : IWithCompilationUnit
        {
            return this.In_NamespaceDeclarationContext<TContext>(
                namespaceName,
                out propertiesSet,
                out namespaceDeclarationResultAdded,
                operations.AsEnumerable());
        }
    }
}
