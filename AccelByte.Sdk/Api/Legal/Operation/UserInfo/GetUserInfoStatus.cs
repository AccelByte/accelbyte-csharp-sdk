// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// getUserInfoStatus
    ///
    /// Get user info cache last updated time per namespace.
    /// The query parameter namespaces can be a list of namespace separated by comma.
    /// If query parameter namespaces is empty, user info cache status for all available namespaces will be returned.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class GetUserInfoStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserInfoStatusBuilder Builder = new GetUserInfoStatusBuilder();

        public class GetUserInfoStatusBuilder
            : OperationBuilder<GetUserInfoStatusBuilder>
        {
            public string? Namespaces { get; set; }
            
            internal GetUserInfoStatusBuilder() { }


            public GetUserInfoStatusBuilder SetNamespaces(string _namespaces)
            {
                Namespaces = _namespaces;
                return this;
            }





            public GetUserInfoStatus Build(
            )
            {
                GetUserInfoStatus op = new GetUserInfoStatus(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserInfoStatus(GetUserInfoStatusBuilder builder
        )
        {
            
            if (builder.Namespaces != null) QueryParams["namespaces"] = builder.Namespaces;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserInfoStatus(
            string? namespaces            
        )
        {
            
            if (namespaces != null) QueryParams["namespaces"] = namespaces;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.RetrieveUserInfoCacheStatusResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserInfoCacheStatusResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveUserInfoCacheStatusResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}