// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteUserStatItems_1
    ///
    /// Delete user's statItems given stat code.
    /// Other detail info:
    ///               *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=8 (DELETE)
    ///               *  Returns : no content
    /// </summary>
    public class DeleteUserStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserStatItems1Builder Builder = new DeleteUserStatItems1Builder();

        public class DeleteUserStatItems1Builder
            : OperationBuilder<DeleteUserStatItems1Builder>
        {
            
            
            
            internal DeleteUserStatItems1Builder() { }






            public DeleteUserStatItems1 Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                DeleteUserStatItems1 op = new DeleteUserStatItems1(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteUserStatItems1(DeleteUserStatItems1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserStatItems1(
            string namespace_,            
            string statCode,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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