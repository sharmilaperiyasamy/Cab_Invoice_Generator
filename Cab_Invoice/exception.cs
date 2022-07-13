using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
        public class exception : Exception
        {
            public enum ExceptionType
            {
                INVALID_DISTAANCE,
                INVALID_TIME,
            }
            ExceptionType type;
            public exception(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
}
