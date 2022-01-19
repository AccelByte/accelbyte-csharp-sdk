using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PlatformAuthenticationV3 : AccelByte.Sdk.Core.Operation
    {
        public PlatformAuthenticationV3(
            string platformId,            
            string? code,            
            string? error,            
            string? openidAssocHandle,            
            string? openidClaimedId,            
            string? openidIdentity,            
            string? openidMode,            
            string? openidNs,            
            string? openidOpEndpoint,            
            string? openidResponseNonce,            
            string? openidReturnTo,            
            string? openidSig,            
            string? openidSigned,            
            string state            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (code != null) QueryParams["code"] = code;
            if (error != null) QueryParams["error"] = error;
            if (openidAssocHandle != null) QueryParams["openid.assoc_handle"] = openidAssocHandle;
            if (openidClaimedId != null) QueryParams["openid.claimed_id"] = openidClaimedId;
            if (openidIdentity != null) QueryParams["openid.identity"] = openidIdentity;
            if (openidMode != null) QueryParams["openid.mode"] = openidMode;
            if (openidNs != null) QueryParams["openid.ns"] = openidNs;
            if (openidOpEndpoint != null) QueryParams["openid.op_endpoint"] = openidOpEndpoint;
            if (openidResponseNonce != null) QueryParams["openid.response_nonce"] = openidResponseNonce;
            if (openidReturnTo != null) QueryParams["openid.return_to"] = openidReturnTo;
            if (openidSig != null) QueryParams["openid.sig"] = openidSig;
            if (openidSigned != null) QueryParams["openid.signed"] = openidSigned;
            if (state != null) QueryParams["state"] = state;
            
            
            
            LocationQuery = "PLACEHOLDER";
        }

        public override string Path => "/iam/v3/platforms/{platformId}/authenticate";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "*/*" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            if (code == (HttpStatusCode)302)
            {
              return payloadString;
            }
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}