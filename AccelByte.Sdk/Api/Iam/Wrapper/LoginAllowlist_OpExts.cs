// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamLoginAllowlist_OpExts
    {
        public static Iam.Model.ModelLoginAllowlistResponse? Execute(
            this AdminGetLoginAllowlistV3.AdminGetLoginAllowlistV3Builder builder,
            string namespace_
        )
        {
            AdminGetLoginAllowlistV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.LoginAllowlist)builder.WrapperObject!).AdminGetLoginAllowlistV3(op);
        }
        public static async Task<Iam.Model.ModelLoginAllowlistResponse?> ExecuteAsync(
            this AdminGetLoginAllowlistV3.AdminGetLoginAllowlistV3Builder builder,
            string namespace_
        )
        {
            AdminGetLoginAllowlistV3 op = builder.Build(
                namespace_
            );

            return await ((Iam.Wrapper.LoginAllowlist)builder.WrapperObject!).AdminGetLoginAllowlistV3Async(op);
        }
        public static Iam.Model.ModelLoginAllowlistResponse? Execute(
            this AdminUpdateLoginAllowlistV3.AdminUpdateLoginAllowlistV3Builder builder,
            ModelLoginAllowlistRequest body,
            string namespace_
        )
        {
            AdminUpdateLoginAllowlistV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.LoginAllowlist)builder.WrapperObject!).AdminUpdateLoginAllowlistV3(op);
        }
        public static async Task<Iam.Model.ModelLoginAllowlistResponse?> ExecuteAsync(
            this AdminUpdateLoginAllowlistV3.AdminUpdateLoginAllowlistV3Builder builder,
            ModelLoginAllowlistRequest body,
            string namespace_
        )
        {
            AdminUpdateLoginAllowlistV3 op = builder.Build(
                body,
                namespace_
            );

            return await ((Iam.Wrapper.LoginAllowlist)builder.WrapperObject!).AdminUpdateLoginAllowlistV3Async(op);
        }
    }
}