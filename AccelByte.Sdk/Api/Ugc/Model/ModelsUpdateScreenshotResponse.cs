// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsUpdateScreenshotResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("screenshots")]
        public List<ModelsUpdateScreenshot>? Screenshots { get; set; }
        
    }
}