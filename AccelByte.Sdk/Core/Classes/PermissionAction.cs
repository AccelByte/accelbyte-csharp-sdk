// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public class PermissionAction
    {
        public const int CREATE = 1;

        public const int READ = 2;

        public const int UPDATE = 4;

        public const int DELETE = 8;

        public static bool Has(int srcPermission, int permission)
        {
            return (srcPermission & permission) == permission;
        }
    }
}
