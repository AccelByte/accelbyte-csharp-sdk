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
    /// publicGetPlayerBlockedPlayersV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// load blocked players in a namespace based on user id
    /// 
    /// Action Code: 50101
    /// </summary>
    public class PublicGetPlayerBlockedPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPlayerBlockedPlayersV1Builder Builder = new PublicGetPlayerBlockedPlayersV1Builder();

        public class PublicGetPlayerBlockedPlayersV1Builder
            : OperationBuilder<PublicGetPlayerBlockedPlayersV1Builder>
        {
            
            internal PublicGetPlayerBlockedPlayersV1Builder() { }






            public PublicGetPlayerBlockedPlayersV1 Build(
                string namespace_
            )
            {
                PublicGetPlayerBlockedPlayersV1 op = new PublicGetPlayerBlockedPlayersV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetPlayerBlockedPlayersV1(PublicGetPlayerBlockedPlayersV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPlayerBlockedPlayersV1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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