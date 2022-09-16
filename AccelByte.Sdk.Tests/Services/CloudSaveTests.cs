// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Cloudsave.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class CloudSaveTests : BaseServiceTests
    {
        [Test]
        public void CloudSaveServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Create new game record
            ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "foo",
                FooValue = 4893
            };

            _Sdk.Cloudsave.PublicGameRecord.PostGameRecordHandlerV1Op
                .Execute(gameRecord, "foo_bar_record", _Sdk.Namespace);
            #endregion

            #region Get game record
            ModelsGameRecordResponse? gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            Dictionary<string, object> recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("foo", recValue["foo_bar"].ToString());

            #region Update game record
            ModelsGameRecordRequestForTest updateRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "update",
                FooValue = 4893
            };

            _Sdk.Cloudsave.PublicGameRecord.PutGameRecordHandlerV1Op
                .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace);
            #endregion

            //re-check updated game record
            gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo"));
            Assert.AreEqual("bar", recValue["foo"].ToString());

            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("update", recValue["foo_bar"].ToString());

            #region Delete game record
            _Sdk.Cloudsave.PublicGameRecord.DeleteGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                    .Execute("foo_bar_record", _Sdk.Namespace);
            });
        }
    }
}
