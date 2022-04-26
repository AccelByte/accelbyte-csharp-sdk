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
    /// increaseTicketSale
    ///
    ///  [SERVICE COMMUNICATION ONLY] increase ticket(code/key) sale.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:TICKET", action=4 (UPDATE)
    ///   *  Returns : Ticket sale increment result
    /// </summary>
    public class IncreaseTicketSale : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IncreaseTicketSaleBuilder Builder = new IncreaseTicketSaleBuilder();

        public class IncreaseTicketSaleBuilder
            : OperationBuilder<IncreaseTicketSaleBuilder>
        {
            
            
            public Model.TicketSaleIncrementRequest? Body { get; set; }
            
            internal IncreaseTicketSaleBuilder() { }



            public IncreaseTicketSaleBuilder SetBody(Model.TicketSaleIncrementRequest _body)
            {
                Body = _body;
                return this;
            }




            public IncreaseTicketSale Build(
                string boothName,
                string namespace_
            )
            {
                IncreaseTicketSale op = new IncreaseTicketSale(this,
                    boothName,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private IncreaseTicketSale(IncreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IncreaseTicketSale(
            string boothName,            
            string namespace_,            
            Model.TicketSaleIncrementRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/increment";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.TicketSaleIncrementResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TicketSaleIncrementResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TicketSaleIncrementResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}