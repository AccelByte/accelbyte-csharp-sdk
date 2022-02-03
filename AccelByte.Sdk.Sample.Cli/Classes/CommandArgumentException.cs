using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli
{
    public class CommandArgumentException : Exception
    {
        public CommandArgumentException() : base("Invalid command argument(s).") { }

        public CommandArgumentException(string message) : base(message) { }
    }
}