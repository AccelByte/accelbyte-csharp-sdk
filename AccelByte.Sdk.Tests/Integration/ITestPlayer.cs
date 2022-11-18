// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Tests.Integration
{
    public interface ITestPlayer
    {
        string AccessToken { get; }

        string UserId { get; }

        void Login();

        void Logout();

        void Run(Action<AccelByteSDK, ITestPlayer> action);
    }
}