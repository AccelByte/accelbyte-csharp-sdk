// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public interface ICacheProvider
    {
        bool Save(string key, string value);

        string? Load(string key);

        void Remove(string key);

        bool IsExists(string key);

        bool PushItem(string key, string item);

        List<string>? GetItems(string key);
    }
}