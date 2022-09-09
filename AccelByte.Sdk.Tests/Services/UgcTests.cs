// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class UgcTests : BaseServiceTests
    {
        [Test]
        public void UGCServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string tag_name = "csharp_server_sdk_test";
            string tag_name_u = "csharp_server_sdk_test_update";
            string tag_id = String.Empty;

            #region Create a tag
            ModelsCreateTagRequest createTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name
            };
            ModelsCreateTagResponse? cTag = _Sdk.Ugc.AdminTag.AdminCreateTagOp
                .Execute(createTag, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cTag);
            if (cTag != null)
            {
                Assert.AreEqual(tag_name, cTag.Tag);
                tag_id = cTag.Id!;
            }

            #region Get tags
            ModelsPaginatedGetTagResponse? gTag = _Sdk.Ugc.AdminTag.AdminGetTagOp
                .SetOffset(0)
                .SetLimit(10)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gTag);

            #region Update a tag
            ModelsCreateTagRequest updateTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name_u
            };
            ModelsCreateTagResponse? uTag = _Sdk.Ugc.AdminTag.AdminUpdateTagOp
                .Execute(updateTag, _Sdk.Namespace, tag_id);
            #endregion
            Assert.IsNotNull(uTag);
            if (uTag != null)
                Assert.AreEqual(tag_name_u, uTag.Tag);

            #region Delete a tag
            _Sdk.Ugc.AdminTag.AdminDeleteTagOp
                .Execute(_Sdk.Namespace, tag_id);
            #endregion
        }
    }
}
