// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListBulkUserBanResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failedBans")]
        public List<ModelFailedBanUnbanUserV3>? FailedBans { get; set; }

        [JsonPropertyName("successBans")]
        public List<ModelUserBanResponseV3>? SuccessBans { get; set; }

    }


}