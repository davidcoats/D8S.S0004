using System;


namespace D8S.S0004
{
    public class DocumentationCommentContextOperations : IDocumentationCommentContextOperations
    {
        #region Infrastructure

        public static IDocumentationCommentContextOperations Instance { get; } = new DocumentationCommentContextOperations();


        private DocumentationCommentContextOperations()
        {
        }

        #endregion
    }
}
