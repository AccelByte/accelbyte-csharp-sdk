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
    /// RetrieveAllSSOLoginPlatformCredentialV3
    ///
    /// This is the API to Get All Active SSO Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:*:SSO [READ] resource
    /// </summary>
    public class RetrieveAllSSOLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllSSOLoginPlatformCredentialV3Builder Builder = new RetrieveAllSSOLoginPlatformCredentialV3Builder();

        public class RetrieveAllSSOLoginPlatformCredentialV3Builder
        {
            
            public long? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal RetrieveAllSSOLoginPlatformCredentialV3Builder() { }


            public RetrieveAllSSOLoginPlatformCredentialV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public RetrieveAllSSOLoginPlatformCredentialV3Builder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public RetrieveAllSSOLoginPlatformCredentialV3 Build(
                string namespace_
            )
            {
                return new RetrieveAllSSOLoginPlatformCredentialV3(this,
                    namespace_                    
                );
            }
        }

        private RetrieveAllSSOLoginPlatformCredentialV3(RetrieveAllSSOLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public RetrieveAllSSOLoginPlatformCredentialV3(
            string namespace_,            
            long? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/sso";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelSSOPlatformCredentialResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelSSOPlatformCredentialResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelSSOPlatformCredentialResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}