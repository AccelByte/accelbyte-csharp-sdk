// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class TokenRevocationData
    {
        public const string DATA_KEY = "token_revocation_data";

        private BloomFilter? _RL_TokenCache = null;

        private List<OauthcommonUserRevocationListRecord>? _RL_UserCache = null;

        public TokenRevocationData(OauthapiRevocationList data)
        {
            if (data.RevokedTokens == null)
                throw new Exception("No revoked token list");

            if (data.RevokedUsers == null)
                throw new Exception("No revoked user list");

            _RL_TokenCache = new BloomFilter(data.RevokedTokens);
            _RL_UserCache = data.RevokedUsers;
        }

        public bool IsTokenRevoked(string token)
        {
            if (_RL_TokenCache != null)
                return _RL_TokenCache.MightContain(token);
            else
                return false;
        }
    }
}
