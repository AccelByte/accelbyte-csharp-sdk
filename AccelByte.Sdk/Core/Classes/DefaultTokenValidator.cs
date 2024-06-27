// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
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
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    GetNamespaceContext(sdk, aNamespace);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((response.Permissions != null) && (response.Permissions.Count > 0))
                {
                    foreach (var p in response.Permissions)
                    {
                        if ((p.Resource != null) && (p.Action != null))
                        {
                            string aPermission = p.Resource;
                            if (pParams.Count > 0)
                                aPermission = ReplacePlaceholder(p.Resource, pParams);

                            if (IsResourceAllowed(aPermission, permission))
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
                OauthmodelTokenResponseV3? response = await sdk.Iam.OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    await GetNamespaceContextAsync(sdk, aNamespace);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((response.Permissions != null) && (response.Permissions.Count > 0))
                {
                    foreach (var p in response.Permissions)
                    {
                        if ((p.Resource != null) && (p.Action != null))
                        {
                            string aPermission = p.Resource;
                            if (pParams.Count > 0)
                                aPermission = ReplacePlaceholder(p.Resource, pParams);

                            if (IsResourceAllowed(aPermission, permission))
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
