// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class SdkConsoleCommandAttribute : Attribute
    {
        public string ServiceName { get; private set; }

        public string OperationName { get; private set; }

        public SdkConsoleCommandAttribute(string serviceName, string opName)
        {
            ServiceName = serviceName;
            OperationName = opName;
        }
    }
}
