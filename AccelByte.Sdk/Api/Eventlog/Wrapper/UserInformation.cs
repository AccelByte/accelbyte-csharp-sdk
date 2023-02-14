// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class UserInformation
    {
        private readonly AccelByteSDK _sdk;

        public UserInformation(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserActivitiesHandler.GetUserActivitiesHandlerBuilder GetUserActivitiesHandlerOp
        {
            get { return Operation.GetUserActivitiesHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteUserActivitiesHandler.DeleteUserActivitiesHandlerBuilder DeleteUserActivitiesHandlerOp
        {
            get { return Operation.DeleteUserActivitiesHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public LastUserActivityTimeHandler.LastUserActivityTimeHandlerBuilder LastUserActivityTimeHandlerOp
        {
            get { return Operation.LastUserActivityTimeHandler.Builder.SetWrapperObject(this); }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetUserActivitiesHandler(GetUserActivitiesHandler input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void DeleteUserActivitiesHandler(DeleteUserActivitiesHandler input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsUserLastActivity? LastUserActivityTimeHandler(LastUserActivityTimeHandler input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}