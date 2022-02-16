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
    /// createFulfillmentScript
    ///
    /// Create fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=1 (CREATE)
    /// 
    /// Fulfillment scripts are used for adding custom fulfillment logic based on ITEM_TYPE : [MEDIA,INGAMEITEM] for now, and the custom scripts only cover grantDays.
    /// Example for grantDays:
    /// `order && ((order.currency && order.currency.currencyCode) == 'LP' || order.isFree) ? 30 : -1`
    /// </summary>
    public class CreateFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        public CreateFulfillmentScript(
            string id,            
            Model.FulfillmentScriptCreate body            
        )
        {
            PathParams["id"] = id;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FulfillmentScriptInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}