using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonDescription : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("en-US")]
        public string? EnUS { get; set; }
        
        [JsonPropertyName("zh-CN")]
        public string? ZhCN { get; set; }
        
    }
}