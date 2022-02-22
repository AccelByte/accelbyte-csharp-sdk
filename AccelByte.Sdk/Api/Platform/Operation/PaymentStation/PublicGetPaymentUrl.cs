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
    /// publicGetPaymentUrl
    ///
    /// Get payment url.
    /// Other detail info:
    /// 
    ///   * Returns : Get payment link
    /// </summary>
    public class PublicGetPaymentUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentUrlBuilder Builder = new PublicGetPaymentUrlBuilder();

        public class PublicGetPaymentUrlBuilder
        {
            
            public Model.PaymentUrlCreate? Body { get; set; }
            
            internal PublicGetPaymentUrlBuilder() { }



            public PublicGetPaymentUrlBuilder SetBody(Model.PaymentUrlCreate _body)
            {
                Body = _body;
                return this;
            }



            public PublicGetPaymentUrl Build(
                string namespace_
            )
            {
                return new PublicGetPaymentUrl(this,
                    namespace_                    
                );
            }
        }

        private PublicGetPaymentUrl(PublicGetPaymentUrlBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicGetPaymentUrl(
            string namespace_,            
            Model.PaymentUrlCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentUrl? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentUrl>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentUrl>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}