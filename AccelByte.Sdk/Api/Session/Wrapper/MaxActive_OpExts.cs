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
    public static class SessionMaxActive_OpExts
    {
        public static Session.Model.ModelsMemberActiveSession? Execute(
            this AdminGetMemberActiveSession.AdminGetMemberActiveSessionBuilder builder,
            string name,
            string namespace_,
            string userId
        )
        {
            AdminGetMemberActiveSession op = builder.Build(
                name,
                namespace_,
                userId
            );

            return ((Session.Wrapper.MaxActive)builder.WrapperObject!).AdminGetMemberActiveSession(op);
        }
        public static void Execute(
            this AdminReconcileMaxActiveSession.AdminReconcileMaxActiveSessionBuilder builder,
            ModelsRequestReconcileMaxActiveSession body,
            string name,
            string namespace_
        )
        {
            AdminReconcileMaxActiveSession op = builder.Build(
                body,
                name,
                namespace_
            );

            ((Session.Wrapper.MaxActive)builder.WrapperObject!).AdminReconcileMaxActiveSession(op);
        }
    }
}