// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class Event
    {
        private readonly AccelByteSDK _sdk;

        public Event(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByNamespaceHandler.GetEventByNamespaceHandlerBuilder GetEventByNamespaceHandlerOp
        {
            get { return Operation.GetEventByNamespaceHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public PostEventHandler.PostEventHandlerBuilder PostEventHandlerOp
        {
            get { return Operation.PostEventHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByEventIDHandler.GetEventByEventIDHandlerBuilder GetEventByEventIDHandlerOp
        {
            get { return Operation.GetEventByEventIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByEventTypeHandler.GetEventByEventTypeHandlerBuilder GetEventByEventTypeHandlerOp
        {
            get { return Operation.GetEventByEventTypeHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByEventTypeAndEventIDHandler.GetEventByEventTypeAndEventIDHandlerBuilder GetEventByEventTypeAndEventIDHandlerOp
        {
            get { return Operation.GetEventByEventTypeAndEventIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByUserIDHandler.GetEventByUserIDHandlerBuilder GetEventByUserIDHandlerOp
        {
            get { return Operation.GetEventByUserIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByUserIDAndEventIDHandler.GetEventByUserIDAndEventIDHandlerBuilder GetEventByUserIDAndEventIDHandlerOp
        {
            get { return Operation.GetEventByUserIDAndEventIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByUserIDAndEventTypeHandler.GetEventByUserIDAndEventTypeHandlerBuilder GetEventByUserIDAndEventTypeHandlerOp
        {
            get { return Operation.GetEventByUserIDAndEventTypeHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetEventByUserEventIDAndEventTypeHandler.GetEventByUserEventIDAndEventTypeHandlerBuilder GetEventByUserEventIDAndEventTypeHandlerOp
        {
            get { return Operation.GetEventByUserEventIDAndEventTypeHandler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByNamespaceHandler(GetEventByNamespaceHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void PostEventHandler(PostEventHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventIDHandler(GetEventByEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventTypeHandler(GetEventByEventTypeHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByEventTypeAndEventIDHandler(GetEventByEventTypeAndEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDHandler(GetEventByUserIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDAndEventIDHandler(GetEventByUserIDAndEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserIDAndEventTypeHandler(GetEventByUserIDAndEventTypeHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventResponse? GetEventByUserEventIDAndEventTypeHandler(GetEventByUserEventIDAndEventTypeHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }

    public static class Event_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByNamespaceHandler.GetEventByNamespaceHandlerBuilder builder,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByNamespaceHandler op = builder.Build(
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByNamespaceHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this PostEventHandler.PostEventHandlerBuilder builder,
            ModelsEvent body,
            string namespace_
        )
        {
            PostEventHandler op = builder.Build(
                body,
                namespace_
            );

            ((Event)builder.WrapperObject!).PostEventHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByEventIDHandler.GetEventByEventIDHandlerBuilder builder,
            double eventId,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventIDHandler op = builder.Build(
                eventId,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByEventTypeHandler.GetEventByEventTypeHandlerBuilder builder,
            double eventType,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventTypeHandler op = builder.Build(
                eventType,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByEventTypeHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByEventTypeAndEventIDHandler.GetEventByEventTypeAndEventIDHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventTypeAndEventIDHandler op = builder.Build(
                eventId,
                eventType,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByEventTypeAndEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByUserIDHandler.GetEventByUserIDHandlerBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDHandler op = builder.Build(
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByUserIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByUserIDAndEventIDHandler.GetEventByUserIDAndEventIDHandlerBuilder builder,
            double eventId,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDAndEventIDHandler op = builder.Build(
                eventId,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByUserIDAndEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByUserIDAndEventTypeHandler.GetEventByUserIDAndEventTypeHandlerBuilder builder,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDAndEventTypeHandler op = builder.Build(
                eventType,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByUserIDAndEventTypeHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventResponse? Execute(
            this GetEventByUserEventIDAndEventTypeHandler.GetEventByUserEventIDAndEventTypeHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserEventIDAndEventTypeHandler op = builder.Build(
                eventId,
                eventType,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Event)builder.WrapperObject!).GetEventByUserEventIDAndEventTypeHandler(op);
        }

    }
}