// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicUserAction_OpExts
    {
        public static List<Basic.Model.Action>? Execute(
            this GetActions.GetActionsBuilder builder,
            string namespace_
        )
        {
            GetActions op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserAction)builder.WrapperObject!).GetActions(op);
        }

        public static void Execute(
            this BanUsers.BanUsersBuilder builder,
            string namespace_
        )
        {
            BanUsers op = builder.Build(
                namespace_
            );

            ((Basic.Wrapper.UserAction)builder.WrapperObject!).BanUsers(op);
        }

        public static List<Basic.Model.ADTOObjectForEqu8UserBanStatus>? Execute(
            this GetBannedUsers.GetBannedUsersBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            GetBannedUsers op = builder.Build(
                namespace_,
                userIds
            );

            return ((Basic.Wrapper.UserAction)builder.WrapperObject!).GetBannedUsers(op);
        }

        public static void Execute(
            this ReportUser.ReportUserBuilder builder,
            string namespace_
        )
        {
            ReportUser op = builder.Build(
                namespace_
            );

            ((Basic.Wrapper.UserAction)builder.WrapperObject!).ReportUser(op);
        }

        public static Basic.Model.ADTOObjectForEqu8UserStatus? Execute(
            this GetUserStatus.GetUserStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserAction)builder.WrapperObject!).GetUserStatus(op);
        }

        public static void Execute(
            this UnBanUsers.UnBanUsersBuilder builder,
            string namespace_
        )
        {
            UnBanUsers op = builder.Build(
                namespace_
            );

            ((Basic.Wrapper.UserAction)builder.WrapperObject!).UnBanUsers(op);
        }

        public static void Execute(
            this PublicReportUser.PublicReportUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicReportUser op = builder.Build(
                namespace_,
                userId
            );

            ((Basic.Wrapper.UserAction)builder.WrapperObject!).PublicReportUser(op);
        }

    }
}