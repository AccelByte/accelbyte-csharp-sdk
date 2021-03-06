// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getFulfillmentScript
    ///
    /// Get fulfillment script by id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=2 (READ)
    ///   *  Returns : get fulfillment script
    /// </summary>
    public class GetFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetFulfillmentScriptBuilder Builder = new GetFulfillmentScriptBuilder();

        public class GetFulfillmentScriptBuilder
            : OperationBuilder<GetFulfillmentScriptBuilder>
        {





            internal GetFulfillmentScriptBuilder() { }






            public GetFulfillmentScript Build(
                string id
            )
            {
                GetFulfillmentScript op = new GetFulfillmentScript(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetFulfillmentScript(GetFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetFulfillmentScript(
            string id            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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