// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyChat_OpExts
    {
        public static List<Lobby.Model.ModelChatMessageResponse>? Execute(
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

            return ((Lobby.Wrapper.Chat)builder.WrapperObject!).PersonalChatHistory(op);
        }

        public static List<Lobby.Model.ModelChatMessageResponse>? Execute(
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

            return ((Lobby.Wrapper.Chat)builder.WrapperObject!).AdminChatHistory(op);
        }

        public static List<Lobby.Model.ModelChatMessageResponse>? Execute(
            this GetPersonalChatHistoryV1Public.GetPersonalChatHistoryV1PublicBuilder builder,
            string friendId,
            string namespace_
        )
        {
            GetPersonalChatHistoryV1Public op = builder.Build(
                friendId,
                namespace_
            );

            return ((Lobby.Wrapper.Chat)builder.WrapperObject!).GetPersonalChatHistoryV1Public(op);
        }

    }
}