// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionNativeSession_OpExts
    {
        public static Session.Model.ApimodelsNativeSessionPagingResponse? Execute(
            this AdminGetListNativeSession.AdminGetListNativeSessionBuilder builder,
            string namespace_
        )
        {
            AdminGetListNativeSession op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.NativeSession)builder.WrapperObject!).AdminGetListNativeSession(op);
        }
        public static async Task<Session.Model.ApimodelsNativeSessionPagingResponse?> ExecuteAsync(
            this AdminGetListNativeSession.AdminGetListNativeSessionBuilder builder,
            string namespace_
        )
        {
            AdminGetListNativeSession op = builder.Build(
                namespace_
            );

            return await ((Session.Wrapper.NativeSession)builder.WrapperObject!).AdminGetListNativeSessionAsync(op);
        }
    }
}