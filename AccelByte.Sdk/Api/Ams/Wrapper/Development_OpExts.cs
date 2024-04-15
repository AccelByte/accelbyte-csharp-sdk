// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class AmsDevelopment_OpExts
    {
        public static Ams.Model.ApiDevelopmentServerConfigurationListResponse? Execute(
            this DevelopmentServerConfigurationList.DevelopmentServerConfigurationListBuilder builder,
            string namespace_
        )
        {
            DevelopmentServerConfigurationList op = builder.Build(
                namespace_
            );

            return ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationList(op);
        }
        public static async Task<Ams.Model.ApiDevelopmentServerConfigurationListResponse?> ExecuteAsync(
            this DevelopmentServerConfigurationList.DevelopmentServerConfigurationListBuilder builder,
            string namespace_
        )
        {
            DevelopmentServerConfigurationList op = builder.Build(
                namespace_
            );

            return await ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationListAsync(op);
        }
        public static Ams.Model.ApiDevelopmentServerConfigurationCreateResponse? Execute(
            this DevelopmentServerConfigurationCreate.DevelopmentServerConfigurationCreateBuilder builder,
            ApiDevelopmentServerConfigurationCreateRequest body,
            string namespace_
        )
        {
            DevelopmentServerConfigurationCreate op = builder.Build(
                body,
                namespace_
            );

            return ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationCreate(op);
        }
        public static async Task<Ams.Model.ApiDevelopmentServerConfigurationCreateResponse?> ExecuteAsync(
            this DevelopmentServerConfigurationCreate.DevelopmentServerConfigurationCreateBuilder builder,
            ApiDevelopmentServerConfigurationCreateRequest body,
            string namespace_
        )
        {
            DevelopmentServerConfigurationCreate op = builder.Build(
                body,
                namespace_
            );

            return await ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationCreateAsync(op);
        }
        public static Ams.Model.ApiDevelopmentServerConfigurationGetResponse? Execute(
            this DevelopmentServerConfigurationGet.DevelopmentServerConfigurationGetBuilder builder,
            string developmentServerConfigID,
            string namespace_
        )
        {
            DevelopmentServerConfigurationGet op = builder.Build(
                developmentServerConfigID,
                namespace_
            );

            return ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationGet(op);
        }
        public static async Task<Ams.Model.ApiDevelopmentServerConfigurationGetResponse?> ExecuteAsync(
            this DevelopmentServerConfigurationGet.DevelopmentServerConfigurationGetBuilder builder,
            string developmentServerConfigID,
            string namespace_
        )
        {
            DevelopmentServerConfigurationGet op = builder.Build(
                developmentServerConfigID,
                namespace_
            );

            return await ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationGetAsync(op);
        }
        public static void Execute(
            this DevelopmentServerConfigurationDelete.DevelopmentServerConfigurationDeleteBuilder builder,
            string developmentServerConfigID,
            string namespace_
        )
        {
            DevelopmentServerConfigurationDelete op = builder.Build(
                developmentServerConfigID,
                namespace_
            );

            ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationDelete(op);
        }
        public static async Task ExecuteAsync(
            this DevelopmentServerConfigurationDelete.DevelopmentServerConfigurationDeleteBuilder builder,
            string developmentServerConfigID,
            string namespace_
        )
        {
            DevelopmentServerConfigurationDelete op = builder.Build(
                developmentServerConfigID,
                namespace_
            );

            await ((Ams.Wrapper.Development)builder.WrapperObject!).DevelopmentServerConfigurationDeleteAsync(op);
        }
    }
}