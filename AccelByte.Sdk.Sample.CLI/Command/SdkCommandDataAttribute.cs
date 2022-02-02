using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.CLI.Command
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SdkCommandDataAttribute : Attribute
    {
        public string ParameterName { get; private set; }

        public SdkCommandDataAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
