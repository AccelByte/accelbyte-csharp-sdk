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
    public class InMemoryTokenRepository : ITokenRepository
    {
        private string? _Token = null;

        public string GetToken()
        {
            if (_Token != null)
                return _Token;
            else
                throw new Exception("No token stored.");
        }

        public void RemoveToken()
        {
            _Token = null;
        }

        public void StoreToken(string token)
        {
            _Token = token;
        }
    }
}