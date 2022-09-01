// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

namespace AccelByte.Sdk.Sample.TicTacToe.Provider
{
    public interface IServerCommandArguments
    {
        string SdkConfigFile { get; }

        int ListenPort { get; }

        bool IsHelpAsked { get; }

        bool IsLogEnabled { get; }

        Dictionary<string, string> Parameters { get; }
    }
}