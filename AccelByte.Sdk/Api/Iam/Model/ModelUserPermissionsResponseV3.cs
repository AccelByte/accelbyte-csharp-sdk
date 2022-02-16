// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPermissionsResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public int? Action { get; set; }
        
        [JsonPropertyName("resource")]
        public string? Resource { get; set; }
        
        [JsonPropertyName("schedAction")]
        public int? SchedAction { get; set; }
        
        [JsonPropertyName("schedCron")]
        public string? SchedCron { get; set; }
        
        [JsonPropertyName("schedRange")]
        public List<string>? SchedRange { get; set; }
        
    }
}