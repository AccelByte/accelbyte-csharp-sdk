// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Player
    {
        private readonly AccelByteSDK _sdk;

        public Player(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetLobbyCCU.AdminGetLobbyCCUBuilder AdminGetLobbyCCUOp
        {
            get { return Operation.AdminGetLobbyCCU.Builder.SetWrapperObject(this); }
        }
        public AdminGetAllPlayerSessionAttribute.AdminGetAllPlayerSessionAttributeBuilder AdminGetAllPlayerSessionAttributeOp
        {
            get { return Operation.AdminGetAllPlayerSessionAttribute.Builder.SetWrapperObject(this); }
        }
        public AdminSetPlayerSessionAttribute.AdminSetPlayerSessionAttributeBuilder AdminSetPlayerSessionAttributeOp
        {
            get { return Operation.AdminSetPlayerSessionAttribute.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerSessionAttribute.AdminGetPlayerSessionAttributeBuilder AdminGetPlayerSessionAttributeOp
        {
            get { return Operation.AdminGetPlayerSessionAttribute.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerBlockedPlayersV1.AdminGetPlayerBlockedPlayersV1Builder AdminGetPlayerBlockedPlayersV1Op
        {
            get { return Operation.AdminGetPlayerBlockedPlayersV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerBlockedByPlayersV1.AdminGetPlayerBlockedByPlayersV1Builder AdminGetPlayerBlockedByPlayersV1Op
        {
            get { return Operation.AdminGetPlayerBlockedByPlayersV1.Builder.SetWrapperObject(this); }
        }
        public AdminBulkBlockPlayersV1.AdminBulkBlockPlayersV1Builder AdminBulkBlockPlayersV1Op
        {
            get { return Operation.AdminBulkBlockPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPlayerBlockedPlayersV1.PublicGetPlayerBlockedPlayersV1Builder PublicGetPlayerBlockedPlayersV1Op
        {
            get { return Operation.PublicGetPlayerBlockedPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPlayerBlockedByPlayersV1.PublicGetPlayerBlockedByPlayersV1Builder PublicGetPlayerBlockedByPlayersV1Op
        {
            get { return Operation.PublicGetPlayerBlockedByPlayersV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetLobbyCcuResponse? AdminGetLobbyCCU(AdminGetLobbyCCU input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerSessionAttributeResponse? AdminGetAllPlayerSessionAttribute(AdminGetAllPlayerSessionAttribute input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSetPlayerSessionAttribute(AdminSetPlayerSessionAttribute input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetPlayerSessionAttributeResponse? AdminGetPlayerSessionAttribute(AdminGetPlayerSessionAttribute input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedUsersResponse? AdminGetPlayerBlockedPlayersV1(AdminGetPlayerBlockedPlayersV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedByUsersResponse? AdminGetPlayerBlockedByPlayersV1(AdminGetPlayerBlockedByPlayersV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminBulkBlockPlayersV1(AdminBulkBlockPlayersV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedUsersResponse? PublicGetPlayerBlockedPlayersV1(PublicGetPlayerBlockedPlayersV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedByUsersResponse? PublicGetPlayerBlockedByPlayersV1(PublicGetPlayerBlockedByPlayersV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}