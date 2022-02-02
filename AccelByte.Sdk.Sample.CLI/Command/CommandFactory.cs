using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.CLI.Command
{
    public class CommandFactory
    {
        Dictionary<string, Dictionary<string, Type>> _CommandTypes;

        protected void AttachParameterValuesToCommandObject(CommandArguments cArgs,ISdkConsoleCommand cmd)
        {
            Type t = cmd.GetType();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                SdkCommandArgumentAttribute? attArg = pi.GetCustomAttribute<SdkCommandArgumentAttribute>();
                if (attArg != null)
                {
                    if (cArgs.Parameters.ContainsKey(attArg.ParameterName))
                        pi.SetValue(cmd, cArgs.Parameters[attArg.ParameterName]);
                }

                SdkCommandDataAttribute? dtArg = pi.GetCustomAttribute<SdkCommandDataAttribute>();
                if (dtArg != null)
                {
                    if (cArgs.RequestFileContent == String.Empty)
                        continue;

                    object? bodyObj = JsonSerializer.Deserialize(cArgs.RequestFileContent, pi.PropertyType, new JsonSerializerOptions()
                    {
                        WriteIndented = true,
                        AllowTrailingCommas = true,
                        ReadCommentHandling = JsonCommentHandling.Skip
                    });
                    pi.SetValue(cmd, bodyObj);
                }
            }
        }

        public CommandFactory(string nsPrefix, Assembly assembly)
        {
            _CommandTypes = new Dictionary<string, Dictionary<string, Type>>();
            string intfName = typeof(ISdkConsoleCommand).FullName!;

            int nspCount = nsPrefix.Length;
            foreach (Type t in assembly.GetTypes())
            {
                if (t.Namespace!.Length <= nspCount)
                    continue;

                if (t.Namespace!.Substring(0, nspCount) == nsPrefix)
                {
                    if (t.GetInterface(intfName) == null)
                        continue;

                    foreach (SdkConsoleCommandAttribute cmdAttr in t.GetCustomAttributes<SdkConsoleCommandAttribute>())
                    {
                        if (!_CommandTypes.ContainsKey(cmdAttr.ServiceName))
                            _CommandTypes.Add(cmdAttr.ServiceName, new Dictionary<string, Type>());
                        if (!_CommandTypes[cmdAttr.ServiceName].ContainsKey(cmdAttr.OperationName))
                            _CommandTypes[cmdAttr.ServiceName].Add(cmdAttr.OperationName, t);
                    }
                }
            }
        }

        public ISdkConsoleCommand CreateCommandObject(CommandArguments cArgs, AccelByteSDK sdk)
        {
            if ((cArgs.ServiceName == String.Empty) || (cArgs.OperationName == String.Empty))
                throw new Exception("Service name and/or operation name is not specified.");

            if (!_CommandTypes.ContainsKey(cArgs.ServiceName))
                throw new Exception("No command type collection for service '" + cArgs.ServiceName + "'.");
            if (!_CommandTypes[cArgs.ServiceName].ContainsKey(cArgs.OperationName))
                throw new Exception("No command for service '" + cArgs.ServiceName + "' operation '" + cArgs.OperationName + "'.");
            Type t = _CommandTypes[cArgs.ServiceName][cArgs.OperationName];

            ISdkConsoleCommand? obj = (Activator.CreateInstance(t, sdk) as ISdkConsoleCommand);
            if (obj == null)
                throw new Exception("Could not create command object for '" + cArgs.ServiceName + "' operation '" + cArgs.OperationName + "'.");

            AttachParameterValuesToCommandObject(cArgs, obj);
            return obj;
        }
    }
}
