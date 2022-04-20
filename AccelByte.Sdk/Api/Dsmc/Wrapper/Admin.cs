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
}