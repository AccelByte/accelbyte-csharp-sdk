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
    /// listPlayerRecordHandlerV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]
    /// 
    /// Required scope: social
    /// 
    /// Retrieve list of player records key and userID under given namespace.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class ListPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public ListPlayerRecordHandlerV1(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? query            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query != null) QueryParams["query"] = query;
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListPlayerRecordKeys? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeys>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeys>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}