using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0073.T001;
using R5T.T0221;
using R5T.T0241;


namespace D8S.S0004
{
    [ContextOperationsMarker]
    public partial interface INamespaceDeclarationContextOperations : IContextOperationsMarker
    {
        public Task Add_ClassDeclaration_ToNamespaceDeclaration<TContext>(TContext context)
            where TContext : IWithNamespaceDeclaration, IHasClassDeclaration
        {
            context.NamespaceDeclaration = Instances.NamespaceDeclarationOperator.Add_Class(
                context.NamespaceDeclaration,
                context.ClassDeclaration);

            return Task.CompletedTask;
        }

        public Task Add_NamespaceDeclaration_ToCompilationUnit<TContext>(TContext context)
            where TContext : IWithCompilationUnit, IHasNamespaceDeclaration
        {
            return Instances.CompilationUnitContextOperations.Add_NamespaceDeclaration_ToCompilationUnit(context);
        }

        public Func<TContext, Task> In_ClassDeclarationContext<TContext>(
           out (IsSet<IHasCompilationUnit>, IsSet<IHasNamespaceDeclaration>) propertiesSet,
           IEnumerable<Func<ClassDeclarationContext, Task>> operations)
           where TContext : IWithCompilationUnit, IWithNamespaceDeclaration
        {
            return async context =>
            {
                var childContext = new ClassDeclarationContext
                {
                    CompilationUnit = context.CompilationUnit,
                    NamespaceDeclaration = context.NamespaceDeclaration,
                };

                await Instances.ContextOperator.In_Context(
                    childContext,
                    operations);

                // Set the compilation unit in the parent context since the child context operations could have modified it.
                context.CompilationUnit = childContext.CompilationUnit;
                context.NamespaceDeclaration = childContext.NamespaceDeclaration;
            };
        }

        public Func<TContext, Task> In_ClassDeclarationContext<TContext>(
           out (IsSet<IHasCompilationUnit>, IsSet<IHasNamespaceDeclaration>) propertiesSet,
           params Func<ClassDeclarationContext, Task>[] operations)
           where TContext : IWithCompilationUnit, IWithNamespaceDeclaration
        {
            return this.In_ClassDeclarationContext<TContext>(
                out propertiesSet,
                operations.AsEnumerable());
        }

        public Func<TContext, Task> Set_NamespaceDeclaration_ToNewEmpty<TContext>(
            string namespaceName,
            out IsSet<IHasNamespaceDeclaration> namespaceDeclarationSet)
            where TContext : IWithNamespaceDeclaration
        {
            return context =>
            {
                context.NamespaceDeclaration = Instances.SyntaxGenerator.Namespace(
                    namespaceName);

                return Task.CompletedTask;
            };
        }
    }
}
