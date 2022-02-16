// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class PassCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoEnroll")]
        public bool? AutoEnroll { get; set; }
        
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("displayOrder")]
        public int? DisplayOrder { get; set; }
        
        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
        
        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }
        
        [JsonPropertyName("passItemId")]
        public string? PassItemId { get; set; }
        
    }
}