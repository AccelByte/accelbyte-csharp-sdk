// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class DtoXboxBPCertValidationResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("expirationDate")]
        public long? ExpirationDate { get; set; }

        [JsonPropertyName("expired")]
        public bool? Expired { get; set; }

    }


}