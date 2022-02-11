using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicPlatformUnlinkV3
    ///
    /// Required valid user authorization.
    /// 
    /// ## Supported platforms:
    /// 
    ///                       * steam
    ///                       * steamopenid
    ///                       * facebook
    ///                       * google
    ///                       * oculus
    ///                       * twitch
    ///                       * android
    ///                       * ios
    ///                       * apple
    ///                       * device
    ///                       * discord
    ///                       * awscognito
    ///                       * epicgames
    ///                       * nintendo
    ///                       * stadia
    /// 
    /// Unlink user's account from a specific platform. 'justice' platform might have
    /// multiple accounts from different namespaces linked.
    /// platformNamespace need to be specified when the platform ID is 'justice'.
    /// 
    /// Unlink user's account from justice platform will enable password token grant
    /// and password update.
    /// 
    /// If you want to unlink user's account in a game namespace, you have to specify
    /// platformNamespace to that game namespace.
    /// 
    /// action code : 10121
    /// </summary>
    public class PublicPlatformUnlinkV3 : AccelByte.Sdk.Core.Operation
    {
        public PublicPlatformUnlinkV3(
            string namespace_,            
            string platformId,            
            Model.ModelUnlinkUserPlatformRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}";

        public override HttpMethod Method => HttpMethod.Delete;

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