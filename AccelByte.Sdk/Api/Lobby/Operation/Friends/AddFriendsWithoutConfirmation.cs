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
    /// addFriendsWithoutConfirmation
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:FRIENDS [CREATE]` with scope `social`
    /// 
    /// friends request in a namespace.
    /// </summary>
    public class AddFriendsWithoutConfirmation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddFriendsWithoutConfirmationBuilder Builder = new AddFriendsWithoutConfirmationBuilder();

        public class AddFriendsWithoutConfirmationBuilder
            : OperationBuilder<AddFriendsWithoutConfirmationBuilder>
        {
            
            
            
            internal AddFriendsWithoutConfirmationBuilder() { }






            public AddFriendsWithoutConfirmation Build(
                ModelBulkAddFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                AddFriendsWithoutConfirmation op = new AddFriendsWithoutConfirmation(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AddFriendsWithoutConfirmation(AddFriendsWithoutConfirmationBuilder builder,
            ModelBulkAddFriendsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddFriendsWithoutConfirmation(
            string namespace_,            
            string userId,            
            Model.ModelBulkAddFriendsRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/users/{userId}/add/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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