// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests.Integration
{
    public abstract class BaseIntegrationTest
    {
        protected AccelByteSDK? _Sdk = null;

        protected string UnQuote(string value)
        {
            if ((value.Substring(0, 1) == "\"") && (value.Substring(value.Length - 1, 1) == "\""))
                return value.Substring(1, value.Length - 2);
            else
                return value;
        }
    }
}