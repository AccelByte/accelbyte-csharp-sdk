﻿// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class PlatformTests : BaseServiceTests
    {
        public PlatformTests() : base(true) { }

        protected void CheckAndClearStores(AccelByteSDK sdk)
        {
            //Check whether draft store is already exists or not
            List<StoreInfo>? stores = sdk.Platform.Store.ListStoresOp
                .Execute(sdk.Namespace);
            if ((stores != null) && (stores.Count > 0))
            {
                foreach (var store in stores)
                {
                    if (store.Published! != true)
                    {
                        //draft store exists. delete it first.
                        sdk.Platform.Store.DeleteStoreOp
                            .Execute(sdk.Namespace, store.StoreId!);
                    }
                    else
                    {
                        //published store exists. delete it too
                        sdk.Platform.Store.DeletePublishedStoreOp
                            .Execute(sdk.Namespace);
                    }
                }
            }
        }

        [Test]
        public void StoreTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            CheckAndClearStores(_Sdk);

            string store_id = String.Empty;

            #region Create a store
            StoreCreate createStore = new StoreCreate()
            {
                Title = "CSharp SDK Store Test",
                Description = "Description for CSharp Server SDK store service integration test.",
                DefaultLanguage = "en",
                DefaultRegion = "US",
                SupportedLanguages = new List<string>() { "en", "id" },
                SupportedRegions = new List<string>() { "US", "ID" }
            };

            StoreInfo? cStore = _Sdk.Platform.Store.CreateStoreOp
                .Execute(createStore, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cStore);
            if (cStore != null)
            {
                Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
                store_id = cStore.StoreId!;
            }

            #region Get a store
            StoreInfo? gStore = _Sdk.Platform.Store.GetStoreOp
                .Execute(_Sdk.Namespace, store_id);
            #endregion
            Assert.IsNotNull(gStore);
            if (gStore != null)
                Assert.AreEqual("CSharp SDK Store Test", gStore.Title);

            #region Update a store
            StoreUpdate updateStore = new StoreUpdate()
            {
                Description = "Updated description."
            };
            StoreInfo? cStoreUpdate = _Sdk.Platform.Store.UpdateStoreOp
                .Execute(updateStore, _Sdk.Namespace, store_id);
            #endregion
            Assert.IsNotNull(cStoreUpdate);
            if (cStoreUpdate != null)
                Assert.AreEqual("Updated description.", cStoreUpdate.Description);

            #region Delete a store
            StoreInfo? dStore = _Sdk.Platform.Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, store_id);
            #endregion
            Assert.IsNotNull(dStore);
        }

        [Test]
        public void StoreExportImportTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            CheckAndClearStores(_Sdk);

            string store_id = String.Empty;

            StoreCreate createStore = new StoreCreate()
            {
                Title = "CSharp SDK Store Test",
                Description = "Description for CSharp Server SDK store service integration test.",
                DefaultLanguage = "en",
                DefaultRegion = "US",
                SupportedLanguages = new List<string>() { "en", "id" },
                SupportedRegions = new List<string>() { "US", "ID" }
            };

            DisableRetry();
            StoreInfo? cStore = _Sdk.Platform.Store.CreateStoreOp
                .Execute(createStore, _Sdk.Namespace);
            Assert.IsNotNull(cStore);
            if (cStore != null)
            {
                Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
                store_id = cStore.StoreId!;
            }

            #region Export a store
            ExportStoreRequest xRequest = new ExportStoreRequest();
            Stream? stream = _Sdk.Platform.Store.ExportStore1Op
                .SetBody(xRequest)
                .Execute(_Sdk.Namespace, store_id);
            #endregion
            if (stream == null)
            {
                Assert.Fail("response stream is null.");
                return;
            }

            MemoryUploadStream uploadStream = MemoryUploadStream.FromStream(stream, "temp.zip");

            DisableRetry();
            #region Import store
            ImportStoreResult? result = _Sdk.Platform.Store.ImportStore1Op
                .SetFile(uploadStream)
                .SetStoreId(store_id)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(result);

            //Delete draft store
            StoreInfo? dStoreAgain = _Sdk.Platform.Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, store_id);
            Assert.IsNotNull(dStoreAgain);
        }
    }
}
