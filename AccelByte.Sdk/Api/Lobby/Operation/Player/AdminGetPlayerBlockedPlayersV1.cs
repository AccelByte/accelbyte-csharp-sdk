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
    /// adminGetPlayerBlockedPlayersV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:BLOCK [READ]` with scope `social`
    /// 
    /// get blocked players data by user id in a namespace.
    /// </summary>
    public class AdminGetPlayerBlockedPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerBlockedPlayersV1Builder Builder = new AdminGetPlayerBlockedPlayersV1Builder();

        public class AdminGetPlayerBlockedPlayersV1Builder
        {
            
            
            internal AdminGetPlayerBlockedPlayersV1Builder() { }





            public AdminGetPlayerBlockedPlayersV1 Build(
                string namespace_,
                string userId
            )
            {
                return new AdminGetPlayerBlockedPlayersV1(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetPlayerBlockedPlayersV1(AdminGetPlayerBlockedPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminGetPlayerBlockedPlayersV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetAllPlayerBlockedUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}