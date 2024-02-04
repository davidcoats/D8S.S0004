using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0073.T001;
using R5T.L0091.T000;
using R5T.T0221;
using R5T.T0241;


namespace D8S.S0004
{
    [ContextOperationsMarker]
    public partial interface ICompilationUnitContextOperations : IContextOperationsMarker
    {
        public Task Add_NamespaceDeclaration_ToCompilationUnit<TContext>(TContext context)
            where TContext : IWithCompilationUnit, IHasNamespaceDeclaration
        {
            context.CompilationUnit = Instances.CompilationUnitOperator.Add_Namespace(
                context.CompilationUnit,
                context.NamespaceDeclaration);

            return Task.CompletedTask;
        }

        public Func<TContext, Task> Add_UsingNamespace<TContext>(
            string namespaceName,
            out IChecked<IUsingNamespace> usingNamespaceChecked)
            where TContext : IWithCompilationUnit
        {
            usingNamespaceChecked = Checked.Check<IUsingNamespace>();

            return context =>
            {
                context.CompilationUnit = Instances.CompilationUnitOperator.Add_UsingDirective(
                    context.CompilationUnit,
                    namespaceName);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> In_NamespaceDeclarationContext<TContext>(
            out IsSet<IHasCompilationUnit> compilationUnitSet,
            IEnumerable<Func<NamespaceDeclarationContext, Task>> operations)
            where TContext : IWithCompilationUnit
        {
            return async context =>
            {
                var childContext = new NamespaceDeclarationContext
                {
                    CompilationUnit = context.CompilationUnit
                };

                await Instances.ContextOperator.In_Context(
                    childContext,
                    operations);

                // Set the compilation unit in the parent context since the child context operations could have modified it.
                context.CompilationUnit = childContext.CompilationUnit;
            };
        }

        public Func<TContext, Task> In_NamespaceDeclarationContext<TContext>(
            out IsSet<IHasCompilationUnit> compilationUnitSet,
            params Func<NamespaceDeclarationContext, Task>[] operations)
            where TContext : IWithCompilationUnit
        {
            return this.In_NamespaceDeclarationContext<TContext>(
                out compilationUnitSet,
                operations.AsEnumerable());
        }

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

        public Task Set_CompilationUnit_ToNewEmpty<TContext>(TContext context)
            where TContext : IWithCompilationUnit
        {
            context.CompilationUnit = Instances.CompilationUnitOperator.New_Empty();

            return Task.CompletedTask;
        }
    }
}
