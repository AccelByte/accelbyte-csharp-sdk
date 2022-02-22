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
    /// userUnfriendRequest
    /// </summary>
    public class UserUnfriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserUnfriendRequestBuilder Builder = new UserUnfriendRequestBuilder();

        public class UserUnfriendRequestBuilder
        {
            
            
            internal UserUnfriendRequestBuilder() { }





            public UserUnfriendRequest Build(
                ModelUserUnfriendRequest body,
                string namespace_
            )
            {
                return new UserUnfriendRequest(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private UserUnfriendRequest(UserUnfriendRequestBuilder builder,
            ModelUserUnfriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UserUnfriendRequest(
            string namespace_,            
            Model.ModelUserUnfriendRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/friends/namespaces/{namespace}/me/unfriend";

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