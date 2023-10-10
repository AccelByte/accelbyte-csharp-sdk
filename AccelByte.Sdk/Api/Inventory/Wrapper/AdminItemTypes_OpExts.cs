// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class InventoryAdminItemTypes_OpExts
    {
        public static Inventory.Model.ApimodelsListItemTypesResp? Execute(
            this AdminListItemTypes.AdminListItemTypesBuilder builder,
            string namespace_
        )
        {
            AdminListItemTypes op = builder.Build(
                namespace_
            );

            return ((Inventory.Wrapper.AdminItemTypes)builder.WrapperObject!).AdminListItemTypes(op);
        }
        public static Inventory.Model.ApimodelsCreateItemTypeResp? Execute(
            this AdminCreateItemType.AdminCreateItemTypeBuilder builder,
            ApimodelsCreateItemTypeReq body,
            string namespace_
        )
        {
            AdminCreateItemType op = builder.Build(
                body,
                namespace_
            );

            return ((Inventory.Wrapper.AdminItemTypes)builder.WrapperObject!).AdminCreateItemType(op);
        }
        public static void Execute(
            this AdminDeleteItemType.AdminDeleteItemTypeBuilder builder,
            string itemTypeName,
            string namespace_
        )
        {
            AdminDeleteItemType op = builder.Build(
                itemTypeName,
                namespace_
            );

            ((Inventory.Wrapper.AdminItemTypes)builder.WrapperObject!).AdminDeleteItemType(op);
        }
    }
}