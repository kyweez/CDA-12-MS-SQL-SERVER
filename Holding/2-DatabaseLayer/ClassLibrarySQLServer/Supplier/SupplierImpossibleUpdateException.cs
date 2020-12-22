using System;

namespace ClassLibrarySQLServer.Supplier
{
    class SupplierImpossibleUpdateException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a supplier can't be updated
        /// </summary>
        public SupplierImpossibleUpdateException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be updated
        /// </summary>
        /// <param name="message">string</param>
        public SupplierImpossibleUpdateException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be updated
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public SupplierImpossibleUpdateException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }
    }
}