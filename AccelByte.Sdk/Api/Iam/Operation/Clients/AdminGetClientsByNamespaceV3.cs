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
    /// AdminGetClientsByNamespaceV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [READ]'
    /// 
    /// 
    /// 
    /// 
    /// action code: 10308
    /// </summary>
    public class AdminGetClientsByNamespaceV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetClientsByNamespaceV3Builder Builder = new AdminGetClientsByNamespaceV3Builder();

        public class AdminGetClientsByNamespaceV3Builder
        {
            
            public long? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal AdminGetClientsByNamespaceV3Builder() { }


            public AdminGetClientsByNamespaceV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetClientsByNamespaceV3Builder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public AdminGetClientsByNamespaceV3 Build(
                string namespace_
            )
            {
                return new AdminGetClientsByNamespaceV3(this,
                    namespace_                    
                );
            }
        }

        private AdminGetClientsByNamespaceV3(AdminGetClientsByNamespaceV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public AdminGetClientsByNamespaceV3(
            string namespace_,            
            long? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ClientmodelClientsV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientsV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientsV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}