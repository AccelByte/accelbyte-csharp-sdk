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
    public static class InventoryAdminChainingOperations_OpExts
    {
        public static Inventory.Model.ApimodelsChainingOperationResp? Execute(
            this AdminCreateChainingOperations.AdminCreateChainingOperationsBuilder builder,
            ApimodelsChainingOperationReq body,
            string namespace_
        )
        {
            AdminCreateChainingOperations op = builder.Build(
                body,
                namespace_
            );

            return ((Inventory.Wrapper.AdminChainingOperations)builder.WrapperObject!).AdminCreateChainingOperations(op);
        }
    }
}