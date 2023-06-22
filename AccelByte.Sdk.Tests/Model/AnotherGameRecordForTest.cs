// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Tests.Model
{
    /// <summary>
    /// Game record model with naming policy camelCase
    /// </summary>
    public class AnotherGameRecordForTest_CC : ModelsGameRecordRequest
    {
        [JsonPropertyName("fooValue")]
        public int? FooValue { get; set; }

        [JsonPropertyName("barValue")]
        public string? BarValue { get; set; }
    }

    /// <summary>
    /// Game record model with default naming policy (PascalCase)
    /// </summary>
    public class AnotherGameRecordForTest_PC : ModelsGameRecordRequest
    {
        public int? FooValue { get; set; }

        public string? BarValue { get; set; }
    }
}
