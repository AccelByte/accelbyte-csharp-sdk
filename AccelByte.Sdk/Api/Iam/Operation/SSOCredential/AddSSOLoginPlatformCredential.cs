using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AddSSOLoginPlatformCredential
    ///
    /// This is the API to Add SSO Platform Credential. It needs
    /// ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:SSO [CREATE] resource.
    /// 
    /// ## Supported platforms:
    /// 
    ///           * discourse
    /// the ssoUrl of the discourse is the discourse forum url. example:
    /// https://forum.example.com
    /// 
    ///           * azure with SAML
    ///  appId is an application identifier in IdP, in azure it's called EntityID
    /// acsUrl is an endpoint on the service provider where the identity provider will
    /// redirect to with its authentication response. example:
    /// /iam/v3/sso/saml/azuresaml/authenticate federationMetadataUrl is an endpoint
    /// on the Identity Provider(IdP) to get IdP federation metadata for service
    /// provider to build trust relationship
    /// </summary>
    public class AddSSOLoginPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        public AddSSOLoginPlatformCredential(
            string namespace_,            
            string platformId,            
            Model.ModelSSOPlatformCredentialRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelSSOPlatformCredentialResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}