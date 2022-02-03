using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SdkCommandArgumentAttribute : Attribute
    {
        public string ParameterName { get; private set; }

        public SdkCommandArgumentAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
