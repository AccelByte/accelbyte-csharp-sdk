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
    /// UsersPresenceHandlerV1
    ///
    /// Query users presence with given namespace and userIds.
    /// </summary>
    public class UsersPresenceHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UsersPresenceHandlerV1Builder Builder = new UsersPresenceHandlerV1Builder();

        public class UsersPresenceHandlerV1Builder
        {
            
            public bool? CountOnly { get; set; }
            
            
            internal UsersPresenceHandlerV1Builder() { }


            public UsersPresenceHandlerV1Builder SetCountOnly(bool _countOnly)
            {
                CountOnly = _countOnly;
                return this;
            }




            public UsersPresenceHandlerV1 Build(
                string namespace_,
                string userIds
            )
            {
                return new UsersPresenceHandlerV1(this,
                    namespace_,                    
                    userIds                    
                );
            }
        }

        private UsersPresenceHandlerV1(UsersPresenceHandlerV1Builder builder,
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.CountOnly != null) QueryParams["countOnly"] = Convert.ToString(builder.CountOnly)!;
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            
            
        }
        #endregion

        public UsersPresenceHandlerV1(
            string namespace_,            
            bool? countOnly,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (countOnly != null) QueryParams["countOnly"] = Convert.ToString(countOnly)!;
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            
            
        }

        public override string Path => "/lobby/v1/public/presence/namespaces/{namespace}/users/presence";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.HandlersGetUsersPresenceResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.HandlersGetUsersPresenceResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.HandlersGetUsersPresenceResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}