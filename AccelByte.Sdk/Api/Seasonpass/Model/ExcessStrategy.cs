// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ExcessStrategy : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("method")]
        [JsonStringEnum]
        public ExcessStrategyMethod? Method { get; set; }

        [JsonPropertyName("percentPerExp")]
        public int? PercentPerExp { get; set; }

    }

    public class ExcessStrategyMethod : StringEnum<ExcessStrategyMethod>
    {
        public static readonly ExcessStrategyMethod NONE
            = new ExcessStrategyMethod("NONE");

        public static readonly ExcessStrategyMethod CURRENCY
            = new ExcessStrategyMethod("CURRENCY");


        public static implicit operator ExcessStrategyMethod(string value)
        {
            return Create(value);
        }

        public ExcessStrategyMethod(string enumValue)
            : base(enumValue)
        {

        }
    }    
}