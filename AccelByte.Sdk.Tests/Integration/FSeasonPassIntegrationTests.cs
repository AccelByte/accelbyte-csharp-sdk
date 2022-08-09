// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using SeasonPassModel = AccelByte.Sdk.Api.Seasonpass.Model;
using PlatformModel = AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FSeasonpassIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

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
            List<PlatformModel.StoreInfo>? listStores = _Sdk.Platform.Store.ListStoresOp.Execute(_Sdk.Namespace);
            
            // Check list of stores
            if (listStores!.Count > 0)
            {
                // Draft store is exist. Grab the storeId from the first store on list
                defaultDraftStoreId = listStores[0].StoreId!; 
            }
            else
            {
                // Draft store is none. Create a new one
                PlatformModel.StoreCreate createStore = new PlatformModel.StoreCreate()
                {
                    Title = "CSharp SDK Store Test",
                    Description = "Description for CSharp Server SDK store service integration test.",
                    DefaultLanguage = "en",
                    DefaultRegion = "US",
                    SupportedLanguages = new List<string>() { "en", "id" },
                    SupportedRegions = new List<string>() { "US", "ID" }
                };

                PlatformModel.StoreInfo? cStoreForSeason = _Sdk.Platform.Store.CreateStoreOp
                .SetBody(createStore)
                .Execute(_Sdk.Namespace);

                if (cStoreForSeason != null)
                {
                    // Use the new created storeId
                    defaultDraftStoreId = cStoreForSeason!.StoreId!;
                }
            }

            // Create a store category in platform
            String categoryPath = "/" + Guid.NewGuid().ToString().Replace("-", "");
             PlatformModel.CategoryCreate cCategory = new PlatformModel.CategoryCreate()
            {
                CategoryPath = categoryPath,
                LocalizationDisplayNames = new Dictionary<string, string>()
                {
                    { "en", categoryPath }
                }
            };
            PlatformModel.FullCategoryInfo? cCategoryForSeason = _Sdk.Platform.Category.CreateCategoryOp
                .SetBody(cCategory)
                .Execute(_Sdk.Namespace, defaultDraftStoreId); 


            // Create an item tier in platform
            Int32 price = 1000;
            String itemName = "Item_SEASON_Tier1";
            Dictionary<string, object> regionData = new Dictionary<string, Object>();
            regionData.Add("US", new List<PlatformModel.RegionDataItem>()
            {
                new PlatformModel.RegionDataItem()
                {
                    CurrencyCode = "USD",
                    CurrencyNamespace = "accelbyte",
                    CurrencyType = PlatformModel.RegionDataItemCurrencyType.REAL,
                    Price = price
                }
            });
            PlatformModel.ItemCreate createItemStore = new PlatformModel.ItemCreate()
            {
                CategoryPath = categoryPath,
                EntitlementType = PlatformModel.ItemCreateEntitlementType.DURABLE,
                ItemType = PlatformModel.ItemCreateItemType.SEASON,
                Localizations = new Dictionary<string, PlatformModel.Localization>()
                {
                    {"en", new PlatformModel.Localization()
                        {
                            Title = itemName,
                        }}
                },
                Name = itemName,
                RegionData = regionData,
                SeasonType = PlatformModel.ItemCreateSeasonType.TIER
            };

            PlatformModel.FullItemInfo? cItemForSeason = _Sdk.Platform.Item.CreateItemOp
                .SetBody(createItemStore)
                .Execute(_Sdk.Namespace, defaultDraftStoreId); 

            if (cItemForSeason != null)
            {
                // Use the new created tier's itemId
                defaultTierItemId = cItemForSeason!.ItemId!;
            }

            // Creating a season
            Dictionary<string, SeasonPassModel.Localization> sLocalizations = new Dictionary<string, SeasonPassModel.Localization>()
            {
                {"en", new SeasonPassModel.Localization()
                    {
                        Title = "English",
                        Description = "English"
                    }}
            };
            SeasonPassModel.SeasonCreate cSeasonBody = new SeasonPassModel.SeasonCreate()
            {
                Name = nameSeason,
                Start = startTime,
                End = endTime,
                DefaultRequiredExp = 3,
                DraftStoreId = defaultDraftStoreId,
                TierItemId = defaultTierItemId,
                Localizations = sLocalizations
            };
            
            SeasonPassModel.SeasonInfo? cSeason = _Sdk.Seasonpass.Season.CreateSeasonOp
            .SetBody(cSeasonBody)
            .Execute(_Sdk.Namespace);
            Assert.IsNotNull(cSeason);

            string cSeasonId = String.Empty;
            if (cSeason != null)
            {
                cSeasonId = cSeason.Id!;
            }

            // Get a season
            SeasonPassModel.SeasonInfo? gSeason = _Sdk.Seasonpass.Season.GetSeasonOp
            .Execute(_Sdk.Namespace, cSeasonId);
            Assert.IsNotNull(gSeason);

            // Update a season
            SeasonPassModel.SeasonUpdate uSeasonBody = new SeasonPassModel.SeasonUpdate()
            {
                Name = "CSharpServerSDKTestSeasonUpdate",
                Start = startTime,
                End = endTime,
                DefaultRequiredExp = 3,
                DraftStoreId = defaultDraftStoreId,
                TierItemId = defaultTierItemId,
                Localizations = sLocalizations
            };
            
            SeasonPassModel.SeasonInfo? uSeason = _Sdk.Seasonpass.Season.UpdateSeasonOp
            .SetBody(uSeasonBody)
            .Execute(_Sdk.Namespace, cSeasonId);
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

            List<PlatformModel.StoreInfo>? listStores = _Sdk.Platform.Store.ListStoresOp.Execute(_Sdk.Namespace);
            
            // Check list of stores
            String defaultDraftStoreId;
            if (listStores!.Count > 0)
            {
                // Draft store is exist. Grab the storeId from the first store on list
                defaultDraftStoreId = listStores[0].StoreId!; 
                PlatformModel.StoreInfo? cStore = _Sdk.Platform.Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, defaultDraftStoreId);
            }
        }

    }
}