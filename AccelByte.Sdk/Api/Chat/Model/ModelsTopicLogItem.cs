// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsTopicLogItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public long? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("senderId")]
        public string? SenderId { get; set; }

        [JsonPropertyName("topicId")]
        public string? TopicId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public ModelsTopicLogItemType? Type { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class ModelsTopicLogItemType : StringEnum<ModelsTopicLogItemType>
    {
        public static readonly ModelsTopicLogItemType TOPICCREATE
            = new ModelsTopicLogItemType("TOPIC_CREATE");

        public static readonly ModelsTopicLogItemType TOPICDELETE
            = new ModelsTopicLogItemType("TOPIC_DELETE");

        public static readonly ModelsTopicLogItemType TOPICJOIN
            = new ModelsTopicLogItemType("TOPIC_JOIN");

        public static readonly ModelsTopicLogItemType TOPICLEAVE
            = new ModelsTopicLogItemType("TOPIC_LEAVE");


        public static implicit operator ModelsTopicLogItemType(string value)
        {
            return NewValue(value);
        }

        public ModelsTopicLogItemType(string enumValue)
            : base(enumValue)
        {

        }
    }
}