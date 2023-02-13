// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetLinkHeadlessAccountConflictResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelAccountProgressionInfo? CurrentAccount { get; set; }

        [JsonPropertyName("headlessAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelAccountProgressionInfo? HeadlessAccount { get; set; }

        [JsonPropertyName("platformAlreadyLinked")]
        public bool? PlatformAlreadyLinked { get; set; }

        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }

        [JsonPropertyName("platformLinkConflict")]
        public bool? PlatformLinkConflict { get; set; }

    }


}