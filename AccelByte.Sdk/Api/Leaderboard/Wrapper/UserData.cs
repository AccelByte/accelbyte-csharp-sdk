// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class UserData {
        private readonly AccelByteSDK _sdk;

        public UserData(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsGetAllUserLeaderboardsResp? GetUserLeaderboardRankingsAdminV1(GetUserLeaderboardRankingsAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}