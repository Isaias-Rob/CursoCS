using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Aula_1.Models
{
    [Serializable]
    public class ClassException : Exception
    {   
        public ClassException()
        {
            
        }

        public ClassException(string message) : base(message)
        {

        }

        public ClassException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public string? MinhaPropriedade{get; set;}
    }
}