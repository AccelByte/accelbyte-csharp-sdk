using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListDeploymentResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("deployments")]
        public List<ModelsDeploymentWithOverride>? Deployments { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}