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
    /// AdminDeleteAllUserChannels
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CHANNEL [DELETE]
    /// </summary>
    public class AdminDeleteAllUserChannels : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteAllUserChannelsBuilder Builder = new AdminDeleteAllUserChannelsBuilder();

        public class AdminDeleteAllUserChannelsBuilder
        {
            
            
            internal AdminDeleteAllUserChannelsBuilder() { }





            public AdminDeleteAllUserChannels Build(
                string namespace_,
                string userId
            )
            {
                return new AdminDeleteAllUserChannels(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminDeleteAllUserChannels(AdminDeleteAllUserChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminDeleteAllUserChannels(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels";

        public override HttpMethod Method => HttpMethod.Delete;

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