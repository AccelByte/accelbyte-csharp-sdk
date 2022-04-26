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
    /// SearchUser
    ///
    /// 
    /// 
    /// ## The endpoint is deprecated. Please use this instead: iam/v3/admin/namespaces/{namespace}/users/search
    /// 
    /// 
    /// 
    /// 
    /// Search all users that match the query on these fields: all login IDs (email address, phone number, and platform user id),
    /// userID, display name, and on the specified namespace. If the query is not defined, then it searches all users on the specified namespace.
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:* [READ]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SearchUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchUserBuilder Builder = new SearchUserBuilder();

        public class SearchUserBuilder
            : OperationBuilder<SearchUserBuilder>
        {
            
            public string? Query { get; set; }
            
            internal SearchUserBuilder() { }


            public SearchUserBuilder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public SearchUser Build(
                string namespace_
            )
            {
                SearchUser op = new SearchUser(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SearchUser(SearchUserBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Query != null) QueryParams["query"] = builder.Query;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchUser(
            string namespace_,            
            string? query            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (query != null) QueryParams["query"] = query;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelSearchUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}