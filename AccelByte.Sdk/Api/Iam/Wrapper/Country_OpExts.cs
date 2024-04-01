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
    public static class IamCountry_OpExts
    {
        public static List<Iam.Model.ModelCountryResponse>? Execute(
            this AdminGetCountryListV3.AdminGetCountryListV3Builder builder,
            string namespace_
        )
        {
            AdminGetCountryListV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Country)builder.WrapperObject!).AdminGetCountryListV3(op);
        }
        public static async Task<List<Iam.Model.ModelCountryResponse>?> ExecuteAsync(
            this AdminGetCountryListV3.AdminGetCountryListV3Builder builder,
            string namespace_
        )
        {
            AdminGetCountryListV3 op = builder.Build(
                namespace_
            );

            return await ((Iam.Wrapper.Country)builder.WrapperObject!).AdminGetCountryListV3Async(op);
        }
        public static Iam.Model.ModelCountryBlacklistResponse? Execute(
            this AdminGetCountryBlacklistV3.AdminGetCountryBlacklistV3Builder builder,
            string namespace_
        )
        {
            AdminGetCountryBlacklistV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Country)builder.WrapperObject!).AdminGetCountryBlacklistV3(op);
        }
        public static async Task<Iam.Model.ModelCountryBlacklistResponse?> ExecuteAsync(
            this AdminGetCountryBlacklistV3.AdminGetCountryBlacklistV3Builder builder,
            string namespace_
        )
        {
            AdminGetCountryBlacklistV3 op = builder.Build(
                namespace_
            );

            return await ((Iam.Wrapper.Country)builder.WrapperObject!).AdminGetCountryBlacklistV3Async(op);
        }
        public static void Execute(
            this AdminAddCountryBlacklistV3.AdminAddCountryBlacklistV3Builder builder,
            ModelCountryBlacklistRequest body,
            string namespace_
        )
        {
            AdminAddCountryBlacklistV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Country)builder.WrapperObject!).AdminAddCountryBlacklistV3(op);
        }
        public static async Task ExecuteAsync(
            this AdminAddCountryBlacklistV3.AdminAddCountryBlacklistV3Builder builder,
            ModelCountryBlacklistRequest body,
            string namespace_
        )
        {
            AdminAddCountryBlacklistV3 op = builder.Build(
                body,
                namespace_
            );

            await ((Iam.Wrapper.Country)builder.WrapperObject!).AdminAddCountryBlacklistV3Async(op);
        }
        public static List<Iam.Model.ModelCountryResponse>? Execute(
            this PublicGetCountryListV3.PublicGetCountryListV3Builder builder,
            string namespace_
        )
        {
            PublicGetCountryListV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Country)builder.WrapperObject!).PublicGetCountryListV3(op);
        }
        public static async Task<List<Iam.Model.ModelCountryResponse>?> ExecuteAsync(
            this PublicGetCountryListV3.PublicGetCountryListV3Builder builder,
            string namespace_
        )
        {
            PublicGetCountryListV3 op = builder.Build(
                namespace_
            );

            return await ((Iam.Wrapper.Country)builder.WrapperObject!).PublicGetCountryListV3Async(op);
        }
    }
}