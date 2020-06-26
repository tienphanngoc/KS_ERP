using System;
using System.Collections.Generic;
using System.Text;

namespace KSERPUtilities.Exceptions
{
    public class KSERPExceptions : Exception
    {
        public KSERPExceptions()
        {

        }
        public KSERPExceptions(string message) : base(message)
        {

        }
        public KSERPExceptions(string message, Exception inner) : base(message, inner) { }
    }
}
