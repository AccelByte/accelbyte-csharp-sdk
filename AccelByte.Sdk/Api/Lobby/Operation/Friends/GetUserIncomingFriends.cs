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
    /// getUserIncomingFriends
    /// </summary>
    public class GetUserIncomingFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserIncomingFriendsBuilder Builder = new GetUserIncomingFriendsBuilder();

        public class GetUserIncomingFriendsBuilder
        {
            
            internal GetUserIncomingFriendsBuilder() { }





            public GetUserIncomingFriends Build(
                string namespace_
            )
            {
                return new GetUserIncomingFriends(this,
                    namespace_                    
                );
            }
        }

        private GetUserIncomingFriends(GetUserIncomingFriendsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetUserIncomingFriends(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/friends/namespaces/{namespace}/me/incoming";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelGetUserIncomingFriendsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserIncomingFriendsResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserIncomingFriendsResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}