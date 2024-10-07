// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;

namespace AccelByte.Sdk.Tests.Model
{
    public class ModelsPlayerRecordRequestForTest : ModelsPlayerRecordRequest
    {
        [JsonPropertyName("foo")]
        public string? Foo { get; set; }

        [JsonPropertyName("foo_bar")]
        public string? FooBar { get; set; }

        [JsonPropertyName("foo_value")]
        public int? FooValue { get; set; }
    }
}