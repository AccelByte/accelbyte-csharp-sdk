// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventDescriptions
    {
        private readonly AccelByteSDK _sdk;

        public EventDescriptions(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AgentTypeDescriptionHandler.AgentTypeDescriptionHandlerBuilder AgentTypeDescriptionHandlerOp
        {
            get { return Operation.AgentTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificAgentTypeDescriptionHandler.SpecificAgentTypeDescriptionHandlerBuilder SpecificAgentTypeDescriptionHandlerOp
        {
            get { return Operation.SpecificAgentTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventIDDescriptionHandler.EventIDDescriptionHandlerBuilder EventIDDescriptionHandlerOp
        {
            get { return Operation.EventIDDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventIDDescriptionHandler.SpecificEventIDDescriptionHandlerBuilder SpecificEventIDDescriptionHandlerOp
        {
            get { return Operation.SpecificEventIDDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventLevelDescriptionHandler.EventLevelDescriptionHandlerBuilder EventLevelDescriptionHandlerOp
        {
            get { return Operation.EventLevelDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventLevelDescriptionHandler.SpecificEventLevelDescriptionHandlerBuilder SpecificEventLevelDescriptionHandlerOp
        {
            get { return Operation.SpecificEventLevelDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventTypeDescriptionHandler.EventTypeDescriptionHandlerBuilder EventTypeDescriptionHandlerOp
        {
            get { return Operation.EventTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventTypeDescriptionHandler.SpecificEventTypeDescriptionHandlerBuilder SpecificEventTypeDescriptionHandlerOp
        {
            get { return Operation.SpecificEventTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UXNameDescriptionHandler.UXNameDescriptionHandlerBuilder UXNameDescriptionHandlerOp
        {
            get { return Operation.UXNameDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificUXDescriptionHandler.SpecificUXDescriptionHandlerBuilder SpecificUXDescriptionHandlerOp
        {
            get { return Operation.SpecificUXDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleAgentType? AgentTypeDescriptionHandler(AgentTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleAgentType? SpecificAgentTypeDescriptionHandler(SpecificAgentTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventID? EventIDDescriptionHandler(EventIDDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventID? SpecificEventIDDescriptionHandler(SpecificEventIDDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventLevel? EventLevelDescriptionHandler(EventLevelDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventLevel? SpecificEventLevelDescriptionHandler(SpecificEventLevelDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventType? EventTypeDescriptionHandler(EventTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventType? SpecificEventTypeDescriptionHandler(SpecificEventTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleUX? UXNameDescriptionHandler(UXNameDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleUX? SpecificUXDescriptionHandler(SpecificUXDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }
}