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
    /// GetRevocationList
    ///
    /// 
    /// 
    /// This endpoint will return a list of revoked users and revoked tokens. List of revoked tokens in bloom filter format. This endpoint requires all requests to have Authorization header set with Basic access authentication constructed from client id and client secret.
    /// 
    /// 
    /// 
    /// 
    /// The bloom filter uses MurmurHash3 algorithm for hashing the values
    /// </summary>
    public class GetRevocationList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRevocationListBuilder Builder = new GetRevocationListBuilder();

        public class GetRevocationListBuilder
            : OperationBuilder<GetRevocationListBuilder>
        {
            internal GetRevocationListBuilder() { }





            public GetRevocationList Build(
            )
            {
                GetRevocationList op = new GetRevocationList(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRevocationList(GetRevocationListBuilder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRevocationList(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/revocationlist";

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