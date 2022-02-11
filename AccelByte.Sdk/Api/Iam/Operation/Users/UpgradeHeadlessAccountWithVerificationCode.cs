using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UpgradeHeadlessAccountWithVerificationCode
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// The endpoint upgrades a headless account by linking the headless account with
    /// the email address and the password. By upgrading the headless account into a
    /// full account, the user could use the email address and password for using
    /// Justice IAM. The endpoint is a shortcut for upgrading a headless account and
    /// verifying the email address in one call. In order to get a verification code
    /// for the endpoint, please check the send verification code endpoint.
    /// </summary>
    public class UpgradeHeadlessAccountWithVerificationCode : AccelByte.Sdk.Core.Operation
    {
        public UpgradeHeadlessAccountWithVerificationCode(
            string namespace_,            
            string userId,            
            Model.ModelUpgradeHeadlessAccountWithVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccountWithVerificationCode";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}