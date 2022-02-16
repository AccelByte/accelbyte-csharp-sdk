// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteStat
    ///
    /// Deletes stat template.
    /// Other detail info:
    ///           *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=8 (DELETE)
    /// </summary>
    public class DeleteStat : AccelByte.Sdk.Core.Operation
    {
        public DeleteStat(
            string namespace_,            
            string statCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            
            
            
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
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