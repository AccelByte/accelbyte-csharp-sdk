using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelValidationDetailPublic : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowDigit")]
        public bool? AllowDigit { get; set; }
        
        [JsonPropertyName("allowLetter")]
        public bool? AllowLetter { get; set; }
        
        [JsonPropertyName("allowSpace")]
        public bool? AllowSpace { get; set; }
        
        [JsonPropertyName("allowUnicode")]
        public bool? AllowUnicode { get; set; }
        
        [JsonPropertyName("description")]
        public AccountcommonInputValidationDescription? Description { get; set; }
        
        [JsonPropertyName("isCustomRegex")]
        public bool? IsCustomRegex { get; set; }
        
        [JsonPropertyName("letterCase")]
        public string? LetterCase { get; set; }
        
        [JsonPropertyName("maxLength")]
        public int? MaxLength { get; set; }
        
        [JsonPropertyName("maxRepeatingAlphaNum")]
        public int? MaxRepeatingAlphaNum { get; set; }
        
        [JsonPropertyName("maxRepeatingSpecialCharacter")]
        public int? MaxRepeatingSpecialCharacter { get; set; }
        
        [JsonPropertyName("minCharType")]
        public int? MinCharType { get; set; }
        
        [JsonPropertyName("minLength")]
        public int? MinLength { get; set; }
        
        [JsonPropertyName("regex")]
        public string? Regex { get; set; }
        
        [JsonPropertyName("specialCharacterLocation")]
        public string? SpecialCharacterLocation { get; set; }
        
        [JsonPropertyName("specialCharacters")]
        public List<string>? SpecialCharacters { get; set; }
        
    }
}