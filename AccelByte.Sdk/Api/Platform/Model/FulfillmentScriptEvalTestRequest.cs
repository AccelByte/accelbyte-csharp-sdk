// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptEvalTestRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("context")]
        public FulfillmentScriptContext? Context { get; set; }

        [JsonPropertyName("script")]
        public string? Script { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public FulfillmentScriptEvalTestRequestType? Type { get; set; }

    }

    public class FulfillmentScriptEvalTestRequestType : StringEnum<FulfillmentScriptEvalTestRequestType>
    {
        public static readonly FulfillmentScriptEvalTestRequestType GrantDays
            = new FulfillmentScriptEvalTestRequestType("grantDays");


        public static implicit operator FulfillmentScriptEvalTestRequestType(string value)
        {
            return Create(value);
        }

        public FulfillmentScriptEvalTestRequestType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}