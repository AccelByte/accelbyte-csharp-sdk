// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
        [JsonPropertyName("sessions")]
        public List<ModelsSession>? Sessions { get; set; }
        
    }
}