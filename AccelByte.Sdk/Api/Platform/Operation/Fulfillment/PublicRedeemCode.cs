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
    /// publicRedeemCode
    ///
    /// Redeem campaign code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:FULFILLMENT", action=1 (CREATED)
    ///   *  Returns : fulfillment result
    /// </summary>
    public class PublicRedeemCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicRedeemCodeBuilder Builder = new PublicRedeemCodeBuilder();

        public class PublicRedeemCodeBuilder
            : OperationBuilder<PublicRedeemCodeBuilder>
        {
            
            
            public Model.FulfillCodeRequest? Body { get; set; }
            
            internal PublicRedeemCodeBuilder() { }



            public PublicRedeemCodeBuilder SetBody(Model.FulfillCodeRequest _body)
            {
                Body = _body;
                return this;
            }



            public PublicRedeemCode Build(
                string namespace_,
                string userId
            )
            {
                PublicRedeemCode op = new PublicRedeemCode(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicRedeemCode(PublicRedeemCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicRedeemCode(
            string namespace_,            
            string userId,            
            Model.FulfillCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/fulfillment/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.FulfillmentResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}