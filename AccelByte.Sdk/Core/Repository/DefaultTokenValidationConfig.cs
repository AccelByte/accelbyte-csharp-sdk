// Copyright (c) 2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Repository
{
    /// <summary>
    /// Contains default values for ITokenValidationConfig.
    /// </summary>
    internal class DefaultTokenValidationConfig : ITokenValidationConfig
    {
        public bool AllowGlobalRoleFetchForWildcardNamespace { get; } = true;

        public bool SuppressGetRoleError { get; } = true;
    }
}
