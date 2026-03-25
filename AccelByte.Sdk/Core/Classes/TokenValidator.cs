// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core
{
    public abstract class TokenValidator
    {
        private ConcurrentDictionary<string, List<LocalPermissionItem>> _PermissionCache = new();

        private ConcurrentDictionary<string, LocalNamespaceContext> _NamespaceContextCache = new();

        protected void AddPermissionToCache(string key, List<LocalPermissionItem> permissions)
        {
            _PermissionCache.TryAdd(key, permissions);
        }

        protected void AddNamespaceContextToCache(string key, LocalNamespaceContext namespaceContext)
        {
            if (!_NamespaceContextCache.ContainsKey(key))
                _NamespaceContextCache.TryAdd(key, namespaceContext);
            else
                _NamespaceContextCache[key] = namespaceContext;
        }

        protected void ClearPermissionCache()
        {
            _PermissionCache.Clear();
        }

        protected void ClearNamespaceContextCache()
        {
            _NamespaceContextCache.Clear();
        }

        public void InvalidateCache()
        {
            _PermissionCache.Clear();
            _NamespaceContextCache.Clear();
        }

        protected LocalNamespaceContext? GetCachedNamespaceContext(string key)
        {
            if (_NamespaceContextCache.ContainsKey(key))
                return _NamespaceContextCache[key];
            else
                return null;
        }

        protected virtual List<LocalPermissionItem> ConvertAndCachePermissionItems(string cacheKey, ModelRoleResponseV3 response)
        {
            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in response.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            _PermissionCache[cacheKey] = permissions;
            return permissions;
        }

        protected virtual List<LocalPermissionItem> ConvertAndCachePermissionItems(string cacheKey, ModelRolePermissionResponseV3 response)
        {
            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in response.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            _PermissionCache[cacheKey] = permissions;
            return permissions;
        }

        protected virtual LocalNamespaceContext ConvertAndCacheGameNamespaceContext(string aNamespace, string appNamespace, NamespaceContext appResponse)
        {
            var gameCtx = new LocalNamespaceContext(appResponse);
            AddNamespaceContextToCache(appNamespace, gameCtx);

            if (gameCtx.StudioNamespace != "")
            {
                var studioCtx = new LocalNamespaceContext()
                {
                    Namespace = gameCtx.StudioNamespace,
                    Type = NamespaceType.Studio,
                    PublisherNamespace = gameCtx.PublisherNamespace,
                    StudioNamespace = ""
                };
                AddNamespaceContextToCache(gameCtx.StudioNamespace, studioCtx);
            }

            if (gameCtx.PublisherNamespace != "")
            {
                var publisherCtx = new LocalNamespaceContext()
                {
                    Namespace = gameCtx.PublisherNamespace,
                    Type = NamespaceType.Publisher,
                    PublisherNamespace = "",
                    StudioNamespace = ""
                };
                AddNamespaceContextToCache(gameCtx.PublisherNamespace, publisherCtx);
            }

            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];
            else
                return new LocalNamespaceContext($"Access denied to invalid namespace context {aNamespace}.");
        }

        protected virtual List<LocalPermissionItem> GetRolePermission(AccelByteSDK sdk, string roleId, string roleNs)
        {
            // Strips the trailing "-" from the role namespace, as Studio namespace values are typically suffixed with "-" which can cause lookup errors.
            if (roleNs.EndsWith("-"))
                roleNs = roleNs.Substring(0, roleNs.Length - 1);

            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                if (roleNs == "*" && tvConfig.AllowGlobalRoleFetchForWildcardNamespace)
                {
                    var response = sdk.Iam.Roles.AdminGetRoleV3Op
                        .Execute(roleId);
                    if (response == null)
                        throw new Exception("Null response from AdminGetRoleV3Op");
                    return ConvertAndCachePermissionItems(cacheKey, response);
                }
                else
                {
                    var response = sdk.Iam.OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                        .Execute(roleNs, roleId);
                    if (response == null)
                        throw new Exception("Null response from AdminGetRoleNamespacePermissionV3Op");
                    return ConvertAndCachePermissionItems(cacheKey, response);
                }
            }
            catch
            {
                if (tvConfig.SuppressGetRoleError)
                    return new List<LocalPermissionItem>();
                else
                    throw;
            }
        }

        protected virtual async Task<List<LocalPermissionItem>> GetRolePermissionAsync(AccelByteSDK sdk, string roleId, string roleNs)
        {
            // Strips the trailing "-" from the role namespace, as Studio namespace values are typically suffixed with "-" which can cause lookup errors.
            if (roleNs.EndsWith("-"))
                roleNs = roleNs.Substring(0, roleNs.Length - 1);

            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                if (roleNs == "*" && tvConfig.AllowGlobalRoleFetchForWildcardNamespace)
                {
                    var response = await sdk.Iam.Roles.AdminGetRoleV3Op
                        .ExecuteAsync(roleId);
                    if (response == null)
                        throw new Exception("Null response from AdminGetRoleV3Op");
                    return ConvertAndCachePermissionItems(cacheKey, response);
                }
                else
                {
                    var response = await sdk.Iam.OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                        .ExecuteAsync(roleNs, roleId);
                    if (response == null)
                        throw new Exception("Null response from AdminGetRoleNamespacePermissionV3Op");
                    return ConvertAndCachePermissionItems(cacheKey, response);
                }
            }
            catch
            {
                if (tvConfig.SuppressGetRoleError)
                    return new List<LocalPermissionItem>();
                else
                    throw;
            }
        }

        protected virtual LocalNamespaceContext GetNamespaceContext(AccelByteSDK sdk, string aNamespace)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];

            try
            {
                var response = sdk.Basic.Namespace.GetNamespaceContextOp.Execute(aNamespace);
                if (response == null)
                    return new LocalNamespaceContext("Null response from Basic::Namespace::GetNamespaceContextOp");
                AddNamespaceContextToCache(aNamespace, new LocalNamespaceContext(response));
                return _NamespaceContextCache[aNamespace];
            }
            catch (HttpResponseException)
            {
                // Failed to fetch context for aNamespace (likely a parent namespace
                // the app doesn't have permission to query). Fall back to fetching the
                // app's own game namespace and derive the hierarchy from it.

                string appNamespace = sdk.Configuration.ConfigRepository.Namespace;
                if (appNamespace == "" || appNamespace == aNamespace)
                    return new LocalNamespaceContext($"Namespace is empty or access denied accessing namespace context for {appNamespace}");

                try
                {
                    var appResponse = sdk.Basic.Namespace.GetNamespaceContextOp.Execute(appNamespace);
                    if (appResponse == null)
                        return new LocalNamespaceContext("Null response from Basic::Namespace::GetNamespaceContextOp");
                    return ConvertAndCacheGameNamespaceContext(aNamespace, appNamespace, appResponse);
                }
                catch (Exception x)
                {
                    return new LocalNamespaceContext(x.Message);
                }
            }
        }

        protected virtual async Task<LocalNamespaceContext> GetNamespaceContextAsync(AccelByteSDK sdk, string aNamespace)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];

            try
            {
                var response = await sdk.Basic.Namespace.GetNamespaceContextOp.ExecuteAsync(aNamespace);
                if (response == null)
                    return new LocalNamespaceContext("Null response from Basic::Namespace::GetNamespaceContextOp");

                AddNamespaceContextToCache(aNamespace, new LocalNamespaceContext(response));
                return _NamespaceContextCache[aNamespace];
            }
            catch (HttpResponseException)
            {
                // Failed to fetch context for aNamespace (likely a parent namespace
                // the app doesn't have permission to query). Fall back to fetching the
                // app's own game namespace and derive the hierarchy from it.

                string appNamespace = sdk.Configuration.ConfigRepository.Namespace;
                if (appNamespace == "" || appNamespace == aNamespace)
                    return new LocalNamespaceContext($"Namespace is empty or access denied accessing namespace context for {appNamespace}");

                try
                {
                    var appResponse = await sdk.Basic.Namespace.GetNamespaceContextOp.ExecuteAsync(appNamespace);
                    if (appResponse == null)
                        return new LocalNamespaceContext("Null response from Basic::Namespace::GetNamespaceContextOp");
                    return ConvertAndCacheGameNamespaceContext(aNamespace, appNamespace, appResponse);
                }
                catch (Exception x)
                {
                    return new LocalNamespaceContext(x.Message);
                }
            }
        }

        protected string ReplacePlaceholder(string sResource, Dictionary<string, string> parameters)
        {
            string result = sResource;
            foreach (var param in parameters)
                result = result.Replace("{" + param.Key + "}", param.Value);
            return result;
        }

        protected bool IsResourceAllowed(string accessPermissionResource, string requiredPermissionResource)
        {
            string[] requiredPermResSections = requiredPermissionResource.Split(':');
            int requiredPermResSectionLen = requiredPermResSections.Length;
            string[] accessPermResSections = accessPermissionResource.Split(':');
            int accessPermResSectionLen = accessPermResSections.Length;

            int minSectionLen = accessPermResSectionLen;

            if (minSectionLen > requiredPermResSectionLen)
                minSectionLen = requiredPermResSectionLen;

            for (int i = 0; i < minSectionLen; i++)
            {
                string userSection = accessPermResSections[i];
                string requiredSection = requiredPermResSections[i];
                if ((userSection != requiredSection) && (userSection != "*"))
                {
                    if (userSection.EndsWith("-") && (i > 0))
                    {
                        string previousUserSection = accessPermResSections[i - 1];
                        if (previousUserSection == "NAMESPACE")
                        {
                            if ((requiredSection.Contains("-")) &&
                                (requiredSection.Split("-").Length == 2) &&
                                (requiredSection.StartsWith(userSection)))
                                continue;

                            if (userSection == $"{requiredSection}-")
                                continue;

                            if (_NamespaceContextCache.ContainsKey(requiredSection))
                            {
                                LocalNamespaceContext context = _NamespaceContextCache[requiredSection];
                                if ((context.Type == NamespaceType.Game) && (userSection.StartsWith(context.StudioNamespace)))
                                    continue;
                            }
                        }
                    }

                    return false;
                }
            }

            if (accessPermResSectionLen == requiredPermResSectionLen)
                return true;

            if (accessPermResSectionLen < requiredPermResSectionLen)
            {
                if (accessPermResSections[accessPermResSectionLen - 1] == "*")
                {
                    if (accessPermResSectionLen < 2)
                        return true;

                    string segment = accessPermResSections[accessPermResSectionLen - 2];

                    if ((segment == "NAMESPACE") || (segment == "USER"))
                        return false;

                    return true;
                }

                return false;
            }

            for (int i = requiredPermResSectionLen; i < accessPermResSectionLen; i++)
            {
                if (accessPermResSections[i] != "*")
                    return false;
            }

            return true;
        }
    }
}
