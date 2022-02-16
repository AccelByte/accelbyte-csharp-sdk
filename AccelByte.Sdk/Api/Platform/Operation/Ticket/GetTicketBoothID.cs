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
    /// getTicketBoothID
    ///
    /// Get ticket(code/key) booth ID.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:TICKET", action=2 (READ)
    ///   *  Returns : ticket booth id
    /// </summary>
    public class GetTicketBoothID : AccelByte.Sdk.Core.Operation
    {
        public GetTicketBoothID(
            string boothName,            
            string namespace_            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/id";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.TicketBoothID? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TicketBoothID>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TicketBoothID>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}