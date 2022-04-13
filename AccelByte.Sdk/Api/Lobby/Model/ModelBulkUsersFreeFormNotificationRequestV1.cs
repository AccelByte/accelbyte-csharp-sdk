// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelBulkUsersFreeFormNotificationRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("topicName")]
        public string? TopicName { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }
}