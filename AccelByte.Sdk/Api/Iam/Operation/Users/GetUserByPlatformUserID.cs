// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetUserByPlatformUserID
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER [READ]'
    /// </summary>
    public class GetUserByPlatformUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserByPlatformUserIDBuilder Builder = new GetUserByPlatformUserIDBuilder();

        public class GetUserByPlatformUserIDBuilder
            : OperationBuilder<GetUserByPlatformUserIDBuilder>
        {
            
            
            
            internal GetUserByPlatformUserIDBuilder() { }






            public GetUserByPlatformUserID Build(
                string namespace_,
                string platformID,
                string platformUserID
            )
            {
                GetUserByPlatformUserID op = new GetUserByPlatformUserID(this,
                    namespace_,                    
                    platformID,                    
                    platformUserID                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserByPlatformUserID(GetUserByPlatformUserIDBuilder builder,
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (platformID != null) QueryParams["platformID"] = platformID;
            if (platformUserID != null) QueryParams["platformUserID"] = platformUserID;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserByPlatformUserID(
            string namespace_,            
            string platformID,            
            string platformUserID            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (platformID != null) QueryParams["platformID"] = platformID;
            if (platformUserID != null) QueryParams["platformUserID"] = platformUserID;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byPlatformUserID";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelPublicUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}