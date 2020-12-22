using System;

namespace ClassLibrarySQLServer.Supplier
{
    class SupplierImpossibleReadException : Exception
    {
        /// <summary>
        /// Instanciate a new exception when a supplier can't be read
        /// </summary>
        public SupplierImpossibleReadException() : base()
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be read
        /// </summary>
        /// <param name="message">string</param>
        public SupplierImpossibleReadException(string message) : base(message)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }

        /// <summary>
        /// Instanciate a new exception when a supplier can't be read
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="inner">Exception</param>
        public SupplierImpossibleReadException(string message, System.Exception inner) : base(message, inner)
        {
            HelpLink = "https://docs.microsoft.com";
            Source = "ClassLibrarySQLServer.Supplier";
        }
    }
}