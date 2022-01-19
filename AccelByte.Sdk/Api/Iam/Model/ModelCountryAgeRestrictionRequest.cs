using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelCountryAgeRestrictionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgeRestriction")]
        public int? AgeRestriction { get; set; }
        
    }
}