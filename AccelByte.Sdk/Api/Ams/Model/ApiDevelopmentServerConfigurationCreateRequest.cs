// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiDevelopmentServerConfigurationCreateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("commandLineArguments")]
        public string? CommandLineArguments { get; set; }

        [JsonPropertyName("imageId")]
        public string? ImageId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

    }


}