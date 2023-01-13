// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;

using Microsoft.IdentityModel.Tokens;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public static class Sdk_ExtensionMethods
    {
        public static void FetchJWKS(this AccelByteSDK sdk)
        {
            OauthcommonJWKSet? tempResp = sdk.Iam.OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute();
            if (tempResp == null)
                throw new Exception("Get JWKS response is NULL");

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        public static void ValidateToken(this AccelByteSDK sdk, string accessToken, out JwtSecurityToken rawJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");

            TokenRevocationData? tokenData = sdk.LocalData.GetData<TokenRevocationData>(TokenRevocationData.DATA_KEY);
            if (tokenData != null)
            {
                bool isRevoked = tokenData.IsTokenRevoked(accessToken);
                if (isRevoked)
                    throw new Exception("Access token is revoked.");
            }

            rawJwt = tokenHandler.ReadJwtToken(accessToken);
            if (!rawJwt.Header.ContainsKey("kid"))
                throw new Exception("missing 'kid' value in jwt header.");
            string keyId = rawJwt.Header["kid"].ToString()!.ToLower();
            if (keyId == String.Empty)
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                sdk.FetchJWKS();
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                sdk.FetchJWKS();
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");

                if (!keySets.ContainsKey(keyId))
                    throw new Exception("No matching JWK set for this token");
            }

            OauthcommonJWKKey key = keySets[keyId];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = (key.N != null ? Helper.DecodeBase64Url(key.N) : new byte[] { }),
                  Exponent = (key.E != null ? Helper.DecodeBase64Url(key.E) : new byte[] { }),
              });

            tokenHandler.ValidateToken(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);
        }

        public static bool ValidateToken(this AccelByteSDK sdk, string accessToken)
        {
            try
            {
                sdk.ValidateToken(accessToken, out JwtSecurityToken rawJwt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ValidateToken(this AccelByteSDK sdk, string accessToken, string permission, int action)
        {
            sdk.ValidateToken(accessToken, out JwtSecurityToken rawJwt);
            AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

            if (payload.Permissions == null)
                return false;

            bool foundMatchingPermission = false;
            foreach (var p in payload.Permissions)
            {
                if (p.Resource == permission)
                {
                    if (p.Action == action)
                    {
                        foundMatchingPermission = true;
                        break;
                    }                    
                }
            }

            if (!foundMatchingPermission)
                return false;

            return true;
        }
    }

    public static class SdkBuilder_ExtensionMethods
    {
        public static AccelByteSdkBuilder UseAutoRefreshForTokenRevocationList(this AccelByteSdkBuilder builder)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(60000);
            builder.RegisterService(refresher);
            return builder;
        }

        public static AccelByteSdkBuilder UseAutoRefreshForTokenRevocationList(this AccelByteSdkBuilder builder, int refreshInterval)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(refreshInterval);
            builder.RegisterService(refresher);
            return builder;
        }
    }
}
