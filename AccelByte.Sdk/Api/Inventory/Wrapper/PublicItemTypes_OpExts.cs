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
    public static class InventoryPublicItemTypes_OpExts
    {
        public static Inventory.Model.ApimodelsListItemTypesResp? Execute(
            this PublicListItemTypes.PublicListItemTypesBuilder builder,
            string namespace_
        )
        {
            PublicListItemTypes op = builder.Build(
                namespace_
            );

            return ((Inventory.Wrapper.PublicItemTypes)builder.WrapperObject!).PublicListItemTypes(op);
        }
    }
}