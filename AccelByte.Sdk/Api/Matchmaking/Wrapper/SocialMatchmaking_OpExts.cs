// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class MatchmakingSocialMatchmaking_OpExts
    {
        public static Matchmaking.Model.ModelsUpdatePlayerPlaytimeWeightResponse? Execute(
            this UpdatePlayTimeWeight.UpdatePlayTimeWeightBuilder builder,
            ModelsUpdatePlayTimeWeightRequest body,
            string namespace_
        )
        {
            UpdatePlayTimeWeight op = builder.Build(
                body,
                namespace_
            );

            return ((Matchmaking.Wrapper.SocialMatchmaking)builder.WrapperObject!).UpdatePlayTimeWeight(op);
        }

    }
}