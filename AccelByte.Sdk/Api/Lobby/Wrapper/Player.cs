// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

    public static class Player_OperationExtensions
    {
        public static Model.ModelsGetLobbyCcuResponse? Execute(
            this AdminGetLobbyCCU.AdminGetLobbyCCUBuilder builder,
            string namespace_
        )
        {
            AdminGetLobbyCCU op = builder.Build(
                namespace_
            );

            return ((Player)builder.WrapperObject!).AdminGetLobbyCCU(op);
        }

        public static Model.ModelsGetAllPlayerSessionAttributeResponse? Execute(
            this AdminGetAllPlayerSessionAttribute.AdminGetAllPlayerSessionAttributeBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetAllPlayerSessionAttribute op = builder.Build(
                namespace_,
                userId
            );

            return ((Player)builder.WrapperObject!).AdminGetAllPlayerSessionAttribute(op);
        }

        public static void Execute(
            this AdminSetPlayerSessionAttribute.AdminSetPlayerSessionAttributeBuilder builder,
            ModelsSetPlayerSessionAttributeRequest body,
            string namespace_,
            string userId
        )
        {
            AdminSetPlayerSessionAttribute op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Player)builder.WrapperObject!).AdminSetPlayerSessionAttribute(op);
        }

        public static Model.ModelsGetPlayerSessionAttributeResponse? Execute(
            this AdminGetPlayerSessionAttribute.AdminGetPlayerSessionAttributeBuilder builder,
            string attribute,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerSessionAttribute op = builder.Build(
                attribute,
                namespace_,
                userId
            );

            return ((Player)builder.WrapperObject!).AdminGetPlayerSessionAttribute(op);
        }

        public static Model.ModelsGetAllPlayerBlockedUsersResponse? Execute(
            this AdminGetPlayerBlockedPlayersV1.AdminGetPlayerBlockedPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerBlockedPlayersV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Player)builder.WrapperObject!).AdminGetPlayerBlockedPlayersV1(op);
        }

        public static Model.ModelsGetAllPlayerBlockedByUsersResponse? Execute(
            this AdminGetPlayerBlockedByPlayersV1.AdminGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerBlockedByPlayersV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Player)builder.WrapperObject!).AdminGetPlayerBlockedByPlayersV1(op);
        }

        public static void Execute(
            this AdminBulkBlockPlayersV1.AdminBulkBlockPlayersV1Builder builder,
            ModelsListBlockedPlayerRequest body,
            string namespace_,
            string userId
        )
        {
            AdminBulkBlockPlayersV1 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Player)builder.WrapperObject!).AdminBulkBlockPlayersV1(op);
        }

        public static Model.ModelsGetAllPlayerBlockedUsersResponse? Execute(
            this PublicGetPlayerBlockedPlayersV1.PublicGetPlayerBlockedPlayersV1Builder builder,
            string namespace_
        )
        {
            PublicGetPlayerBlockedPlayersV1 op = builder.Build(
                namespace_
            );

            return ((Player)builder.WrapperObject!).PublicGetPlayerBlockedPlayersV1(op);
        }

        public static Model.ModelsGetAllPlayerBlockedByUsersResponse? Execute(
            this PublicGetPlayerBlockedByPlayersV1.PublicGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_
        )
        {
            PublicGetPlayerBlockedByPlayersV1 op = builder.Build(
                namespace_
            );

            return ((Player)builder.WrapperObject!).PublicGetPlayerBlockedByPlayersV1(op);
        }

    }
}