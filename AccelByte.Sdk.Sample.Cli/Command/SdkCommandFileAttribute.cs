using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SdkCommandFileAttribute : Attribute
    {
        public string ParameterName { get; private set; }

        public SdkCommandFileAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
