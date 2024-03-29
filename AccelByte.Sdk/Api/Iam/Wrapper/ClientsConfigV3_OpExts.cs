// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamClientsConfigV3_OpExts
    {
        public static Iam.Model.ClientmodelListClientPermissionSet? Execute(
            this AdminListClientAvailablePermissions.AdminListClientAvailablePermissionsBuilder builder
        )
        {
            AdminListClientAvailablePermissions op = builder.Build(
            );

            return ((Iam.Wrapper.ClientsConfigV3)builder.WrapperObject!).AdminListClientAvailablePermissions(op);
        }
        public static void Execute(
            this AdminUpdateAvailablePermissionsByModule.AdminUpdateAvailablePermissionsByModuleBuilder builder,
            ClientmodelListUpsertModulesRequest body
        )
        {
            AdminUpdateAvailablePermissionsByModule op = builder.Build(
                body
            );

            ((Iam.Wrapper.ClientsConfigV3)builder.WrapperObject!).AdminUpdateAvailablePermissionsByModule(op);
        }
        public static void Execute(
            this AdminDeleteConfigPermissionsByGroup.AdminDeleteConfigPermissionsByGroupBuilder builder,
            ClientmodelPermissionSetDeleteGroupRequest body
        )
        {
            AdminDeleteConfigPermissionsByGroup op = builder.Build(
                body
            );

            ((Iam.Wrapper.ClientsConfigV3)builder.WrapperObject!).AdminDeleteConfigPermissionsByGroup(op);
        }
        public static Iam.Model.ClientmodelListTemplatesResponse? Execute(
            this AdminListClientTemplates.AdminListClientTemplatesBuilder builder
        )
        {
            AdminListClientTemplates op = builder.Build(
            );

            return ((Iam.Wrapper.ClientsConfigV3)builder.WrapperObject!).AdminListClientTemplates(op);
        }
    }
}