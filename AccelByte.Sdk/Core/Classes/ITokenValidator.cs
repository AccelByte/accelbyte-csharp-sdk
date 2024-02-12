// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public interface ITokenValidator
    {
        void InvalidateCache();

        bool Validate(AccelByteSDK sdk, string accessToken);

        bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action);

        bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action, string? aNamespace, string? userId);
    }
}
