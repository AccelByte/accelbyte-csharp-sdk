// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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
        [Test]
        public void SeasonPassTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string nameSeason = "CSharpServerSDKTestSeason";
            DateTime? startTime = new DateTime();
            DateTime? endTime = new DateTime().AddDays(2);
            string defaultDraftStoreId = String.Empty;
            string defaultTierItemId = String.Empty;

            // Arrange store
            List<StoreInfo>? listStores = _Sdk.Platform.Store.ListStoresOp.Execute(_Sdk.Namespace);
            if (listStores == null)
            {
                Assert.Fail("List stores is null");
                return;
            }

            // Check list of stores
            if (listStores.Count > 0)
            {
                // Draft store is exist. Grab the storeId from the first store on list
                defaultDraftStoreId = listStores[0].StoreId!;
            }
            else
            {
                // Draft store is none. Create a new one
                StoreCreate createStore = new StoreCreate()
                {
                    Title = "CSharp SDK Store Test",
                    Description = "Description for CSharp Server SDK store service integration test.",
                    DefaultLanguage = "en",
                    DefaultRegion = "US",
                    SupportedLanguages = new List<string>() { "en", "id" },
                    SupportedRegions = new List<string>() { "US", "ID" }
                };

                StoreInfo? cStoreForSeason = _Sdk.Platform.Store.CreateStoreOp
                    .SetBody(createStore)
                    .Execute(_Sdk.Namespace);

                if (cStoreForSeason != null)
                {
                    // Use the new created storeId
                    defaultDraftStoreId = cStoreForSeason!.StoreId!;
                }
            }

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
                .SetBody(cCategory)
                .Execute(_Sdk.Namespace, defaultDraftStoreId);

            // Create an item tier in platform
            Int32 price = 1000;
            String itemName = "Item_SEASON_Tier1";
            Dictionary<string, object> regionData = new Dictionary<string, Object>();
            regionData.Add("US", new List<RegionDataItem>()
            {
                new RegionDataItem()
                {
                    CurrencyCode = "USD",
                    CurrencyNamespace = "accelbyte",
                    CurrencyType = RegionDataItemCurrencyType.REAL,
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
                .SetBody(createItemStore)
                .Execute(_Sdk.Namespace, defaultDraftStoreId);

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

            List<StoreInfo>? listStores = _Sdk.Platform.Store.ListStoresOp.Execute(_Sdk.Namespace);
            if (listStores == null)
            {
                Assert.Fail("List stores is null");
                return;
            }

            // Check list of stores
            String defaultDraftStoreId;
            if (listStores.Count > 0)
            {
                // Draft store is exist. Grab the storeId from the first store on list
                defaultDraftStoreId = listStores[0].StoreId!;
                StoreInfo? cStore = _Sdk.Platform.Store.DeleteStoreOp
                    .Execute(_Sdk.Namespace, defaultDraftStoreId);
            }
        }
    }
}
