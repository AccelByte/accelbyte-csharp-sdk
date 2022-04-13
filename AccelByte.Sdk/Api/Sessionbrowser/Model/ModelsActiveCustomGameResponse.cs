// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsActiveCustomGameResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("pagination")]
        public ModelsPagingCursor? Pagination { get; set; }

        [JsonPropertyName("sessions")]
        public List<ModelsCustomGameResponse>? Sessions { get; set; }

    }
}