﻿// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SeasonPassTests : BaseServiceTests
    {
        public SeasonPassTests() : base(true) { }

        [Test]
        public void SeasonPassTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string nameSeason = "CSharpServerSDKTestSeason";
            DateTime? startTime = new DateTime();
            DateTime? endTime = new DateTime().AddDays(2);
            string defaultDraftStoreId = String.Empty;
            string defaultTierItemId = String.Empty;

            //Check whether draft store is already exists or not
            List<StoreInfo>? stores = _Sdk.Platform.Store.ListStoresOp
                .Execute(_Sdk.Namespace);
            if ((stores != null) && (stores.Count > 0))
            {
                foreach (var store in stores)
                {
                    if (store.Published! != true)
                    {
                        //draft store exists. delete it first.
                        _Sdk.Platform.Store.DeleteStoreOp
                            .Execute(_Sdk.Namespace, store.StoreId!);
                    }
                    else
                    {
                        //published store exists. delete it too
                        _Sdk.Platform.Store.DeletePublishedStoreOp
                            .Execute(_Sdk.Namespace);
                    }
                }
            }

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
                defaultDraftStoreId = cStore.StoreId!;

            // Create a store category in platform
            string categoryPath = "/" + Guid.NewGuid().ToString().Replace("-", "");
            CategoryCreate cCategory = new CategoryCreate()
            {
                CategoryPath = categoryPath,
                LocalizationDisplayNames = new Dictionary<string, string>()
                {
                    { "en", categoryPath }
                }
            };
            FullCategoryInfo? cCategoryForSeason = _Sdk.Platform.Category.CreateCategoryOp
                .Execute(cCategory, _Sdk.Namespace, defaultDraftStoreId);

            // Create an item tier in platform
            Int32 price = 1000;
            String itemName = "Item_SEASON_Tier1";
            Dictionary<string, List<RegionDataItemDTO>> regionData = new Dictionary<string, List<RegionDataItemDTO>>();
            regionData.Add("US", new List<RegionDataItemDTO>()
            {
                new RegionDataItemDTO()
                {
                    CurrencyCode = "USD",
                    CurrencyNamespace = "accelbyte",
                    CurrencyType = RegionDataItemDTOCurrencyType.REAL,
                    Price = price
                }
            });
            ItemCreate createItemStore = new ItemCreate()
            {
                CategoryPath = categoryPath,
                EntitlementType = ItemCreateEntitlementType.DURABLE,
                ItemType = ItemCreateItemType.SEASON,
                Localizations = new Dictionary<string, Api.Platform.Model.Localization>()
                {
                    {"en", new Api.Platform.Model.Localization()
                        {
                            Title = itemName,
                        }}
                },
                Name = itemName,
                RegionData = regionData,
                SeasonType = ItemCreateSeasonType.TIER
            };

            FullItemInfo? cItemForSeason = _Sdk.Platform.Item.CreateItemOp
                .Execute(createItemStore, _Sdk.Namespace, defaultDraftStoreId);

            if (cItemForSeason != null)
            {
                // Use the new created tier's itemId
                defaultTierItemId = cItemForSeason!.ItemId!;
            }

            #region Create a season
            Dictionary<string, Api.Seasonpass.Model.Localization> sLocalizations = new Dictionary<string, Api.Seasonpass.Model.Localization>()
            {
                {"en", new Api.Seasonpass.Model.Localization()
                    {
                        Title = "English",
                        Description = "English"
                    }}
            };

            SeasonCreate cSeasonBody = new SeasonCreate()
            {
                Name = nameSeason,
                Start = startTime,
                End = endTime,
                DefaultRequiredExp = 3,
                DraftStoreId = defaultDraftStoreId,
                TierItemId = defaultTierItemId,
                Localizations = sLocalizations
            };

            SeasonInfo? cSeason = _Sdk.Seasonpass.Season.CreateSeasonOp
                .SetBody(cSeasonBody)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cSeason);

            string cSeasonId = String.Empty;
            if (cSeason != null)
            {
                cSeasonId = cSeason.Id!;
            }

            #region Get a season
            SeasonInfo? gSeason = _Sdk.Seasonpass.Season.GetSeasonOp
                .Execute(_Sdk.Namespace, cSeasonId);
            #endregion
            Assert.IsNotNull(gSeason);

            #region Update a season
            SeasonUpdate uSeasonBody = new SeasonUpdate()
            {
                Name = "CSharpServerSDKTestSeasonUpdate",
                Start = startTime,
                End = endTime,
                DefaultRequiredExp = 3,
                DraftStoreId = defaultDraftStoreId,
                TierItemId = defaultTierItemId,
                Localizations = sLocalizations
            };

            SeasonInfo? uSeason = _Sdk.Seasonpass.Season.UpdateSeasonOp
                .SetBody(uSeasonBody)
                .Execute(_Sdk.Namespace, cSeasonId);
            #endregion
            Assert.IsNotNull(uSeason);

            // Delete a season
            _Sdk.Seasonpass.Season.DeleteSeasonOp
                .Execute(_Sdk.Namespace, cSeasonId);
        }

        [TearDown]
        public void TearDown()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            //Clean stores
            List<StoreInfo>? stores = _Sdk.Platform.Store.ListStoresOp
                .Execute(_Sdk.Namespace);
            if ((stores != null) && (stores.Count > 0))
            {
                foreach (var store in stores)
                {
                    if (store.Published! != true)
                    {
                        //draft store exists. delete it.
                        _Sdk.Platform.Store.DeleteStoreOp
                            .Execute(_Sdk.Namespace, store.StoreId!);
                    }
                    else
                    {
                        //published store exists. delete it.
                        _Sdk.Platform.Store.DeletePublishedStoreOp
                            .Execute(_Sdk.Namespace);
                    }
                }
            }
        }
    }
}
