// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// deleteNamespace
    ///
    /// Delete a namespace.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:NAMESPACE" , action=8 (DELETE)
    ///   *  Action code : 11307
    ///   *  Returns : deleted namespace
    /// </summary>
    public class DeleteNamespace : AccelByte.Sdk.Core.Operation
    {
        public DeleteNamespace(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.NamespaceInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}