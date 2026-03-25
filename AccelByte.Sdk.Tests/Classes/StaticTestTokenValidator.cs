// Copyright (c) 2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests
{
    public class StaticTestTokenValidator : TokenValidator
    {
        public StaticTestTokenValidator(string gameNs, string studioNs, string publisherNs)
        {
            AddNamespaceContextToCache(publisherNs, new LocalNamespaceContext()
            {
                Namespace = publisherNs,
                Type = NamespaceType.Publisher,
                PublisherNamespace = "",
                StudioNamespace = ""
            });
            AddNamespaceContextToCache(studioNs, new LocalNamespaceContext()
            {
                Namespace = studioNs,
                Type = NamespaceType.Studio,
                PublisherNamespace = publisherNs,
                StudioNamespace = ""
            });

            string appNamespace = $"{studioNs}-{gameNs}";
            AddNamespaceContextToCache(appNamespace, new LocalNamespaceContext()
            {
                Namespace = appNamespace,
                Type = NamespaceType.Game,
                StudioNamespace = studioNs,
                PublisherNamespace = publisherNs
            });
        }

        public bool TestValidateResource(List<LocalPermissionItem> availablePermissions, string roleNamespace, string targetPermission)
        {
            string tRoleNamespace = roleNamespace;
            if (tRoleNamespace.EndsWith("-"))
                tRoleNamespace = tRoleNamespace.Substring(0, tRoleNamespace.Length - 1);

            Dictionary<string, string> pParams = new Dictionary<string, string>();
            var cachedContext = GetCachedNamespaceContext(tRoleNamespace);
            if (cachedContext == null)
                return false; //no namespace context, access denied

            pParams.Add("namespace", roleNamespace);

            bool foundMatchingResource = false;
            foreach (var p in availablePermissions)
            {
                string aResource = ReplacePlaceholder(p.Resource, pParams);
                if (IsResourceAllowed(aResource, targetPermission))
                {
                    foundMatchingResource = true;
                    break;
                }
            }

            return foundMatchingResource;
        }
    }
}
