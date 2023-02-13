// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcAdminType_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGetTypeResponse? Execute(
            this AdminGetType.AdminGetTypeBuilder builder,
            string namespace_
        )
        {
            AdminGetType op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminType)builder.WrapperObject!).AdminGetType(op);
        }
        public static Ugc.Model.ModelsCreateTypeResponse? Execute(
            this AdminCreateType.AdminCreateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_
        )
        {
            AdminCreateType op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminType)builder.WrapperObject!).AdminCreateType(op);
        }
        public static Ugc.Model.ModelsCreateTypeResponse? Execute(
            this AdminUpdateType.AdminUpdateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_,
            string typeId
        )
        {
            AdminUpdateType op = builder.Build(
                body,
                namespace_,
                typeId
            );

            return ((Ugc.Wrapper.AdminType)builder.WrapperObject!).AdminUpdateType(op);
        }
        public static void Execute(
            this AdminDeleteType.AdminDeleteTypeBuilder builder,
            string namespace_,
            string typeId
        )
        {
            AdminDeleteType op = builder.Build(
                namespace_,
                typeId
            );

            ((Ugc.Wrapper.AdminType)builder.WrapperObject!).AdminDeleteType(op);
        }
    }
}