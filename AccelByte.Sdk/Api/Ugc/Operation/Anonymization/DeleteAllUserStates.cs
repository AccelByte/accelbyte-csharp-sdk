// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// DeleteAllUserStates
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}" [DELETE]
    /// </summary>
    public class DeleteAllUserStates : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAllUserStatesBuilder Builder = new DeleteAllUserStatesBuilder();

        public class DeleteAllUserStatesBuilder
        {
            
            
            internal DeleteAllUserStatesBuilder() { }





            public DeleteAllUserStates Build(
                string namespace_,
                string userId
            )
            {
                return new DeleteAllUserStates(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private DeleteAllUserStates(DeleteAllUserStatesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public DeleteAllUserStates(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/states";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

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