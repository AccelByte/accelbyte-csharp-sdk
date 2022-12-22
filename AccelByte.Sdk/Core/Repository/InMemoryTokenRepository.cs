// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core.Repository
{
    [Obsolete("# Deprecated(2023-02-13): Please use `DefaultTokenRepository` instead.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
    public class InMemoryTokenRepository : DefaultTokenRepository
    {

    }
}