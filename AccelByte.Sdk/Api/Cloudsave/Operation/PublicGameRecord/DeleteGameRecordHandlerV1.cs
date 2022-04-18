// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// deleteGameRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:CLOUDSAVE:RECORD [DELETE]`
    /// --------------------|---------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Delete records by its key
    /// </summary>
    public class DeleteGameRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteGameRecordHandlerV1Builder Builder = new DeleteGameRecordHandlerV1Builder();

        public class DeleteGameRecordHandlerV1Builder
            : OperationBuilder<DeleteGameRecordHandlerV1Builder>
        {
            
            
            internal DeleteGameRecordHandlerV1Builder() { }





            public DeleteGameRecordHandlerV1 Build(
                string key,
                string namespace_
            )
            {
                DeleteGameRecordHandlerV1 op = new DeleteGameRecordHandlerV1(this,
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteGameRecordHandlerV1(DeleteGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteGameRecordHandlerV1(
            string key,            
            string namespace_            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/records/{key}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

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