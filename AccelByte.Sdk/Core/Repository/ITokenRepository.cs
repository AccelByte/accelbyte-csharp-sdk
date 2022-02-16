// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

namespace AccelByte.Sdk.Core.Repository
{
    public interface ITokenRepository
    {
        void StoreToken(string token);

        string GetToken();

        void RemoveToken();
    }
}