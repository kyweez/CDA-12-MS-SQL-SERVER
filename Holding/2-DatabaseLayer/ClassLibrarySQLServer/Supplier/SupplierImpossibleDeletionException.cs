using System;

namespace ClassLibrarySQLServer.Supplier
{
    class SupplierImpossibleDeletionException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a supplier can't be deleted
        /// </summary>
        public SupplierImpossibleDeletionException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be deleted
        /// </summary>
        /// <param name="message">string</param>
        public SupplierImpossibleDeletionException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be deleted
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public SupplierImpossibleDeletionException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }
    }
}