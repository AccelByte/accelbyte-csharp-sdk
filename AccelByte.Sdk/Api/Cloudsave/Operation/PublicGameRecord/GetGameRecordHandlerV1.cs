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
    /// getGameRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]`
    /// --------------------|-------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// Get game record by its key.
    /// </summary>
    public class GetGameRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGameRecordHandlerV1Builder Builder = new GetGameRecordHandlerV1Builder();

        public class GetGameRecordHandlerV1Builder
            : OperationBuilder<GetGameRecordHandlerV1Builder>
        {
            
            
            internal GetGameRecordHandlerV1Builder() { }





            public GetGameRecordHandlerV1 Build(
                string key,
                string namespace_
            )
            {
                GetGameRecordHandlerV1 op = new GetGameRecordHandlerV1(this,
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetGameRecordHandlerV1(GetGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGameRecordHandlerV1(
            string key,            
            string namespace_            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/records/{key}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGameRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGameRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGameRecordResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}