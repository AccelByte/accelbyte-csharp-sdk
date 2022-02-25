// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core.Client
{
    public interface IHttpClient
    {
        HttpResponse SendRequest(Operation operation, String baseUrl);
    }
}