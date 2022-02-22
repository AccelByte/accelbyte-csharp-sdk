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
    /// deleteUserStatItems
    ///
    /// This endpoint is for testing purpose. Use this endpoint for cleaning up after testing.
    /// Delete user's statItems given stat code.
    /// Other detail info:
    ///             *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=8 (DELETE)
    ///             *  Returns : no content
    /// </summary>
    public class DeleteUserStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserStatItemsBuilder Builder = new DeleteUserStatItemsBuilder();

        public class DeleteUserStatItemsBuilder
        {
            
            
            
            internal DeleteUserStatItemsBuilder() { }





            public DeleteUserStatItems Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                return new DeleteUserStatItems(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
            }
        }

        private DeleteUserStatItems(DeleteUserStatItemsBuilder builder,
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

        public DeleteUserStatItems(
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

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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