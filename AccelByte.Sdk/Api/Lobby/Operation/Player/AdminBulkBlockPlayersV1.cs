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
    /// adminBulkBlockPlayersV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:BLOCK [CREATE]` with scope `social`
    /// 
    /// Bulk block player in a namespace by list of user id
    /// </summary>
    public class AdminBulkBlockPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkBlockPlayersV1Builder Builder = new AdminBulkBlockPlayersV1Builder();

        public class AdminBulkBlockPlayersV1Builder
        {
            
            
            
            internal AdminBulkBlockPlayersV1Builder() { }





            public AdminBulkBlockPlayersV1 Build(
                ModelsListBlockedPlayerRequest body,
                string namespace_,
                string userId
            )
            {
                return new AdminBulkBlockPlayersV1(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminBulkBlockPlayersV1(AdminBulkBlockPlayersV1Builder builder,
            ModelsListBlockedPlayerRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminBulkBlockPlayersV1(
            string namespace_,            
            string userId,            
            Model.ModelsListBlockedPlayerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/block";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}