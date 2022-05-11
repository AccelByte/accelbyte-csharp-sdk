// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace AccelByte.Sdk.Core.Client
{
    public interface IRetryLogicHandler
    {
        bool ExecuteRetryLogic(HttpClientPolicy policy, int retryCount, Exception exception);
    }
}
