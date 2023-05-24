// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionPlayer_OpExts
    {
        public static List<Session.Model.ApimodelsPlayerAttributesResponseBody>? Execute(
            this AdminQueryPlayerAttributes.AdminQueryPlayerAttributesBuilder builder,
            string namespace_
        )
        {
            AdminQueryPlayerAttributes op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).AdminQueryPlayerAttributes(op);
        }

        public static List<Session.Model.ApimodelsPlayerAttributesResponseBody<T1>>? Execute<T1>(
            this AdminQueryPlayerAttributes.AdminQueryPlayerAttributesBuilder builder,
            string namespace_
        )
        {
            AdminQueryPlayerAttributes op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).AdminQueryPlayerAttributes<T1>(op);
        }
        public static Session.Model.ApimodelsPlayerAttributesResponseBody? Execute(
            this AdminGetPlayerAttributes.AdminGetPlayerAttributesBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerAttributes op = builder.Build(
                namespace_,
                userId
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).AdminGetPlayerAttributes(op);
        }

        public static Session.Model.ApimodelsPlayerAttributesResponseBody<T1>? Execute<T1>(
            this AdminGetPlayerAttributes.AdminGetPlayerAttributesBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerAttributes op = builder.Build(
                namespace_,
                userId
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).AdminGetPlayerAttributes<T1>(op);
        }
        public static Session.Model.ApimodelsPlayersCurrentPlatformResponse? Execute(
            this PublicGetBulkPlayerCurrentPlatform.PublicGetBulkPlayerCurrentPlatformBuilder builder,
            ApimodelsPlayersCurrentPlatformRequest body,
            string namespace_
        )
        {
            PublicGetBulkPlayerCurrentPlatform op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).PublicGetBulkPlayerCurrentPlatform(op);
        }
        public static Session.Model.ApimodelsPlayerAttributesResponseBody? Execute(
            this PublicGetPlayerAttributes.PublicGetPlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PublicGetPlayerAttributes op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).PublicGetPlayerAttributes(op);
        }

        public static Session.Model.ApimodelsPlayerAttributesResponseBody<T1>? Execute<T1>(
            this PublicGetPlayerAttributes.PublicGetPlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PublicGetPlayerAttributes op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).PublicGetPlayerAttributes<T1>(op);
        }
        public static Session.Model.ApimodelsPlayerAttributesResponseBody? Execute(
            this PublicStorePlayerAttributes.PublicStorePlayerAttributesBuilder builder,
            ApimodelsPlayerAttributesRequestBody body,
            string namespace_
        )
        {
            PublicStorePlayerAttributes op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).PublicStorePlayerAttributes(op);
        }

        public static Session.Model.ApimodelsPlayerAttributesResponseBody<T1>? Execute<T1>(
            this PublicStorePlayerAttributes.PublicStorePlayerAttributesBuilder builder,
            ApimodelsPlayerAttributesRequestBody body,
            string namespace_
        )
        {
            PublicStorePlayerAttributes op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Player)builder.WrapperObject!).PublicStorePlayerAttributes<T1>(op);
        }
        public static void Execute(
            this PublicDeletePlayerAttributes.PublicDeletePlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PublicDeletePlayerAttributes op = builder.Build(
                namespace_
            );

            ((Session.Wrapper.Player)builder.WrapperObject!).PublicDeletePlayerAttributes(op);
        }
    }
}