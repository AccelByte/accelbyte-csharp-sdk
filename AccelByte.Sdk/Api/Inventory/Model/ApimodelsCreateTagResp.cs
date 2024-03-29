// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsCreateTagResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("owner")]
        [JsonStringEnum]
        public ApimodelsCreateTagRespOwner? Owner { get; set; }

    }



    public class ApimodelsCreateTagRespOwner : StringEnum<ApimodelsCreateTagRespOwner>
    {
        public static readonly ApimodelsCreateTagRespOwner CLIENT
            = new ApimodelsCreateTagRespOwner("CLIENT");

        public static readonly ApimodelsCreateTagRespOwner SERVER
            = new ApimodelsCreateTagRespOwner("SERVER");


        public static implicit operator ApimodelsCreateTagRespOwner(string value)
        {
            return NewValue(value);
        }

        public ApimodelsCreateTagRespOwner(string enumValue)
            : base(enumValue)
        {

        }
    }
}