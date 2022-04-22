// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class EventlogEventV2_OpExts
    {
        public static Eventlog.Model.ModelsEventResponseV2? Execute(
            this QueryEventStreamHandler.QueryEventStreamHandlerBuilder builder,
            ModelsGenericQueryPayload body,
            string namespace_
        )
        {
            QueryEventStreamHandler op = builder.Build(
                body,
                namespace_
            );

            return ((Eventlog.Wrapper.EventV2)builder.WrapperObject!).QueryEventStreamHandler(op);
        }

        public static Eventlog.Model.ModelsEventResponseV2? Execute(
            this GetEventSpecificUserV2Handler.GetEventSpecificUserV2HandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetEventSpecificUserV2Handler op = builder.Build(
                namespace_,
                userId
            );

            return ((Eventlog.Wrapper.EventV2)builder.WrapperObject!).GetEventSpecificUserV2Handler(op);
        }

        public static Eventlog.Model.ModelsEventResponseV2? Execute(
            this GetPublicEditHistory.GetPublicEditHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPublicEditHistory op = builder.Build(
                namespace_,
                userId
            );

            return ((Eventlog.Wrapper.EventV2)builder.WrapperObject!).GetPublicEditHistory(op);
        }

        public static Eventlog.Model.ModelsEventResponseV2? Execute(
            this GetUserEventsV2Public.GetUserEventsV2PublicBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserEventsV2Public op = builder.Build(
                namespace_,
                userId
            );

            return ((Eventlog.Wrapper.EventV2)builder.WrapperObject!).GetUserEventsV2Public(op);
        }

    }
}