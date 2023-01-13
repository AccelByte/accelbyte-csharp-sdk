// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AccelByte.Sdk;

namespace AccelByte.Sdk.Core
{
    public interface ISdkService
    {
        void Start(AccelByteSDK sdk);

        void Stop();
    }
}
