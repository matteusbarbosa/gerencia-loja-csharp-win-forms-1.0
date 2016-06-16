using System;
using System.Runtime.Serialization;

namespace TP2
{
    [Serializable]
    internal class BuscaProdutosException : Exception {
        public BuscaProdutosException() { }
        public BuscaProdutosException(string message) : base(message) { }
        public BuscaProdutosException(string message, Exception innerException) : base(message, innerException) { }
        protected BuscaProdutosException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}