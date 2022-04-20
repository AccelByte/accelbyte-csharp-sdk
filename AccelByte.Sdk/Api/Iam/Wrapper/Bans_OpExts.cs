// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamBans_OpExts
    {
        public static Iam.Model.AccountcommonBans? Execute(
            this GetBansType.GetBansTypeBuilder builder
        )
        {
            GetBansType op = builder.Build(
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).GetBansType(op);
        }

        public static Iam.Model.AccountcommonBanReasons? Execute(
            this GetListBanReason.GetListBanReasonBuilder builder
        )
        {
            GetListBanReason op = builder.Build(
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).GetListBanReason(op);
        }

        public static Iam.Model.AccountcommonBansV3? Execute(
            this AdminGetBansTypeV3.AdminGetBansTypeV3Builder builder
        )
        {
            AdminGetBansTypeV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).AdminGetBansTypeV3(op);
        }

        public static Iam.Model.AccountcommonBanReasonsV3? Execute(
            this AdminGetListBanReasonV3.AdminGetListBanReasonV3Builder builder
        )
        {
            AdminGetListBanReasonV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).AdminGetListBanReasonV3(op);
        }

        public static Iam.Model.ModelGetUserBanV3Response? Execute(
            this AdminGetBannedUsersV3.AdminGetBannedUsersV3Builder builder,
            string namespace_
        )
        {
            AdminGetBannedUsersV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).AdminGetBannedUsersV3(op);
        }

        public static Iam.Model.AccountcommonBansV3? Execute(
            this AdminGetBansTypeWithNamespaceV3.AdminGetBansTypeWithNamespaceV3Builder builder,
            string namespace_
        )
        {
            AdminGetBansTypeWithNamespaceV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Bans)builder.WrapperObject!).AdminGetBansTypeWithNamespaceV3(op);
        }

    }
}