// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelAgeRestrictionRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ageRestriction")]
        public int? AgeRestriction { get; set; }

        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }

    }


}