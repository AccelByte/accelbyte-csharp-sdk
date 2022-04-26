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
    /// GetUsersByLoginIds
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER [READ]'
    /// </summary>
    public class GetUsersByLoginIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUsersByLoginIdsBuilder Builder = new GetUsersByLoginIdsBuilder();

        public class GetUsersByLoginIdsBuilder
            : OperationBuilder<GetUsersByLoginIdsBuilder>
        {
            
            public string? LoginIds { get; set; }
            
            internal GetUsersByLoginIdsBuilder() { }


            public GetUsersByLoginIdsBuilder SetLoginIds(string _loginIds)
            {
                LoginIds = _loginIds;
                return this;
            }





            public GetUsersByLoginIds Build(
                string namespace_
            )
            {
                GetUsersByLoginIds op = new GetUsersByLoginIds(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUsersByLoginIds(GetUsersByLoginIdsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.LoginIds != null) QueryParams["loginIds"] = builder.LoginIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUsersByLoginIds(
            string namespace_,            
            string? loginIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (loginIds != null) QueryParams["loginIds"] = loginIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/listByLoginIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelPublicUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}