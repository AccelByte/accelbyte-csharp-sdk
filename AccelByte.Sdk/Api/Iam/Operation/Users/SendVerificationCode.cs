using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// SendVerificationCode
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// The verification code is sent to either the phone number or email address. It
    /// depends on the LoginID's value.
    /// 
    /// Available contexts for use :
    /// 
    ///         1. UserAccountRegistration
    /// 
    /// a context type used for verifying email address in user account registration.
    /// It returns 409 if the email address already verified. It is the default
    /// context if the Context field is empty
    /// 
    ///         2. UpdateEmailAddress
    /// 
    /// a context type used for verify user before updating email address.(Without
    /// email address verified checking)
    /// 
    ///         3. upgradeHeadlessAccount
    /// 
    /// The context is intended to be used whenever the email address wanted to be
    /// automatically verified on upgrading a headless account. If this context used,
    /// IAM rejects the request if the loginId field's value is already used by others
    /// by returning HTTP Status Code 409.
    /// </summary>
    public class SendVerificationCode : AccelByte.Sdk.Core.Operation
    {
        public SendVerificationCode(
            string namespace_,            
            string userId,            
            Model.ModelSendVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/verificationcode";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}