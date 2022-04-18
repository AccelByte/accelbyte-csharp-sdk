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
    /// deleteFulfillmentScript
    ///
    /// Delete fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=8 (DELETE)
    /// </summary>
    public class DeleteFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteFulfillmentScriptBuilder Builder = new DeleteFulfillmentScriptBuilder();

        public class DeleteFulfillmentScriptBuilder
            : OperationBuilder<DeleteFulfillmentScriptBuilder>
        {
            
            internal DeleteFulfillmentScriptBuilder() { }





            public DeleteFulfillmentScript Build(
                string id
            )
            {
                DeleteFulfillmentScript op = new DeleteFulfillmentScript(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteFulfillmentScript(DeleteFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteFulfillmentScript(
            string id            
        )
        {
            PathParams["id"] = id;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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