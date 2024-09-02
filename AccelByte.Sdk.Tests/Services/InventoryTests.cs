// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using NUnit.Framework;
using System.Collections.Generic;
using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class InventoryTests : BaseServiceTests
    {
        private AccelByte.Sdk.Api.Inventory.Model.ApimodelsInventoryConfigurationResp? configInventory; // Store the created inventory config for teardown

        public InventoryTests() : base(true) { }

        [Test]
        public void InventoryTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string codeInventory = "csharp-sdk-code-" + Helper.GenerateRandomId(4);

            #region Create an inventory configuration
            ApimodelsCreateInventoryConfigurationReq cInventoryConfigBody = new ApimodelsCreateInventoryConfigurationReq()
            {
                Code=                codeInventory,
                Description=         "testing",
                InitialMaxSlots=     3,
                MaxInstancesPerUser= 2,
                MaxUpgradeSlots=     5,
                Name=                codeInventory
            };

            AccelByte.Sdk.Api.Inventory.Model.ApimodelsInventoryConfigurationResp? configInventory = _Sdk.Inventory.AdminInventoryConfigurations.AdminCreateInventoryConfigurationOp
                .Execute(cInventoryConfigBody, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(configInventory);

            #region Create an inventory
            string userId = _Sdk.Configuration.Credential!.UserId;
            ApimodelsCreateInventoryReq cInventoryBody = new ApimodelsCreateInventoryReq()
            {
                InventoryConfigurationCode = configInventory!.Code,
                UserId = userId,
            };

            AccelByte.Sdk.Api.Inventory.Model.ApimodelsInventoryResp? cInventory = _Sdk.Inventory.AdminInventories.AdminCreateInventoryOp
                .Execute(cInventoryBody, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cInventory);

            #region Get an inventory
            AccelByte.Sdk.Api.Inventory.Model.ApimodelsInventoryResp? gInventory = _Sdk.Inventory.AdminInventories.AdminGetInventoryOp
                .Execute(cInventory.Id, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gInventory);

            #region Update an inventory
            var uInventoryBody = new ApimodelsUpdateInventoryReq()
            {
                IncMaxSlots = 2,
            };

            AccelByte.Sdk.Api.Inventory.Model.ApimodelsInventoryResp? uInventory = _Sdk.Inventory.AdminInventories.AdminUpdateInventoryOp
                .Execute(uInventoryBody, cInventory.Id, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(uInventory);

            #region Delete an inventory
            var dInventoryBody = new ApimodelsDeleteInventoryReq()
            {
                Message = "delete",
            };
            _Sdk.Inventory.AdminInventories.DeleteInventoryOp
                .Execute(dInventoryBody, cInventory.Id, _Sdk.Namespace);
            #endregion
        }

        [TearDown]
        public void TearDown()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null || configInventory == null)
                return;

            // Clean up Inventory configuration
            _Sdk.Inventory.AdminInventoryConfigurations.AdminDeleteInventoryConfigurationOp
                .Execute(configInventory.Id, _Sdk.Namespace);
        }
    }
}
