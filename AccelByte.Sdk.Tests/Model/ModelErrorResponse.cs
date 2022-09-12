// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Tests.Model
{
    public class ModelErrorResponse
    {
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; } = 0;

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; } = String.Empty;
    }
}