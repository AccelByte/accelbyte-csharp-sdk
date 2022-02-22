// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGeneratePersonalDataURL
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [READ]` and scope `account`
    /// </summary>
    public class AdminGeneratePersonalDataURL : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGeneratePersonalDataURLBuilder Builder = new AdminGeneratePersonalDataURLBuilder();

        public class AdminGeneratePersonalDataURLBuilder
        {
            
            
            
            
            internal AdminGeneratePersonalDataURLBuilder() { }





            public AdminGeneratePersonalDataURL Build(
                string password,
                string namespace_,
                string requestDate,
                string userId
            )
            {
                return new AdminGeneratePersonalDataURL(this,
                    password,                    
                    namespace_,                    
                    requestDate,                    
                    userId                    
                );
            }
        }

        private AdminGeneratePersonalDataURL(AdminGeneratePersonalDataURLBuilder builder,
            string password,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;
            
            
            
        }
        #endregion

        public AdminGeneratePersonalDataURL(
            string namespace_,            
            string requestDate,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;
            
            
            
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsUserDataURL? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserDataURL>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserDataURL>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}