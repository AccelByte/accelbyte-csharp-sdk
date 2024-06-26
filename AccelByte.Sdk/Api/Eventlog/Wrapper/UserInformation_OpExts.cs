// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class EventlogUserInformation_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetUserActivitiesHandler.GetUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId,
            long pageSize
        )
        {
            GetUserActivitiesHandler op = builder.Build(
                namespace_,
                userId,
                pageSize
            );

            return ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).GetUserActivitiesHandler(op);
        }
        public static async Task<Eventlog.Model.ModelsEventResponse?> ExecuteAsync(
            this GetUserActivitiesHandler.GetUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId,
            long pageSize
        )
        {
            GetUserActivitiesHandler op = builder.Build(
                namespace_,
                userId,
                pageSize
            );

            return await ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).GetUserActivitiesHandlerAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static void Execute(
            this DeleteUserActivitiesHandler.DeleteUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserActivitiesHandler op = builder.Build(
                namespace_,
                userId
            );

            ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).DeleteUserActivitiesHandler(op);
        }
        public static async Task ExecuteAsync(
            this DeleteUserActivitiesHandler.DeleteUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserActivitiesHandler op = builder.Build(
                namespace_,
                userId
            );

            await ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).DeleteUserActivitiesHandlerAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsUserLastActivity? Execute(
            this LastUserActivityTimeHandler.LastUserActivityTimeHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            LastUserActivityTimeHandler op = builder.Build(
                namespace_,
                userId
            );

            return ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).LastUserActivityTimeHandler(op);
        }
        public static async Task<Eventlog.Model.ModelsUserLastActivity?> ExecuteAsync(
            this LastUserActivityTimeHandler.LastUserActivityTimeHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            LastUserActivityTimeHandler op = builder.Build(
                namespace_,
                userId
            );

            return await ((Eventlog.Wrapper.UserInformation)builder.WrapperObject!).LastUserActivityTimeHandlerAsync(op);
        }
    }
}