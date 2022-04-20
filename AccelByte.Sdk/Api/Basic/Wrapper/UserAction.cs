// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class UserAction
    {
        private readonly AccelByteSDK _sdk;

        public UserAction(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetActions.GetActionsBuilder GetActionsOp
        {
            get { return Operation.GetActions.Builder.SetWrapperObject(this); }
        }
        public BanUsers.BanUsersBuilder BanUsersOp
        {
            get { return Operation.BanUsers.Builder.SetWrapperObject(this); }
        }
        public GetBannedUsers.GetBannedUsersBuilder GetBannedUsersOp
        {
            get { return Operation.GetBannedUsers.Builder.SetWrapperObject(this); }
        }
        public ReportUser.ReportUserBuilder ReportUserOp
        {
            get { return Operation.ReportUser.Builder.SetWrapperObject(this); }
        }
        public GetUserStatus.GetUserStatusBuilder GetUserStatusOp
        {
            get { return Operation.GetUserStatus.Builder.SetWrapperObject(this); }
        }
        public UnBanUsers.UnBanUsersBuilder UnBanUsersOp
        {
            get { return Operation.UnBanUsers.Builder.SetWrapperObject(this); }
        }
        public PublicReportUser.PublicReportUserBuilder PublicReportUserOp
        {
            get { return Operation.PublicReportUser.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.Action>? GetActions(GetActions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void BanUsers(BanUsers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ADTOObjectForEqu8UserBanStatus>? GetBannedUsers(GetBannedUsers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ReportUser(ReportUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ADTOObjectForEqu8UserStatus? GetUserStatus(GetUserStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UnBanUsers(UnBanUsers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicReportUser(PublicReportUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class UserAction_OperationExtensions
    {
        public static List<Model.Action>? Execute(
            this GetActions.GetActionsBuilder builder,
            string namespace_
        )
        {
            GetActions op = builder.Build(
                namespace_
            );

            return ((UserAction)builder.WrapperObject!).GetActions(op);
        }

        public static void Execute(
            this BanUsers.BanUsersBuilder builder,
            string namespace_
        )
        {
            BanUsers op = builder.Build(
                namespace_
            );

            ((UserAction)builder.WrapperObject!).BanUsers(op);
        }

        public static List<Model.ADTOObjectForEqu8UserBanStatus>? Execute(
            this GetBannedUsers.GetBannedUsersBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            GetBannedUsers op = builder.Build(
                namespace_,
                userIds
            );

            return ((UserAction)builder.WrapperObject!).GetBannedUsers(op);
        }

        public static void Execute(
            this ReportUser.ReportUserBuilder builder,
            string namespace_
        )
        {
            ReportUser op = builder.Build(
                namespace_
            );

            ((UserAction)builder.WrapperObject!).ReportUser(op);
        }

        public static Model.ADTOObjectForEqu8UserStatus? Execute(
            this GetUserStatus.GetUserStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((UserAction)builder.WrapperObject!).GetUserStatus(op);
        }

        public static void Execute(
            this UnBanUsers.UnBanUsersBuilder builder,
            string namespace_
        )
        {
            UnBanUsers op = builder.Build(
                namespace_
            );

            ((UserAction)builder.WrapperObject!).UnBanUsers(op);
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

            ((UserAction)builder.WrapperObject!).PublicReportUser(op);
        }

    }
}