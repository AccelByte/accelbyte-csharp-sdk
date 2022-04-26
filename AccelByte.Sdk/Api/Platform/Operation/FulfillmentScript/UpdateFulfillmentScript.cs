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
    /// updateFulfillmentScript
    ///
    /// Update fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=4 (UPDATE)
    /// </summary>
    public class UpdateFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateFulfillmentScriptBuilder Builder = new UpdateFulfillmentScriptBuilder();

        public class UpdateFulfillmentScriptBuilder
            : OperationBuilder<UpdateFulfillmentScriptBuilder>
        {
            
            public Model.FulfillmentScriptUpdate? Body { get; set; }
            
            internal UpdateFulfillmentScriptBuilder() { }



            public UpdateFulfillmentScriptBuilder SetBody(Model.FulfillmentScriptUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateFulfillmentScript Build(
                string id
            )
            {
                UpdateFulfillmentScript op = new UpdateFulfillmentScript(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateFulfillmentScript(UpdateFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateFulfillmentScript(
            string id,            
            Model.FulfillmentScriptUpdate body            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] {  };

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