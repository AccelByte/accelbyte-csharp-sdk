// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class InventoryAdminInventoryConfigurations_OpExts
    {
        public static Inventory.Model.ApimodelsListInventoryConfigurationsResp? Execute(
            this AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder builder,
            string namespace_
        )
        {
            AdminListInventoryConfigurations op = builder.Build(
                namespace_
            );

            return ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminListInventoryConfigurations(op);
        }
        public static async Task<Inventory.Model.ApimodelsListInventoryConfigurationsResp?> ExecuteAsync(
            this AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder builder,
            string namespace_
        )
        {
            AdminListInventoryConfigurations op = builder.Build(
                namespace_
            );

            return await ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminListInventoryConfigurationsAsync(op);
        }
        public static Inventory.Model.ApimodelsInventoryConfigurationResp? Execute(
            this AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder builder,
            ApimodelsCreateInventoryConfigurationReq body,
            string namespace_
        )
        {
            AdminCreateInventoryConfiguration op = builder.Build(
                body,
                namespace_
            );

            return ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminCreateInventoryConfiguration(op);
        }
        public static async Task<Inventory.Model.ApimodelsInventoryConfigurationResp?> ExecuteAsync(
            this AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder builder,
            ApimodelsCreateInventoryConfigurationReq body,
            string namespace_
        )
        {
            AdminCreateInventoryConfiguration op = builder.Build(
                body,
                namespace_
            );

            return await ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminCreateInventoryConfigurationAsync(op);
        }
        public static Inventory.Model.ApimodelsInventoryConfigurationResp? Execute(
            this AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminGetInventoryConfiguration op = builder.Build(
                inventoryConfigurationId,
                namespace_
            );

            return ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminGetInventoryConfiguration(op);
        }
        public static async Task<Inventory.Model.ApimodelsInventoryConfigurationResp?> ExecuteAsync(
            this AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminGetInventoryConfiguration op = builder.Build(
                inventoryConfigurationId,
                namespace_
            );

            return await ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminGetInventoryConfigurationAsync(op);
        }
        public static Inventory.Model.ApimodelsInventoryConfigurationResp? Execute(
            this AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder builder,
            ApimodelsInventoryConfigurationReq body,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminUpdateInventoryConfiguration op = builder.Build(
                body,
                inventoryConfigurationId,
                namespace_
            );

            return ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminUpdateInventoryConfiguration(op);
        }
        public static async Task<Inventory.Model.ApimodelsInventoryConfigurationResp?> ExecuteAsync(
            this AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder builder,
            ApimodelsInventoryConfigurationReq body,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminUpdateInventoryConfiguration op = builder.Build(
                body,
                inventoryConfigurationId,
                namespace_
            );

            return await ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminUpdateInventoryConfigurationAsync(op);
        }
        public static void Execute(
            this AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminDeleteInventoryConfiguration op = builder.Build(
                inventoryConfigurationId,
                namespace_
            );

            ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminDeleteInventoryConfiguration(op);
        }
        public static async Task ExecuteAsync(
            this AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            AdminDeleteInventoryConfiguration op = builder.Build(
                inventoryConfigurationId,
                namespace_
            );

            await ((Inventory.Wrapper.AdminInventoryConfigurations)builder.WrapperObject!).AdminDeleteInventoryConfigurationAsync(op);
        }
    }
}