using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0073.F001;
using R5T.L0073.T001;
using R5T.L0073.T003;
using R5T.T0141;
using R5T.T0221;


namespace D8S.S0004
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public async Task Write_DocumentationComment_UsingContextOperations()
        {
            /// Inputs.
            var codeFilePath =
                Instances.FilePaths.Sample_CSharpFilePath.Value
                ;
            var summaryNodeContentText =
                "Sample project description."
                ;
            var indentation =
                Instances.SyntaxTrivias.Whitespace_Tab
                ;


            /// Run.
            await Instances.CodeFileContextOperator.In_SyntaxNodeCodeFileContext<DocumentationCommentTriviaSyntax>(
                codeFilePath,
                out _,
                Instances.DocumentationCommentContextOperations.Set_DocumentationComment_New<SyntaxNodeCodeFileContext<DocumentationCommentTriviaSyntax>>(
                    out _
                ),
                Instances.DocumentationCommentContextOperations.Add_SummaryElement<SyntaxNodeCodeFileContext<DocumentationCommentTriviaSyntax>>(
                    summaryNodeContentText
                ),
                Instances.CodeFileContextOperations.Write_SyntaxNode_ToFilePath<SyntaxNodeCodeFileContext<DocumentationCommentTriviaSyntax>, DocumentationCommentTriviaSyntax>(
                    out _
                )
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Indent_DocumentationComment()
        {
            /// Inputs.
            var codeFilePath =
                Instances.FilePaths.Sample_CSharpFilePath.Value
                ;
            var summaryNodeContentText =
                "Sample project description."
                ;
            var indentation =
                Instances.SyntaxTrivias.Whitespace_Tab
                ;


            /// Run.
            await Instances.Operator.In_OutputToSampleCodeFileContext(() =>
            {
                var output =
                    Instances.SyntaxGenerator.DocumentationComment(
                        summaryNodeContentText
                    )
                    ;

                //// Find the parent token for each documentation comment exterior trivia,
                //// then prepend the indentation to the leading trivia of the token
                //// (so the indentation appears before the documentation comment exterior trivia).
                //var documentationCommentExteriorTrivias = Instances.SyntaxNodeOperator.Get_DescendantTrivias(output)
                //    .Where(Instances.SyntaxTriviaOperations.Is_Kind(SyntaxKind.DocumentationCommentExteriorTrivia))
                //    .Now();

                ////output = Instances.SyntaxNodeOperator.Replace_Trivias_Better(
                ////    output,
                ////    documentationCommentExteriorTrivias
                ////        .Select(trivia =>
                ////        {
                ////            var newTrivia = Instances.SyntaxTriviaOperator.New(
                ////                trivia.Kind(),
                ////                indentation.ToString() + trivia.ToString());

                ////            return (trivia, newTrivia);
                ////        })
                ////    );

                //var parentTokens = documentationCommentExteriorTrivias
                //    .Select(Instances.SyntaxTriviaOperator.Get_Parent)
                //    .Now();

                //output = Instances.SyntaxNodeOperator.Replace_Tokens_Better(
                //    output,
                //    parentTokens
                //        .Select(token =>
                //        {
                //            var newToken = Instances.SyntaxTokenOperator.Prepend_ToLeadingTrivia(
                //                token,
                //                indentation);

                //            return (token, newToken);
                //        })
                //    );

                output = Instances.SyntaxIndentationOperator.Indent_DocumentationComments(output);

                return output;
            });
        }

        public async Task Create_XmlDocumentationComment()
        {
            /// Inputs.
            var codeFilePath =
                Instances.FilePaths.Sample_CSharpFilePath.Value
                ;
            var summaryNodeContentText =
                "Sample project description."
                ;


            /// Run.
            //static SyntaxTrivia Internal()

            await Instances.Operator.In_OutputToSampleCodeFileContext(() =>
            {
                var output =
                    //Instances.SyntaxGenerator.DocumentationCommentExteriorTrivia()
                    //Instances.SyntaxGenerator.XmlTextLiteralNewLine()
                    //Instances.SyntaxTokens.XmlDocumentationCommentLeadingSpace
                    //Instances.SyntaxNodes.XmlDocumentationCommentLineLeadingSpace
                    //Instances.SyntaxGenerator.XmlElementEndTag(
                    //    Instances.SyntaxGenerator.XmlName(Instances.XmlDocumentationCommentElementNames.Summary)
                    //)
                    //Instances.SyntaxGenerator.XmlElementStartTag(Instances.XmlDocumentationCommentElementNames.Summary)
                    //Instances.SyntaxGenerator.XmlDocumentationCommentLine(Instances.Strings.Empty)
                    //Instances.SyntaxGenerator.XmlElement(
                    //    Instances.XmlDocumentationCommentElementNames.Summary,
                    //    Instances.SyntaxGenerator.XmlDocumentationCommentNewLine(summaryNodeContentText)
                    //)
                    //Instances.SyntaxGenerator.SingleLineDocumentationCommentTrivia(
                    //    //// Note: not needed! SyntaxFactory add the initial new line itself!
                    //    //Instances.SyntaxNodes.XmlDocumentationCommentLeadingSpace,
                    //    Instances.SyntaxGenerator.XmlElement(
                    //        Instances.XmlDocumentationCommentElementNames.Summary,
                    //        Instances.SyntaxGenerator.XmlDocumentationCommentNewLine(summaryNodeContentText)
                    //    )
                    //)
                    //Instances.SyntaxGenerator.DocumentationComment(
                    //    Instances.SyntaxGenerator.Summary_XmlDocumentationElement(
                    //        summaryNodeContentText
                    //    )
                    //)
                    Instances.SyntaxGenerator.DocumentationComment(
                        summaryNodeContentText
                    )
                    ;

                return output;
            });
        }

        /// <summary>
        /// Using the new context operation sets, use context operations to build a program file.
        /// </summary>
        /// <returns></returns>
        public async Task UseContextOperationSetToBuildProgramFile()
        {
            /// Inputs.
            var codeFilePath =
                Instances.FilePaths.Sample_CSharpFilePath.Value
                ;
            var namespaceName =
                Instances.NamespaceNames_Strings.D8S_S0004
                ;


            /// Run.
            var codeFileContextOperations = Instances.CodeFileContextOperationSetOperator.Generate_ProgramFile<CodeFileContext>(
                namespaceName);

            await Instances.CodeFileOperator.In_CodeFileContext(
                codeFilePath,
                out _,
                codeFileContextOperations
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        /// <summary>
        /// Using the new (20240201) understanding of contexts, use context operations to build a program file.
        /// </summary>
        /// <returns></returns>
        public async Task UseContextOperationsToBuildProgramFile()
        {
            /// Inputs.
            var codeFilePath =
                Instances.FilePaths.Sample_CSharpFilePath.Value
                ;
            var namespaceName =
                Instances.NamespaceNames_Strings.D8S_S0004
                ;
            var className =
                Instances.ClassNames_Strings.Program
                ;


            /// Run.
            await Instances.CodeFileOperator.In_CodeFileContext(
                codeFilePath,
                out _,
                //Instances.ContextOperations.DisplayContext_AtDesignTime_ForAsynchronous<CodeFileContext>(),
                Instances.CompilationUnitContextOperations.Set_CompilationUnit_ToNewEmpty,
                Instances.CompilationUnitContextOperations.Add_UsingNamespace<CodeFileContext>(
                    Instances.NamespaceNames_Strings.System,
                    out var usingSystemNamespace
                ),
                Instances.CompilationUnitContextOperations.In_NamespaceDeclarationContext<CodeFileContext>(
                    out _,
                    //Instances.ContextOperations.DisplayContext_AtDesignTime_ForAsynchronous<NamespaceDeclarationContext>(),
                    Instances.NamespaceDeclarationContextOperations.Set_NamespaceDeclaration_ToNewEmpty<NamespaceDeclarationContext>(
                        namespaceName,
                        out _
                    ),
                    Instances.NamespaceDeclarationContextOperations.In_ClassDeclarationContext<NamespaceDeclarationContext>(
                        out _,
                        Instances.ClassDeclarationContextOperations.Set_ClassDeclaration_New<ClassDeclarationContext>(
                            className,
                            out var classDeclarationSet
                        ),
                        Instances.ClassDeclarationContextOperations.Modify_Modifiers<ClassDeclarationContext>(
                            classDeclarationSet,
                            _ =>
                            {
                                var modifiersDescriptor = new ModifiersDescriptor
                                {
                                    Accessibility = MemberAccessibilityLevel.Public,
                                };

                                var output = Instances.ModifiersOperator.Get_ModifiersTokenList(modifiersDescriptor);
                                return output;
                            }
                        ),
                        // Add a method.
                        Instances.ClassDeclarationContextOperations.In_MethodDeclarationContext<ClassDeclarationContext>(
                            out _,
                            //out var propertiesSet, // Results in CS8196, "Reference to an implicitly-typed out variable 'propertiesSet' is not permitted in the same argument list." error below.
                            //Instances.EnumerableOperator.From( // Does not resolve the CS8196 'propertiesSet' error, since still in the same arguments list.
                            Instances.MethodDeclarationContextOperations.Set_MethodDeclaration_New<MethodDeclarationContext>(
                                Instances.MethodNames_Strings.Main,
                                Instances.Types.Void,
                                out IsSet<IHasMethodDeclaration> methodDeclarationSet),
                            Instances.MethodDeclarationContextOperations.Modify_Modifiers<MethodDeclarationContext>(
                                methodDeclarationSet,
                                _ =>
                                {
                                    var modifiersDescriptor = new ModifiersDescriptor
                                    {
                                        Accessibility = MemberAccessibilityLevel.Public,
                                        Is_Static = true,
                                    };

                                    var output = Instances.ModifiersOperator.Get_ModifiersTokenList(modifiersDescriptor);
                                    return output;
                                }
                            ),
                            Instances.MethodDeclarationContextOperations.In_StatementDeclarationContext<MethodDeclarationContext>(
                                out _,
                                Instances.StatementContextOperations.Set_Statement<StatementContext>(
                                    Instances.Statements.Console_WriteLine_HelloWorld,
                                    out _),
                                Instances.StatementContextOperations.Add_Statement_ToMethodDeclaration
                            ),
                            Instances.MethodDeclarationContextOperations.Add_MethodDeclaration_ToClassDeclaration
                        ),
                        // Do this last so the class declaraion syntax object is finished.
                        Instances.ClassDeclarationContextOperations.Add_ClassDeclaration_ToNamespaceDeclaration
                    ),
                    // Do this last so the namespace declaration syntax object is finished.
                    Instances.NamespaceDeclarationContextOperations.Add_NamespaceDeclaration_ToCompilationUnit
                ),
                // Need to write out the compilation unit to the code file path.
                Instances.CodeFileContextOperations.Write_CompilationUnit_ToFilePath<CodeFileContext>(
                    out _
                )
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        /// <summary>
        /// Indentation of code blocks is the way to add members to members.
        /// </summary>
        public async Task Try_Indentation()
        {
            static SyntaxNode Internal()
            {
                var output =
                    Instances.MethodDeclarations.Main_Empty
                    ;

                output = Instances.SyntaxIndentationOperator.Indent_Block(output);

                return output;
            }

            await Instances.Operator.In_OutputToSampleCodeFileContext(Internal);
        }

        /// <summary>
        /// Separating spacing is the right way to think about spacing.
        /// </summary>
        public async Task Try_SetSeparatingSpacing()
        {
            await Instances.Operator.In_OutputToSampleCodeFileContext(
                () =>
                {
                    var output =
                        Instances.MethodDeclarations._Signatures.Main_WithArgs
                        //Instances.ExpressionStatements.Console_WriteLine_HelloWorld
                        ;

                    //// As the second token, this works.
                    //var token = output.Identifier;

                    // Try the first token.
                    var token = Instances.MethodDeclarationOperator.Get_ReturnTypeSimpleNameIdentifier(output);

                    output = Instances.SyntaxTokenOperator.Set_SeparatingSpacing(
                        token,
                        Instances.SyntaxTriviaLists.Space,
                        output);

                    return output;
                });
        }

        /// <summary>
        /// Useful for building syntax.
        /// </summary>
        public async Task Build_SyntaxElement()
        {
            static SyntaxNode Internal()
            {
                var output =
                    //Instances.Statements.app_Run
                    //Instances.LocalDeclarationStatements.builder_WebApplication_CreateBuilder
                    //Instances.SyntaxGenerator._Raw.VariableDeclaration()
                    Instances.CompilationUnits.D8S_S0004_Program_Main_Asynchronous
                    //Instances.Namespaces.D8S_S0004_Program_Main_Asynchronous
                    //Instances.MethodDeclarations.Main_Asynchronous_Empty
                    //Instances.CompilationUnitOperator._Platform.In_NewContext(
                    //    Instances.CompilationUnitOperations.Add_UsingDirectives(
                    //        Instances.UsingDirectives.System,
                    //        Instances.UsingDirectives.System_Collections_Generic),
                    //    Instances.CompilationUnitOperations.Add_Namespace(
                    //        Instances.Namespaces.D8S_S0004_Empty)
                    //)
                    //Instances.Namespaces.D8S_S0004_Program_Main
                    //Instances.ClassDeclarations.Program_Private
                    //Instances.UsingDirectives.System_Collections_Generic
                    //Instances.MethodDeclarations.Main_WithArgs
                    //Instances.MethodDeclarations.Main
                    //Instances.MethodDeclarations._Signatures.Main
                    //Instances.MethodDeclarations.Main_Empty
                    //Instances.Parameters.args
                    //Instances.TypeSyntaxes.Array_OfStrings
                    //Instances.ExpressionStatements.Console_WriteLine_HelloWorld
                    ;

                return output;
            }

            await Instances.Operator.In_OutputToSampleCodeFileContext(Internal);
        }

        /// <summary>
        /// If so, that would be useful for adding leading trivia to when moving trailing trivia from the last token to be leading trivia of the none token that comes after the last token.
        /// <para>
        /// Result: it does contain an <see cref="SyntaxKind.EndOfFileToken"/>.
        /// </para>
        /// </summary>
        public void DoesCompilationUnitContainALastNoneToken()
        {
            var compilationUnit = Instances.CompilationUnitOperator.New();

            var descendantTokens = Instances.SyntaxNodeOperator.Get_DescendantTokens(compilationUnit);

            Console.WriteLine($"{descendantTokens.Length}: New compilation unit descendant token count.");

            foreach (var token in descendantTokens)
            {
                Console.WriteLine($"{token}: {token.Kind()}");
            }
        }

        /// <summary>
        /// The <see cref="Microsoft.CodeAnalysis.SyntaxNodeExtensions.ReplaceTokens{TRoot}(TRoot, IEnumerable{SyntaxToken}, Func{SyntaxToken, SyntaxToken, SyntaxToken})"/>
        /// method might not throw an exception if any of its input tokens are not found.
        /// <para>
        /// Result: Terrible! Yes, the replace tokens method does <em>not</em> notify in any way if its any of its input tokens are not found.
        /// I would have expected an exception, but instead it is a silent error if you try to modify values that are not found.
        /// </para>
        /// </summary>
        public void DoesReplaceTokensSkipNotFoundTokens()
        {
            var node = Instances.CompilationUnits.ExampleClasses_Raw;

            //// A new node is actually just the None token, and a compilation unit *will* have a none token!
            //// So this does not work for our purposes.
            //var newNode = Instances.SyntaxTokenOperator.New();

            // Modify one of the tokens in the node to get a new token that should not be found in the node.
            var newToken = node.DescendantTokens().First().WithLeadingTrivia();

            var tokenWasFound = false;
            var exceptionWasThrown = false;

            try
            {
                node = node.ReplaceTokens(
                    Instances.EnumerableOperator.From(newToken),
                    (original, rewritten) =>
                    {
                        tokenWasFound = true;

                        return rewritten;
                    });
            }
            catch (Exception ex)
            {
                exceptionWasThrown = true;

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{tokenWasFound}: token was found.");
            Console.WriteLine($"{exceptionWasThrown}: exception was thrown.");
        }

        /// <summary>
        /// Given a syntax node, does any of its tokens contain trailing trivia?
        /// </summary>
        public void NodeTokensContainTrailingTrivia()
        {
            var node =
                //Instances.CompilationUnits.ExampleClasses_Raw
                Instances.CompilationUnits.ExampleClasses
                ;

            var hasAnyTrailingTrivia = Instances.SyntaxNodeOperator_Utilities.Has_DescendantTokensWithTrailingTrivia(
                node,
                out var tokensWithTrailingTrivia);

            if(hasAnyTrailingTrivia)
            {
                foreach (var token in tokensWithTrailingTrivia)
                {
                    var isEndOfDirectiveToken = Instances.SyntaxTokenOperator.Is_Kind(
                        token,
                        SyntaxKind.EndOfDirectiveToken);

                    if(token.Parent is DirectiveTriviaSyntax directiveTriviaSyntax)
                    {
                        Console.WriteLine($"\t{directiveTriviaSyntax.DirectiveNameToken.Text}");
                    }

                    if(isEndOfDirectiveToken)
                    {
                        var message = "<end-of-directive>";

                        if(token.HasLeadingTrivia)
                        {
                            var preprocessingMessageTrivia = token.LeadingTrivia.First();

                            Instances.SyntaxTriviaOperator.Verify_IsKind(
                                preprocessingMessageTrivia,
                                SyntaxKind.PreprocessingMessageTrivia);

                            message += preprocessingMessageTrivia.ToFullString();
                        }

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine(token.Text);
                    }
                }
            }

            Instances.NotepadPlusPlusOperator.Open(
                Instances.CodeFilePaths.ExampleClasses);
        }

        /// <summary>
        /// What is the traversal order for the <see cref="Microsoft.CodeAnalysis.SyntaxNodeExtensions.ReplaceSyntax{TRoot}(TRoot, System.Collections.Generic.IEnumerable{SyntaxNode}?, Func{SyntaxNode, SyntaxNode, SyntaxNode}?, System.Collections.Generic.IEnumerable{SyntaxToken}?, Func{SyntaxToken, SyntaxToken, SyntaxToken}?, System.Collections.Generic.IEnumerable{SyntaxTrivia}?, Func{SyntaxTrivia, SyntaxTrivia, SyntaxTrivia}?)"/>
        /// method?
        /// It is assumed to be depth-first (since rewritten elements with replaced descendants are provided to the compute replacement methods).
        /// <para>
        /// Result: Traversal order IS depth-first, since there are 
        /// </para>
        /// </summary>
        public void ReplaceSyntax_HasDepthFirstTraversalOrder()
        {
            // Use a moderately complex syntax node.
            var compilationUnit = Instances.CompilationUnits.ExampleClasses_Raw;

            // Get all descendant nodes, tokens, and trivias.
            var descendantNodes = Instances.SyntaxNodeOperator.Get_DescendantNodes(compilationUnit);
            var descendantTokens = Instances.SyntaxNodeOperator.Get_DescendantTokens(compilationUnit);
            var descendantTrivia = Instances.SyntaxNodeOperator.Get_DescendantTrivias(compilationUnit);

            // Call the replace syntax method and replace ALL elements (nodes, tokens, and trivias),
            // but instead of replacing the elements (nodes, tokens, or trivias), add them to a list of syntax elements so we can see the order in which they were addressed.
            var syntaxElements = new List<SyntaxElement>();

            SyntaxNode computeReplacementNode(SyntaxNode original, SyntaxNode _)
            {
                var syntaxElement = Instances.SyntaxElementOperator.From(original);

                syntaxElements.Add(syntaxElement);

                return original;
            }

            SyntaxToken computeReplacementToken(SyntaxToken original, SyntaxToken _)
            {
                var syntaxElement = Instances.SyntaxElementOperator.From(original);

                syntaxElements.Add(syntaxElement);

                return original;
            }

            SyntaxTrivia computeReplacementTrivia(SyntaxTrivia original, SyntaxTrivia _)
            {
                var syntaxElement = Instances.SyntaxElementOperator.From(original);

                syntaxElements.Add(syntaxElement);

                return original;
            }

            compilationUnit = compilationUnit.ReplaceSyntax(
                descendantNodes, computeReplacementNode,
                descendantTokens, computeReplacementToken,
                descendantTrivia, computeReplacementTrivia);

            // Add the compilation unit itself so it is available as a possible parent.
            syntaxElements.Add(
                Instances.SyntaxElementOperator.From(compilationUnit));

            // Now, for each syntax element, test that it's parent follows it in the list of syntax elements.
            var misorderedElements = new List<SyntaxElement>();

            // Do not include the last element, which is the compilation unit itself.
            for (int iSyntaxElement = 0; iSyntaxElement < syntaxElements.Count - 1; iSyntaxElement++)
            {
                var syntaxElement = syntaxElements[iSyntaxElement];

                var followingElements = syntaxElements.Skip(iSyntaxElement + 1);

                Instances.SyntaxElementOperator.Switch_OnSyntaxElementType(
                    syntaxElement,
                    node =>
                    {
                        var parentFound = false;

                        foreach (var followingSyntaxNodeElement in followingElements.OfType<SyntaxNodeSyntaxElement>())
                        {
                            if (node.Parent == followingSyntaxNodeElement.Node)
                            {
                                parentFound = true;
                                break;
                            }
                        }

                        if (!parentFound)
                        {
                            misorderedElements.Add(Instances.SyntaxElementOperator.From(node));
                        }
                    },
                    token =>
                    {
                        var parentFound = false;

                        foreach (var followingSyntaxNodeElement in followingElements.OfType<SyntaxNodeSyntaxElement>())
                        {
                            if (token.Parent == followingSyntaxNodeElement.Node)
                            {
                                parentFound = true;
                                break;
                            }
                        }

                        if (!parentFound)
                        {
                            misorderedElements.Add(Instances.SyntaxElementOperator.From(token));
                        }
                    },
                    trivia =>
                    {
                        var parentFound = false;

                        foreach (var followingSyntaxNodeElement in followingElements.OfType<SyntaxTokenSyntaxElement>())
                        {
                            if (trivia.Token == followingSyntaxNodeElement.Token)
                            {
                                parentFound = true;
                                break;
                            }
                        }

                        if (!parentFound)
                        {
                            misorderedElements.Add(Instances.SyntaxElementOperator.From(trivia));
                        }
                    });
            }

            var anyMisorderedElements = misorderedElements.Count != 0;

            if(anyMisorderedElements)
            {
                throw new Exception();
            }
        }

        public void List_Tokens_InCompilationUnit()
        {
            /// Input.
            
        }

        /// <summary>
        /// Round-trip a code file through deserialization then serialization to ensure we can get example syntax elements from a file.
        /// Raw, in that no post-parse transformations (like moving all trivia to be leading trivia) is performed.
        /// </summary>
        public void RoundTrip_DeserializationSerialization_Raw()
        {
            /// Inputs.
            var inputCodeFilePath =
                Instances.CodeFilePaths.ExampleClasses
                ;
            var outputCodeFilePath = Instances.FilePaths.Sample_CSharpFilePath;


            /// Run.
            var compilationUnit = Instances.CompilationUnitOperator.Load_Raw_Synchronous(
                inputCodeFilePath);

            Instances.CompilationUnitOperator.Write_ToFile_Synchronous(
                compilationUnit,
                outputCodeFilePath);

            // Ensure files are byte-level the same.
            Instances.FileEqualityVerifier.Verify_FileEquality_ByteLevel_Synchronous(
                inputCodeFilePath,
                outputCodeFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                inputCodeFilePath,
                outputCodeFilePath);
        }

        /// <summary>
        /// Practice working with syntax trivia, to format a basic.
        /// </summary>
        public void Format_ClassDeclaration()
        {
            //var classDeclaration = Instances.SyntaxElements.Class_Test;

            //var identifier = classDeclaration.Identifier;
            //var modifiers = classDeclaration.Modifiers;
            //var openBrace = classDeclaration.OpenBraceToken;
            //var closeBrace = classDeclaration.CloseBraceToken;

            //var identifierPreviousToken = identifier.GetPreviousToken();
        }

        /// <summary>
        /// Can the <see cref="SyntaxFactory.ClassDeclaration(string)"/> method take a complex class name (a namespaced class name)?
        /// Use the value <see cref="Invalid.ISyntaxDescriptors.D8S_S0004_Test_WithPeriods"/>.
        /// <para>
        /// Result: no exception! This shows that syntax elements <em>can</em> have invalid values (a class name with namespace token separators ('.', periods) would be invalid).
        /// The failure occurs in downstream consuming projects, where unpronounceable names do not appear in intellisense, and cannot be written in code without syntax errors.
        /// </para>
        /// </summary>
        public void Can_ClassName_BeComplex()
        {
            /// Input.
            var className =
                //Instances.SyntaxDescriptors.Test
                //// Works fine, from dotPeek, seems to result in a namspaced class. Available in object browser of a consuming project. Unreferencable (also does not appear in intellisense).
                //Instances.SyntaxDescriptors._Invalid.D8S_S0004_Test_WithPeriods
                //// Works fine, from dotPeek, seems to result in a class with dashes! Available in object browser of a consuming project. Unreferencable (also does not appear in intellisense).
                //Instances.SyntaxDescriptors._Invalid.D8S_S0004_Test_WithDashes
                Instances.SyntaxDescriptors.D8S_S0004_Test_WithUnderscores
                ;


            /// Run.
            // Succeeds, no exception.
            var classDeclaration = Instances.SyntaxGenerator.Class(className);

            // Class must be public to appear in the Visual Studio object browser of a consuming project.
            classDeclaration = classDeclaration.WithModifiers(
                SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword)
                )
            );

            //CSharpSyntaxWalker
            //CSharpSyntaxRewriter
            //classDeclaration.anno

            //SyntaxNode
            //SyntaxToken
            //SyntaxTrivia
            //classDeclaration.ReplaceSyntax(,,,,,,)

            Console.WriteLine($"{className} ->\n{classDeclaration}");

            // Try to compile to see errors.
            var compilationUnit = Instances.SyntaxGenerator.CompilationUnit();

            compilationUnit = compilationUnit.AddMembers(classDeclaration);

            // Still no errors?
            var compilation = CSharpCompilation.Create("Test")
                .WithOptions(new CSharpCompilationOptions(outputKind: OutputKind.DynamicallyLinkedLibrary))
                .AddReferences(MetadataReference.CreateFromFile(
                    typeof(string).Assembly.Location))
                .AddSyntaxTrees(compilationUnit.SyntaxTree);

            //var diagnostics = compilation.GetDiagnostics();

            //foreach (var diagnostic in diagnostics)
            //{
            //    Console.WriteLine(diagnostic);
            //}

            // Stil no errors!
            var emitResult = compilation.Emit("output.dll");

            if(!emitResult.Success)
            {
                foreach (var diagnostic in emitResult.Diagnostics)
                {
                    Console.WriteLine(diagnostic);
                }
            }
        }

        /// <summary>
        /// Write a sample syntax node to a file, but in the helpful code file output context.
        /// </summary>
        public async Task Write_FirstSyntaxNode_InOutputToSampleCodeFileContext()
        {
            /// Inputs.
            var className = "Test";


            /// Run.
            await Instances.Operator.In_OutputToSampleCodeFileContext(
                () =>
                {
                    var classDeclaration = SyntaxFactory.ClassDeclaration(className);
                    return classDeclaration;
                });
        }

        /// <summary>
        /// Write a sample syntax node to a file.
        /// </summary>
        public async Task Write_FirstSyntaxNode_ToFile()
        {
            /// Inputs.
            var className = "Test";
            var codeFilePath = Instances.FilePaths.Sample_CSharpFilePath;


            /// Run.
            var classDeclaration = SyntaxFactory.ClassDeclaration(className);

            await Instances.SyntaxOperator.Write_ToFile(
                classDeclaration,
                codeFilePath);
        }

        /// <summary>
        /// Write a sample syntax node to a file.
        /// </summary>
        public void Write_FirstSyntaxNode_ToFile_Synchronous()
        {
            /// Inputs.
            var className = "Test";
            var codeFilePath = Instances.FilePaths.Sample_CSharpFilePath;


            /// Run.
            var classDeclaration = SyntaxFactory.ClassDeclaration(className);

            /// See <see cref="ISyntaxOperator.Write_ToFile_Synchronous(SyntaxNode, string, bool)"/>.
            using var fileWriter = Instances.FileOperator.Open_ForWrite(codeFilePath);

            classDeclaration.WriteTo(fileWriter);
        }

        /// <summary>
        /// Create a sample syntax node of some sort.
        /// </summary>
        public void Create_FirstSyntaxNode()
        {
            /// Inputs.
            var className = "Test";


            /// Run.
            var classDeclaration = SyntaxFactory.ClassDeclaration(className);

            // "classTest{}", note the lack of any spacing, which is trivia, and is not added by the syntax factory method.
            Console.WriteLine(classDeclaration);
        }

        public void Scratch()
        {
            //var compilationUnit = Instances.SyntaxGenerator.CompilationUnit();

            //var hasUsings = compilationUnit.Usings.Any();
        }
    }
}
