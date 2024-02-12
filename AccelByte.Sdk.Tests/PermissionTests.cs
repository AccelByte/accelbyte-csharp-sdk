// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests
{
    public class TestTokenValidator : TokenValidator
    {
        public string ReplacePlaceholderCheck(string sResource, Dictionary<string, string> parameters)
            => ReplacePlaceholder(sResource, parameters);

        public bool IsResourceAllowedCheck(string accessPermissionResource, string requiredPermissionResource)
            => IsResourceAllowed(accessPermissionResource, requiredPermissionResource);

        public void AddNamespaceContextToCacheForCheck(string key, LocalNamespaceContext namespaceContext)
            => AddNamespaceContextToCache(key, namespaceContext);
    }

    [TestFixture]
    public class PermissionTests
    {
        [Test]
        [TestCase("studio1", "NAMESPACE:studio1-:CLIENT", "NAMESPACE:{namespace}:CLIENT", true, null, null)]
        [TestCase("studio2", "NAMESPACE:studio1-:CLIENT", "NAMESPACE:{namespace}:CLIENT", false, null, null)]
        [TestCase("studio1-game1", "NAMESPACE:studio1-:CLIENT", "NAMESPACE:{namespace}:CLIENT", true, null, null)]
        [TestCase("game1", "NAMESPACE:studio1-:CLIENT", "NAMESPACE:{namespace}:CLIENT", true, "game1", "studio1")]
        [TestCase("game2", "NAMESPACE:studio1-:CLIENT", "NAMESPACE:{namespace}:CLIENT", false, null, null)]
        public void ParseTests(string sNamespace, string resource, string eResource, bool isAllowed, string? gameNamespace, string? studioNamespace)
        {
            var test = new TestTokenValidator();
            if ((gameNamespace != null) && (studioNamespace != null))
                test.AddNamespaceContextToCacheForCheck(gameNamespace, LocalNamespaceContext.CreateGameNS(gameNamespace, studioNamespace));

            string expectedResource = test.ReplacePlaceholderCheck(eResource, new()
            {
                { "namespace", sNamespace }
            });

            bool isValid = test.IsResourceAllowedCheck(resource, expectedResource);
            Assert.AreEqual(isAllowed, isValid);
        }
    }
}
