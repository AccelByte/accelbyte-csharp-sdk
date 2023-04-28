// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.CustomOperation
{
    public class MyCustomResponseModel
    {
        public class TagData
        {
            [JsonPropertyName("createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("namespace")]
            public string? Namespace { get; set; }
        }

        public class Pagination
        {
            [JsonPropertyName("next")]
            public string? Next { get; set; }

            [JsonPropertyName("previous")]
            public string? Previous { get; set; }
        }

        [JsonPropertyName("data")]
        public List<TagData>? Data { get; set; }

        [JsonPropertyName("paging")]
        public Pagination? Paging { get; set; }
    }
}
