// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Admin
    {
        private readonly AccelByteSDK _sdk;

        public Admin(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListServer.ListServerBuilder ListServerOp
        {
            get { return Operation.ListServer.Builder.SetWrapperObject(this); }
        }
        public CountServer.CountServerBuilder CountServerOp
        {
            get { return Operation.CountServer.Builder.SetWrapperObject(this); }
        }
        public CountServerDetailed.CountServerDetailedBuilder CountServerDetailedOp
        {
            get { return Operation.CountServerDetailed.Builder.SetWrapperObject(this); }
        }
        public ListLocalServer.ListLocalServerBuilder ListLocalServerOp
        {
            get { return Operation.ListLocalServer.Builder.SetWrapperObject(this); }
        }
        public DeleteLocalServer.DeleteLocalServerBuilder DeleteLocalServerOp
        {
            get { return Operation.DeleteLocalServer.Builder.SetWrapperObject(this); }
        }
        public GetServer.GetServerBuilder GetServerOp
        {
            get { return Operation.GetServer.Builder.SetWrapperObject(this); }
        }
        public DeleteServer.DeleteServerBuilder DeleteServerOp
        {
            get { return Operation.DeleteServer.Builder.SetWrapperObject(this); }
        }
        public GetServerLogs.GetServerLogsBuilder GetServerLogsOp
        {
            get { return Operation.GetServerLogs.Builder.SetWrapperObject(this); }
        }
        public ListSession.ListSessionBuilder ListSessionOp
        {
            get { return Operation.ListSession.Builder.SetWrapperObject(this); }
        }
        public CountSession.CountSessionBuilder CountSessionOp
        {
            get { return Operation.CountSession.Builder.SetWrapperObject(this); }
        }
        public DeleteSession.DeleteSessionBuilder DeleteSessionOp
        {
            get { return Operation.DeleteSession.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListServerResponse? ListServer(ListServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountServerResponse? CountServer(CountServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDetailedCountServerResponse? CountServerDetailed(CountServerDetailed input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListLocalServer(ListLocalServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLocalServer(DeleteLocalServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServer? GetServer(GetServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteServer(DeleteServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServerLogs? GetServerLogs(GetServerLogs input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListSessionResponse? ListSession(ListSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountSessionResponse? CountSession(CountSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSession(DeleteSession input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Admin_OperationExtensions
    {
        public static Model.ModelsListServerResponse? Execute(
            this ListServer.ListServerBuilder builder,
            string namespace_
        )
        {
            ListServer op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).ListServer(op);
        }

        public static Model.ModelsCountServerResponse? Execute(
            this CountServer.CountServerBuilder builder,
            string namespace_
        )
        {
            CountServer op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).CountServer(op);
        }

        public static Model.ModelsDetailedCountServerResponse? Execute(
            this CountServerDetailed.CountServerDetailedBuilder builder,
            string namespace_
        )
        {
            CountServerDetailed op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).CountServerDetailed(op);
        }

        public static Model.ModelsListServerResponse? Execute(
            this ListLocalServer.ListLocalServerBuilder builder,
            string namespace_
        )
        {
            ListLocalServer op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).ListLocalServer(op);
        }

        public static void Execute(
            this DeleteLocalServer.DeleteLocalServerBuilder builder,
            string name,
            string namespace_
        )
        {
            DeleteLocalServer op = builder.Build(
                name,
                namespace_
            );

            ((Admin)builder.WrapperObject!).DeleteLocalServer(op);
        }

        public static Model.ModelsServer? Execute(
            this GetServer.GetServerBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServer op = builder.Build(
                namespace_,
                podName
            );

            return ((Admin)builder.WrapperObject!).GetServer(op);
        }

        public static void Execute(
            this DeleteServer.DeleteServerBuilder builder,
            string namespace_,
            string podName
        )
        {
            DeleteServer op = builder.Build(
                namespace_,
                podName
            );

            ((Admin)builder.WrapperObject!).DeleteServer(op);
        }

        public static Model.ModelsServerLogs? Execute(
            this GetServerLogs.GetServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            GetServerLogs op = builder.Build(
                namespace_,
                podName
            );

            return ((Admin)builder.WrapperObject!).GetServerLogs(op);
        }

        public static Model.ModelsListSessionResponse? Execute(
            this ListSession.ListSessionBuilder builder,
            string namespace_
        )
        {
            ListSession op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).ListSession(op);
        }

        public static Model.ModelsCountSessionResponse? Execute(
            this CountSession.CountSessionBuilder builder,
            string namespace_
        )
        {
            CountSession op = builder.Build(
                namespace_
            );

            return ((Admin)builder.WrapperObject!).CountSession(op);
        }

        public static void Execute(
            this DeleteSession.DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            DeleteSession op = builder.Build(
                namespace_,
                sessionID
            );

            ((Admin)builder.WrapperObject!).DeleteSession(op);
        }

    }
}