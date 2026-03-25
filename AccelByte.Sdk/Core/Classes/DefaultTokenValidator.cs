// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Core
{
    public class DefaultTokenValidator : TokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        protected bool InternalValidatePermission(AccelByteSDK sdk, OauthmodelTokenResponseV3 response, string permission, int action, Dictionary<string, string> pParams)
        {
            bool foundMatchingPermission = false;
            if ((response.Permissions != null) && (response.Permissions.Count > 0))
            {
                foreach (var p in response.Permissions)
                {
                    if ((p.Resource != null) && (p.Action != null))
                    {
                        if (IsResourceAllowed(p.Resource, permission))
                        {
                            if (PermissionAction.Has(p.Action.Value, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!foundMatchingPermission)
            {
                if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = GetRolePermission(sdk, r.RoleId, roleNamespace);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
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

        protected async Task<bool> InternalValidatePermissionAsync(AccelByteSDK sdk, OauthmodelTokenResponseV3 response, string permission, int action, Dictionary<string, string> pParams)
        {
            bool foundMatchingPermission = false;
            if ((response.Permissions != null) && (response.Permissions.Count > 0))
            {
                foreach (var p in response.Permissions)
                {
                    if ((p.Resource != null) && (p.Action != null))
                    {
                        if (IsResourceAllowed(p.Resource, permission))
                        {
                            if (PermissionAction.Has(p.Action.Value, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!foundMatchingPermission)
            {
                if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = await GetRolePermissionAsync(sdk, r.RoleId, roleNamespace);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
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

        public bool Validate(AccelByteSDK sdk, string accessToken)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
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
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
                string claimedNamespace = response.Namespace!;

                var result = GetNamespaceContext(sdk, claimedNamespace);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace.
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return InternalValidatePermission(sdk, response, permission, action, pParams);
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
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    var result = GetNamespaceContext(sdk, aNamespace);
                    if (result.IsError)
                        return false; //Access denied to namespace context error
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                return InternalValidatePermission(sdk, response, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(AccelByteSDK sdk, string accessToken)
        {
            try
            {
                OauthmodelTokenResponseV3? response = await sdk.Iam.OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
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
                OauthmodelTokenResponseV3? response = await sdk.Iam.OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
                string claimedNamespace = response.Namespace!;

                var result = await GetNamespaceContextAsync(sdk, claimedNamespace);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace.
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return await InternalValidatePermissionAsync(sdk, response, permission, action, pParams);
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
                OauthmodelTokenResponseV3? response = await sdk.Iam.OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    var result = await GetNamespaceContextAsync(sdk, aNamespace);
                    if (result.IsError)
                        return false; //Access denied to namespace context error
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                return await InternalValidatePermissionAsync(sdk, response, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }
    }
}
