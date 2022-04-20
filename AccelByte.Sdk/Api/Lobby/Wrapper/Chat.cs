// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Chat
    {
        private readonly AccelByteSDK _sdk;

        public Chat(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PersonalChatHistory.PersonalChatHistoryBuilder PersonalChatHistoryOp
        {
            get { return Operation.PersonalChatHistory.Builder.SetWrapperObject(this); }
        }
        public AdminChatHistory.AdminChatHistoryBuilder AdminChatHistoryOp
        {
            get { return Operation.AdminChatHistory.Builder.SetWrapperObject(this); }
        }
        public GetPersonalChatHistoryV1Public.GetPersonalChatHistoryV1PublicBuilder GetPersonalChatHistoryV1PublicOp
        {
            get { return Operation.GetPersonalChatHistoryV1Public.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.ModelChatMessageResponse>? PersonalChatHistory(PersonalChatHistory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelChatMessageResponse>? AdminChatHistory(AdminChatHistory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelChatMessageResponse>? GetPersonalChatHistoryV1Public(GetPersonalChatHistoryV1Public input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Chat_OperationExtensions
    {
        public static List<Model.ModelChatMessageResponse>? Execute(
            this PersonalChatHistory.PersonalChatHistoryBuilder builder,
            string friendId,
            string namespace_,
            string userId
        )
        {
            PersonalChatHistory op = builder.Build(
                friendId,
                namespace_,
                userId
            );

            return ((Chat)builder.WrapperObject!).PersonalChatHistory(op);
        }

        public static List<Model.ModelChatMessageResponse>? Execute(
            this AdminChatHistory.AdminChatHistoryBuilder builder,
            string friendId,
            string namespace_,
            string userId
        )
        {
            AdminChatHistory op = builder.Build(
                friendId,
                namespace_,
                userId
            );

            return ((Chat)builder.WrapperObject!).AdminChatHistory(op);
        }

        public static List<Model.ModelChatMessageResponse>? Execute(
            this GetPersonalChatHistoryV1Public.GetPersonalChatHistoryV1PublicBuilder builder,
            string friendId,
            string namespace_
        )
        {
            GetPersonalChatHistoryV1Public op = builder.Build(
                friendId,
                namespace_
            );

            return ((Chat)builder.WrapperObject!).GetPersonalChatHistoryV1Public(op);
        }

    }
}