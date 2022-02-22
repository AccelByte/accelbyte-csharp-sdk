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
    /// decreaseTicketSale
    ///
    ///  [SERVICE COMMUNICATION ONLY] Decrease ticket(code/key) sale if requested orderNo is already increased.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:TICKET", action=4 (UPDATE)
    /// </summary>
    public class DecreaseTicketSale : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DecreaseTicketSaleBuilder Builder = new DecreaseTicketSaleBuilder();

        public class DecreaseTicketSaleBuilder
        {
            
            
            public Model.TicketSaleDecrementRequest? Body { get; set; }
            
            internal DecreaseTicketSaleBuilder() { }



            public DecreaseTicketSaleBuilder SetBody(Model.TicketSaleDecrementRequest _body)
            {
                Body = _body;
                return this;
            }



            public DecreaseTicketSale Build(
                string boothName,
                string namespace_
            )
            {
                return new DecreaseTicketSale(this,
                    boothName,                    
                    namespace_                    
                );
            }
        }

        private DecreaseTicketSale(DecreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public DecreaseTicketSale(
            string boothName,            
            string namespace_,            
            Model.TicketSaleDecrementRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/decrement";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

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