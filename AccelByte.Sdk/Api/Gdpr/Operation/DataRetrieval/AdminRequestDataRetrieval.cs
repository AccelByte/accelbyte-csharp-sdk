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
    /// AdminRequestDataRetrieval
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [CREATE]` and scope `account`
    /// 
    /// 
    /// 
    /// 
    /// If admin request data for themselves, password is need to be set
    /// </summary>
    public class AdminRequestDataRetrieval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRequestDataRetrievalBuilder Builder = new AdminRequestDataRetrievalBuilder();

        public class AdminRequestDataRetrievalBuilder
            : OperationBuilder<AdminRequestDataRetrievalBuilder>
        {
            
            
            public string? Password { get; set; }
            
            internal AdminRequestDataRetrievalBuilder() { }




            public AdminRequestDataRetrievalBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }



            public AdminRequestDataRetrieval Build(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = new AdminRequestDataRetrieval(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminRequestDataRetrieval(AdminRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (builder.Password != null) FormParams["password"] = builder.Password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRequestDataRetrieval(
            string namespace_,            
            string userId,            
            string? password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password != null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsDataRetrievalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}