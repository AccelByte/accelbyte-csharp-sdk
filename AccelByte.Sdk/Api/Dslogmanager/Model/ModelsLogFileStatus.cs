// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsLogFileStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("log_existence")]
        public bool? LogExistence { get; set; }
        
    }
}