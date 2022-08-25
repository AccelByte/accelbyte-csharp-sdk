// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.Cli.Command
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
                        SdkHelper.InjectValueToObjectProperty(pi, cmd, cArgs.Parameters[attArg.ParameterName]);
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

                SdkCommandFileAttribute? ufArg = pi.GetCustomAttribute<SdkCommandFileAttribute>();
                if (ufArg != null)
                {
                    if (cArgs.FileUpload == null)
                        continue;
                    pi.SetValue(cmd, cArgs.FileUpload);
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

        public void EchoCommandParams(ISdkConsoleCommand cmd)
        {
            Type t = cmd.GetType();

            bool isRequestBodyRequired = false;
            bool isFileUploadRequired = false;
            List<string> aParams = new List<string>();

            foreach (PropertyInfo pi in t.GetProperties())
            {
                SdkCommandArgumentAttribute? attArg = pi.GetCustomAttribute<SdkCommandArgumentAttribute>();
                if (attArg != null)
                    aParams.Add(attArg.ParameterName);

                SdkCommandDataAttribute? dtArg = pi.GetCustomAttribute<SdkCommandDataAttribute>();
                if (dtArg != null)
                    isRequestBodyRequired = true;

                SdkCommandFileAttribute? ufArg = pi.GetCustomAttribute<SdkCommandFileAttribute>();
                if (ufArg != null)
                    isFileUploadRequired = true;
            }

            Console.WriteLine("\n\nOperation {0} - {1}", cmd.ServiceName, cmd.OperationName);
            if (aParams.Count > 0)
            {
                string msg = "\nOption(s)\n";
                foreach (string aParam in aParams)
                    msg += "\t--" + aParam + "\n";
                Console.WriteLine(msg);
            }

            if (isRequestBodyRequired)
                Console.WriteLine("\nRequest body is required.");

            if (isFileUploadRequired)
                Console.WriteLine("\nFile upload is required.");
        }

        public void EchoAllServiceNames(AccelByteSDK sdk)
        {
            Console.WriteLine("Available API Service(s):");
            foreach (KeyValuePair<string, Dictionary<string, Type>> pair in _CommandTypes)
            {
                if (pair.Value.Count <= 0)
                    continue;

                KeyValuePair<string, Type> fValue = pair.Value.First();
                ISdkConsoleCommand? obj = (Activator.CreateInstance(fValue.Value, sdk) as ISdkConsoleCommand);
                if (obj == null)
                    continue;
                Console.WriteLine("\t- {0}", obj.ServiceName);
            }            
        }        

        public void EchoAllOperationInService(AccelByteSDK sdk, string serviceName)
        {
            if (!_CommandTypes.ContainsKey(serviceName))
            { 
                Console.WriteLine("No operation within {0} service.", serviceName);
                return;
            }

            Console.WriteLine("Available operation(s):");
            foreach (KeyValuePair<string,Type> pair in _CommandTypes[serviceName])
            {
                ISdkConsoleCommand? obj = (Activator.CreateInstance(pair.Value, sdk) as ISdkConsoleCommand);
                if (obj == null)
                    continue;
                Console.WriteLine("\t- {0}", obj.OperationName);
            }
        }

        public void EchoAllOperations(AccelByteSDK sdk)
        {
            Console.WriteLine("Available service/operations:");
            foreach (KeyValuePair<string, Dictionary<string, Type>> pair in _CommandTypes)
            {
                foreach (KeyValuePair<string, Type> op in pair.Value)
                {
                    ISdkConsoleCommand? obj = (Activator.CreateInstance(op.Value, sdk) as ISdkConsoleCommand);
                    if (obj == null)
                        continue;
                    Console.WriteLine("\t- {0} - {1}", obj.ServiceName, obj.OperationName);
                }                              
            }
        }
    }
}