// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsGetInboxMessagesResponseData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("category")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Category { get; set; }

        [JsonPropertyName("createdAt")]
        public long? CreatedAt { get; set; }

        [JsonPropertyName("expiredAt")]
        public long? ExpiredAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("message")]
        public Dictionary<string, object>? Message { get; set; }

        [JsonPropertyName("scope")]
        [JsonStringEnum]
        public ModelsGetInboxMessagesResponseDataScope? Scope { get; set; }

        [JsonPropertyName("senderId")]
        public string? SenderId { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ModelsGetInboxMessagesResponseDataStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }

    public class ModelsGetInboxMessagesResponseData<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("category")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Category { get; set; }

        [JsonPropertyName("createdAt")]
        public long? CreatedAt { get; set; }

        [JsonPropertyName("expiredAt")]
        public long? ExpiredAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("message")]
        public T1? Message { get; set; }

        [JsonPropertyName("scope")]
        [JsonStringEnum]
        public ModelsGetInboxMessagesResponseDataScope? Scope { get; set; }

        [JsonPropertyName("senderId")]
        public string? SenderId { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ModelsGetInboxMessagesResponseDataStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }


    public class ModelsGetInboxMessagesResponseDataScope : StringEnum<ModelsGetInboxMessagesResponseDataScope>
    {
        public static readonly ModelsGetInboxMessagesResponseDataScope NAMESPACE
            = new ModelsGetInboxMessagesResponseDataScope("NAMESPACE");

        public static readonly ModelsGetInboxMessagesResponseDataScope USER
            = new ModelsGetInboxMessagesResponseDataScope("USER");


        public static implicit operator ModelsGetInboxMessagesResponseDataScope(string value)
        {
            return NewValue(value);
        }

        public ModelsGetInboxMessagesResponseDataScope(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelsGetInboxMessagesResponseDataStatus : StringEnum<ModelsGetInboxMessagesResponseDataStatus>
    {
        public static readonly ModelsGetInboxMessagesResponseDataStatus DRAFT
            = new ModelsGetInboxMessagesResponseDataStatus("DRAFT");

        public static readonly ModelsGetInboxMessagesResponseDataStatus SENT
            = new ModelsGetInboxMessagesResponseDataStatus("SENT");

        public static readonly ModelsGetInboxMessagesResponseDataStatus UNSENT
            = new ModelsGetInboxMessagesResponseDataStatus("UNSENT");


        public static implicit operator ModelsGetInboxMessagesResponseDataStatus(string value)
        {
            return NewValue(value);
        }

        public ModelsGetInboxMessagesResponseDataStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}