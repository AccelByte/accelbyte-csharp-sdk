// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformSessionPlatform_OpExts
    {
        public static Dictionary<string, object>? Execute(
            this RegisterXblSessions.RegisterXblSessionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            RegisterXblSessions op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.SessionPlatform)builder.WrapperObject!).RegisterXblSessions(op);
        }
        public static async Task<Dictionary<string, object>?> ExecuteAsync(
            this RegisterXblSessions.RegisterXblSessionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            RegisterXblSessions op = builder.Build(
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.SessionPlatform)builder.WrapperObject!).RegisterXblSessionsAsync(op);
        }
    }
}