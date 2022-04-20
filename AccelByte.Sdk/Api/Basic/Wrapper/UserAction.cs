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
}