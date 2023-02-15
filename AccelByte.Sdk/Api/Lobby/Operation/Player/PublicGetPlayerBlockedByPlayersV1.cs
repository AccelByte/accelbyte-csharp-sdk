// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// publicGetPlayerBlockedByPlayersV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// load get players who blocked this player in a namespace based on user id
    /// 
    /// Action Code: 50101
    /// </summary>
    public class PublicGetPlayerBlockedByPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPlayerBlockedByPlayersV1Builder Builder { get => new PublicGetPlayerBlockedByPlayersV1Builder(); }

        public class PublicGetPlayerBlockedByPlayersV1Builder
            : OperationBuilder<PublicGetPlayerBlockedByPlayersV1Builder>
        {





            internal PublicGetPlayerBlockedByPlayersV1Builder() { }






            public PublicGetPlayerBlockedByPlayersV1 Build(
                string namespace_
            )
            {
                PublicGetPlayerBlockedByPlayersV1 op = new PublicGetPlayerBlockedByPlayersV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetPlayerBlockedByPlayersV1(PublicGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPlayerBlockedByPlayersV1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked-by";

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