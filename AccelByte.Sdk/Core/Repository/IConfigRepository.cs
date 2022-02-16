// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

namespace AccelByte.Sdk.Core.Repository
{
    public interface IConfigRepository
    {
        string BaseUrl { get; }

        string ClientId { get; }

        string ClientSecret { get; }

        string AppName{ get; }
    }
}
