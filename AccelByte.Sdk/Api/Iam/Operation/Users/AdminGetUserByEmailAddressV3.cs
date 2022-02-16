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
    /// AdminGetUserByEmailAddressV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search user who owns the given email address
    /// 
    /// 
    /// 
    /// action code : 10132
    /// </summary>
    public class AdminGetUserByEmailAddressV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminGetUserByEmailAddressV3(
            string namespace_,            
            string? emailAddress            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (emailAddress != null) QueryParams["emailAddress"] = emailAddress;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}