// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class SlotConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxSlotSize")]
        public int? MaxSlotSize { get; set; }

        [JsonPropertyName("maxSlots")]
        public int? MaxSlots { get; set; }

    }
}