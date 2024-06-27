// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;

using Microsoft.IdentityModel.Tokens;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class LocalTokenValidator : TokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        protected static void FetchJWKS(AccelByteSDK sdk)
        {
            OauthcommonJWKSet? tempResp = sdk.Iam.OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute();
            if (tempResp == null)
                throw new Exception("Get JWKS response is NULL");

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        protected static async Task FetchJWKSAsync(AccelByteSDK sdk)
        {
            OauthcommonJWKSet? tempResp = await sdk.Iam.OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .ExecuteAsync();
            if (tempResp == null)
                throw new Exception("Get JWKS response is NULL");

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        protected static void InternalReadToken(string accessToken, out JwtSecurityToken rawJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");
            rawJwt = tokenHandler.ReadJwtToken(accessToken);
        }

        protected static void InternalValidateToken(AccelByteSDK sdk, string accessToken, out JwtSecurityToken rawJwt)
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
                FetchJWKS(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                FetchJWKS(sdk);
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

        protected static async Task<JwtSecurityToken> InternalValidateTokenAsync(AccelByteSDK sdk, string accessToken)
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

            JwtSecurityToken rawJwt = tokenHandler.ReadJwtToken(accessToken);
            if (!rawJwt.Header.ContainsKey("kid"))
                throw new Exception("missing 'kid' value in jwt header.");
            string keyId = rawJwt.Header["kid"].ToString()!.ToLower();
            if (keyId == String.Empty)
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                await FetchJWKSAsync(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                await FetchJWKSAsync(sdk);
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

            await tokenHandler.ValidateTokenAsync(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            });

            return rawJwt;
        }

        public bool Validate(AccelByteSDK sdk, string accessToken)
        {
            try
            {
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action)
        {
            try
            {
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        if (IsResourceAllowed(p.Resource, permission))
                        {
                            if (PermissionAction.Has(p.Action, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }

                if (!foundMatchingPermission)
                {
                    if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in payload.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = GetRolePermission(sdk, r.RoleId);
                            foreach (var p in permissions)
                            {
                                if (IsResourceAllowed(p.Resource, permission))
                                {
                                    if (PermissionAction.Has(p.Action, action))
                                    {
                                        foundMatchingPermission = true;
                                        break;
                                    }
                                }
                            }

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    GetNamespaceContext(sdk, aNamespace);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        string aPermission = p.Resource;
                        if (pParams.Count > 0)
                            aPermission = ReplacePlaceholder(p.Resource, pParams);

                        if (IsResourceAllowed(aPermission, permission))
                        {
                            if (PermissionAction.Has(p.Action, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }

                if (!foundMatchingPermission)
                {
                    if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in payload.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = GetRolePermission(sdk, r.RoleId);
                            foreach (var p in permissions)
                            {
                                string aPermission = p.Resource;
                                if (pParams.Count > 0)
                                    aPermission = ReplacePlaceholder(p.Resource, pParams);

                                if (IsResourceAllowed(aPermission, permission))
                                {
                                    if (PermissionAction.Has(p.Action, action))
                                    {
                                        foundMatchingPermission = true;
                                        break;
                                    }
                                }
                            }

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public AccessTokenPayload? ParseAccessToken(AccelByteSDK sdk, string accessToken, bool validateFirst)
        {
            JwtSecurityToken rawJwt;
            try
            {
                if (validateFirst)
                    InternalValidateToken(sdk, accessToken, out rawJwt);
                else
                    InternalReadToken(accessToken, out rawJwt);
            }
            catch
            {
                return null;
            }

            return AccessTokenPayload.FromToken(rawJwt);
        }

        public async Task<bool> ValidateAsync(AccelByteSDK sdk, string accessToken)
        {
            try
            {
                await InternalValidateTokenAsync(sdk, accessToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(AccelByteSDK sdk, string accessToken, string permission, int action)
        {
            try
            {
                var rawJwt = await InternalValidateTokenAsync(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        if (IsResourceAllowed(p.Resource, permission))
                        {
                            if (PermissionAction.Has(p.Action, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }

                if (!foundMatchingPermission)
                {
                    if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in payload.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId);
                            foreach (var p in permissions)
                            {
                                if (IsResourceAllowed(p.Resource, permission))
                                {
                                    if (PermissionAction.Has(p.Action, action))
                                    {
                                        foundMatchingPermission = true;
                                        break;
                                    }
                                }
                            }

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(AccelByteSDK sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
                var rawJwt = await InternalValidateTokenAsync(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    await GetNamespaceContextAsync(sdk, aNamespace);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        string aPermission = p.Resource;
                        if (pParams.Count > 0)
                            aPermission = ReplacePlaceholder(p.Resource, pParams);

                        if (IsResourceAllowed(aPermission, permission))
                        {
                            if (PermissionAction.Has(p.Action, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }

                if (!foundMatchingPermission)
                {
                    if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in payload.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId);
                            foreach (var p in permissions)
                            {
                                string aPermission = p.Resource;
                                if (pParams.Count > 0)
                                    aPermission = ReplacePlaceholder(p.Resource, pParams);

                                if (IsResourceAllowed(aPermission, permission))
                                {
                                    if (PermissionAction.Has(p.Action, action))
                                    {
                                        foundMatchingPermission = true;
                                        break;
                                    }
                                }
                            }

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }
    }
}
