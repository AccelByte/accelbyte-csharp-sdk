// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class JsonWebKeySets : Dictionary<string, OauthcommonJWKKey>
    {
        public const string DATA_KEY = "jwks_data";

        public JsonWebKeySets(OauthcommonJWKSet sets)
        {
            if (sets.Keys == null)
                throw new Exception("JWKS keys is null.");

            foreach (var item in sets.Keys)
                Add(item.Kid!, item);
        }

        public void Refresh(OauthcommonJWKSet sets)
        {
            Clear();

            if (sets.Keys == null)
                throw new Exception("JWKS keys is null.");

            foreach (var item in sets.Keys)
                Add(item.Kid!, item);
        }
    }
}
