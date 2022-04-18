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
    /// GetRevocationListV3
    ///
    /// 
    /// 
    /// This endpoint will return a list of revoked users and revoked tokens. List of revoked tokens in bloom filter format.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint requires authorized requests header with valid access token.
    /// 
    /// 
    /// 
    /// 
    /// The bloom filter uses MurmurHash3 algorithm for hashing the values
    /// 
    /// 
    /// 
    /// 
    /// action code : 10708
    /// </summary>
    public class GetRevocationListV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRevocationListV3Builder Builder = new GetRevocationListV3Builder();

        public class GetRevocationListV3Builder
            : OperationBuilder<GetRevocationListV3Builder>
        {
            internal GetRevocationListV3Builder() { }





            public GetRevocationListV3 Build(
            )
            {
                GetRevocationListV3 op = new GetRevocationListV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRevocationListV3(GetRevocationListV3Builder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRevocationListV3(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/revocationlist";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthapiRevocationList? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthapiRevocationList>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthapiRevocationList>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}