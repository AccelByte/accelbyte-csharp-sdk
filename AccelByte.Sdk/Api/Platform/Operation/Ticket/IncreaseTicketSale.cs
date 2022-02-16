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
        public IncreaseTicketSale(
            string boothName,            
            string namespace_,            
            Model.TicketSaleIncrementRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/increment";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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