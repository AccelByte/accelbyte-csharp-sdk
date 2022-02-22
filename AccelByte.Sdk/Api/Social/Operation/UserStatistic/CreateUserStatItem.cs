// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// createUserStatItem
    ///
    /// Create statItem for a user.
    /// Other detail info:
    ///             *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=1 (CREATE)
    ///             *  Returns : created user's statItem
    /// </summary>
    public class CreateUserStatItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserStatItemBuilder Builder = new CreateUserStatItemBuilder();

        public class CreateUserStatItemBuilder
        {
            
            
            
            internal CreateUserStatItemBuilder() { }





            public CreateUserStatItem Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                return new CreateUserStatItem(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
            }
        }

        private CreateUserStatItem(CreateUserStatItemBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public CreateUserStatItem(
            string namespace_,            
            string statCode,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}