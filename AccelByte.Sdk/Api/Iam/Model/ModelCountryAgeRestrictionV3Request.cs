using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelCountryAgeRestrictionV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ageRestriction")]
        public int? AgeRestriction { get; set; }
        
    }
}