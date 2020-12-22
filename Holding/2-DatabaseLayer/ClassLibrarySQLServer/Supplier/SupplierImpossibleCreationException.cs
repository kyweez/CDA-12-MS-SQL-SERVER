using System;

namespace ClassLibrarySQLServer.Supplier
{
    class SupplierImpossibleCreationException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a supplier can't be created
        /// </summary>
        public SupplierImpossibleCreationException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be created
        /// </summary>
        /// <param name="message">string</param>
        public SupplierImpossibleCreationException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be created
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public SupplierImpossibleCreationException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }
    }
}