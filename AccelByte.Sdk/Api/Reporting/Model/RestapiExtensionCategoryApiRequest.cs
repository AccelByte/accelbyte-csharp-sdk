// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Reporting.Model
{
    public class RestapiExtensionCategoryApiRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extensionCategory")]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("extensionCategoryName")]
        public string? ExtensionCategoryName { get; set; }

        [JsonPropertyName("serviceSource")]
        public string? ServiceSource { get; set; }

    }


}