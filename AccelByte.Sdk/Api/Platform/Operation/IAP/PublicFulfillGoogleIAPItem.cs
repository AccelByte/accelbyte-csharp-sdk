// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicFulfillGoogleIAPItem
    ///
    /// Verify google iap receipt and fulfill item.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class PublicFulfillGoogleIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicFulfillGoogleIAPItemBuilder Builder = new PublicFulfillGoogleIAPItemBuilder();

        public class PublicFulfillGoogleIAPItemBuilder
        {
            
            
            public Model.GoogleIAPReceipt? Body { get; set; }
            
            internal PublicFulfillGoogleIAPItemBuilder() { }



            public PublicFulfillGoogleIAPItemBuilder SetBody(Model.GoogleIAPReceipt _body)
            {
                Body = _body;
                return this;
            }



            public PublicFulfillGoogleIAPItem Build(
                string namespace_,
                string userId
            )
            {
                return new PublicFulfillGoogleIAPItem(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicFulfillGoogleIAPItem(PublicFulfillGoogleIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicFulfillGoogleIAPItem(
            string namespace_,            
            string userId,            
            Model.GoogleIAPReceipt body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/google/receipt";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.GoogleReceiptResolveResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GoogleReceiptResolveResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GoogleReceiptResolveResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}