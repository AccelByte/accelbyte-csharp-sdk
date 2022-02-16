// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class BloomFilterJSON : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bits")]
        public List<long>? Bits { get; set; }
        
        [JsonPropertyName("k")]
        public long? K { get; set; }
        
        [JsonPropertyName("m")]
        public long? M { get; set; }
        
    }
}