using System;
using System.Runtime.Serialization;

namespace DesafioLocaliza.Core.Exceptions
{
    public class DecomposicaoException : Exception
    {
        public DecomposicaoException()
        {
        }

        public DecomposicaoException(string message) : base(message)
        {
        }

        public DecomposicaoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DecomposicaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
