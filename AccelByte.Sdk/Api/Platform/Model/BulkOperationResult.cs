// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BulkOperationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affected")]
        public int? Affected { get; set; }
        
    }
}