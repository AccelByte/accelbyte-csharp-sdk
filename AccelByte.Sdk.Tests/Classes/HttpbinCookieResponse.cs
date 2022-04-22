// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinCookieResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cookies")]
        public Dictionary<string, string>? Cookies { get; set; } = null;
    }
}