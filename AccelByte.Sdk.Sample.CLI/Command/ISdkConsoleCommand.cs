using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.CLI.Command
{
    public interface ISdkConsoleCommand
    {
        string ServiceName { get; }

        string OperationName { get; }

        string Run();
    }
}
