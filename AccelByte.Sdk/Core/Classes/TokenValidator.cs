// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;

namespace AccelByte.Sdk.Core
{
    public abstract class TokenValidator
    {
        private Dictionary<string, List<LocalPermissionItem>> _PermissionCache = new();

        private Dictionary<string, LocalNamespaceContext> _NamespaceContextCache = new();

        protected void AddPermissionToCache(string key, List<LocalPermissionItem> permissions)
        {
            _PermissionCache.Add(key, permissions);
        }

        protected void AddNamespaceContextToCache(string key, LocalNamespaceContext namespaceContext)
        {
            _NamespaceContextCache.Add(key, namespaceContext);
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

        protected virtual List<LocalPermissionItem> GetRolePermission(AccelByteSDK sdk, string roleId)
        {
            if (_PermissionCache.ContainsKey(roleId))
                return _PermissionCache[roleId];

            try
            {
                var response = sdk.Iam.Roles.AdminGetRoleV4Op.Execute(roleId);
                if (response == null)
                    throw new Exception("Null response from Iam::Roles::AdminGetRoleV4Op");

                List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
                foreach (var item in response.Permissions!)
                {
                    permissions.Add(new LocalPermissionItem()
                    {
                        Resource = item.Resource!,
                        Action = item.Action!.Value
                    });
                }

                _PermissionCache[roleId] = permissions;
                return permissions;
            }
            catch
            {
                return new List<LocalPermissionItem>();
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
                    throw new Exception("Null response from Basic::Namespace::GetNamespaceContextOp");

                if (!_NamespaceContextCache.ContainsKey(aNamespace))
                    _NamespaceContextCache.Add(aNamespace, new LocalNamespaceContext(response));
                else
                    _NamespaceContextCache[aNamespace] = new LocalNamespaceContext(response);
                return _NamespaceContextCache[aNamespace];
            }
            catch
            {
                return new LocalNamespaceContext();
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
