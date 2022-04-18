// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminGetPlayerBlockedByPlayersV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:BLOCK [READ]` with scope `social`
    /// 
    /// load get players who blocked this player in a namespace based on user id
    /// </summary>
    public class AdminGetPlayerBlockedByPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerBlockedByPlayersV1Builder Builder = new AdminGetPlayerBlockedByPlayersV1Builder();

        public class AdminGetPlayerBlockedByPlayersV1Builder
            : OperationBuilder<AdminGetPlayerBlockedByPlayersV1Builder>
        {
            
            
            internal AdminGetPlayerBlockedByPlayersV1Builder() { }





            public AdminGetPlayerBlockedByPlayersV1 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerBlockedByPlayersV1 op = new AdminGetPlayerBlockedByPlayersV1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetPlayerBlockedByPlayersV1(AdminGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetPlayerBlockedByPlayersV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked-by";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetAllPlayerBlockedByUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedByUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedByUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}