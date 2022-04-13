// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketBoothID : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public TicketBoothIDType? Type { get; set; }

    }

    public class TicketBoothIDType : StringEnum<TicketBoothIDType>
    {
        public static readonly TicketBoothIDType CAMPAIGN
            = new TicketBoothIDType("CAMPAIGN");

        public static readonly TicketBoothIDType KEYGROUP
            = new TicketBoothIDType("KEYGROUP");


        public static implicit operator TicketBoothIDType(string value)
        {
            return Create(value);
        }

        public TicketBoothIDType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}