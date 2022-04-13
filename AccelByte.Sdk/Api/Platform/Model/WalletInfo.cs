// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class WalletInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("balance")]
        public long? Balance { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public WalletInfoStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class WalletInfoStatus : StringEnum<WalletInfoStatus>
    {
        public static readonly WalletInfoStatus ACTIVE
            = new WalletInfoStatus("ACTIVE");

        public static readonly WalletInfoStatus INACTIVE
            = new WalletInfoStatus("INACTIVE");


        public static implicit operator WalletInfoStatus(string value)
        {
            return Create(value);
        }

        public WalletInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}