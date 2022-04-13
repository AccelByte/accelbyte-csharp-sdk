// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TaxResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enableTax")]
        public bool? EnableTax { get; set; }

        [JsonPropertyName("formattedTax")]
        public string? FormattedTax { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("tax")]
        public int? Tax { get; set; }

    }
}