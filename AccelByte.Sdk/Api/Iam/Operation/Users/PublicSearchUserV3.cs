// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicSearchUserV3
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search all users on the specified namespace that match the query on these fields: display name, and username.
    /// The query length should greater than 1ï¼otherwise will not query the database. The default limit value is 100
    /// 
    /// 
    /// 
    /// action code : 10132
    /// </summary>
    public class PublicSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        public PublicSearchUserV3(
            string namespace_,            
            string? by,            
            string? query            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (by != null) QueryParams["by"] = by;
            if (query != null) QueryParams["query"] = query;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelPublicUserInformationResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}