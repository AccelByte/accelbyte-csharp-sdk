// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
        public AdminGetBulkPlayerBlockedPlayersV1.AdminGetBulkPlayerBlockedPlayersV1Builder AdminGetBulkPlayerBlockedPlayersV1Op
        {
            get { return Operation.AdminGetBulkPlayerBlockedPlayersV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminGetAllPlayerSessionAttribute.AdminGetAllPlayerSessionAttributeBuilder AdminGetAllPlayerSessionAttributeOp
        {
            get { return Operation.AdminGetAllPlayerSessionAttribute.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminSetPlayerSessionAttribute.AdminSetPlayerSessionAttributeBuilder AdminSetPlayerSessionAttributeOp
        {
            get { return Operation.AdminSetPlayerSessionAttribute.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
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
        public AdminBulkUnblockPlayersV1.AdminBulkUnblockPlayersV1Builder AdminBulkUnblockPlayersV1Op
        {
            get { return Operation.AdminBulkUnblockPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicPlayerBlockPlayersV1.PublicPlayerBlockPlayersV1Builder PublicPlayerBlockPlayersV1Op
        {
            get { return Operation.PublicPlayerBlockPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPlayerBlockedPlayersV1.PublicGetPlayerBlockedPlayersV1Builder PublicGetPlayerBlockedPlayersV1Op
        {
            get { return Operation.PublicGetPlayerBlockedPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetPlayerBlockedByPlayersV1.PublicGetPlayerBlockedByPlayersV1Builder PublicGetPlayerBlockedByPlayersV1Op
        {
            get { return Operation.PublicGetPlayerBlockedByPlayersV1.Builder.SetWrapperObject(this); }
        }
        public PublicUnblockPlayerV1.PublicUnblockPlayerV1Builder PublicUnblockPlayerV1Op
        {
            get { return Operation.PublicUnblockPlayerV1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsGetLobbyCcuResponse? AdminGetLobbyCCU(AdminGetLobbyCCU input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLobbyCcuResponse?> AdminGetLobbyCCUAsync(AdminGetLobbyCCU input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetBulkAllPlayerBlockedUsersResponse? AdminGetBulkPlayerBlockedPlayersV1(AdminGetBulkPlayerBlockedPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetBulkAllPlayerBlockedUsersResponse?> AdminGetBulkPlayerBlockedPlayersV1Async(AdminGetBulkPlayerBlockedPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsGetAllPlayerSessionAttributeResponse? AdminGetAllPlayerSessionAttribute(AdminGetAllPlayerSessionAttribute input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllPlayerSessionAttributeResponse?> AdminGetAllPlayerSessionAttributeAsync(AdminGetAllPlayerSessionAttribute input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void AdminSetPlayerSessionAttribute(AdminSetPlayerSessionAttribute input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminSetPlayerSessionAttributeAsync(AdminSetPlayerSessionAttribute input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsGetPlayerSessionAttributeResponse? AdminGetPlayerSessionAttribute(AdminGetPlayerSessionAttribute input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetPlayerSessionAttributeResponse?> AdminGetPlayerSessionAttributeAsync(AdminGetPlayerSessionAttribute input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.ModelsGetAllPlayerBlockedUsersResponse? AdminGetPlayerBlockedPlayersV1(AdminGetPlayerBlockedPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllPlayerBlockedUsersResponse?> AdminGetPlayerBlockedPlayersV1Async(AdminGetPlayerBlockedPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedByUsersResponse? AdminGetPlayerBlockedByPlayersV1(AdminGetPlayerBlockedByPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllPlayerBlockedByUsersResponse?> AdminGetPlayerBlockedByPlayersV1Async(AdminGetPlayerBlockedByPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminBulkBlockPlayersV1(AdminBulkBlockPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminBulkBlockPlayersV1Async(AdminBulkBlockPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminBulkUnblockPlayersV1(AdminBulkUnblockPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminBulkUnblockPlayersV1Async(AdminBulkUnblockPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPlayerBlockPlayersV1(PublicPlayerBlockPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicPlayerBlockPlayersV1Async(PublicPlayerBlockPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedUsersResponse? PublicGetPlayerBlockedPlayersV1(PublicGetPlayerBlockedPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllPlayerBlockedUsersResponse?> PublicGetPlayerBlockedPlayersV1Async(PublicGetPlayerBlockedPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllPlayerBlockedByUsersResponse? PublicGetPlayerBlockedByPlayersV1(PublicGetPlayerBlockedByPlayersV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllPlayerBlockedByUsersResponse?> PublicGetPlayerBlockedByPlayersV1Async(PublicGetPlayerBlockedByPlayersV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUnblockPlayerV1(PublicUnblockPlayerV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicUnblockPlayerV1Async(PublicUnblockPlayerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}