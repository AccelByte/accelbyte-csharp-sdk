// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Tests.MockServer
{
    public class MockServerTokenRepository : ITokenRepository
    {
        public string GetToken()
        {
            return "foo";
        }

        public void RemoveToken()
        {
            //
        }

        public void StoreToken(string token)
        {
            //
        }
    }
}