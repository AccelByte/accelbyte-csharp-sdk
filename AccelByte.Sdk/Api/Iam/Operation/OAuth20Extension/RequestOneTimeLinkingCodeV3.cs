// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RequestOneTimeLinkingCodeV3
    ///
    /// This endpoint is being used to request the one time code [8 length] for headless account to link or upgrade to a full account.
    /// 
    /// It require a valid user token.
    /// 
    /// Should specify the target platform id and current user should already linked to this platform.
    /// 
    /// Current user should be a headless account.
    /// 
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * steam
    /// 
    /// 
    ///   * steamopenid
    /// 
    /// 
    ///   * facebook
    /// 
    /// 
    ///   * google
    /// 
    /// 
    ///   * oculus
    /// 
    /// 
    ///   * twitch
    /// 
    /// 
    ///   * discord
    /// 
    /// 
    ///   * android
    /// 
    /// 
    ///   * ios
    /// 
    /// 
    ///   * apple
    /// 
    /// 
    ///   * device
    /// 
    /// 
    ///   * justice
    /// 
    /// 
    ///   * epicgames
    /// 
    /// 
    ///   * stadia
    /// 
    /// 
    ///   * ps4
    /// 
    /// 
    ///   * ps5
    /// 
    /// 
    ///   * nintendo
    /// 
    /// 
    ///   * awscognito
    /// 
    /// 
    ///   * live
    /// 
    /// 
    ///   * xblweb
    /// 
    /// 
    ///   * netflix
    /// 
    /// 
    ///   * snapchat
    /// </summary>
    public class RequestOneTimeLinkingCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestOneTimeLinkingCodeV3Builder Builder = new RequestOneTimeLinkingCodeV3Builder();

        public class RequestOneTimeLinkingCodeV3Builder
            : OperationBuilder<RequestOneTimeLinkingCodeV3Builder>
        {





            internal RequestOneTimeLinkingCodeV3Builder() { }






            public RequestOneTimeLinkingCodeV3 Build(
                string platformId
            )
            {
                RequestOneTimeLinkingCodeV3 op = new RequestOneTimeLinkingCodeV3(this,
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RequestOneTimeLinkingCodeV3(RequestOneTimeLinkingCodeV3Builder builder,
            string platformId
        )
        {
            
            
            if (platformId is not null) FormParams["platformId"] = platformId;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestOneTimeLinkingCodeV3(
            string platformId            
        )
        {
            
            
            if (platformId is not null) FormParams["platformId"] = platformId;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/link/code/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelOneTimeLinkingCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}