// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// grantUserPass
    ///
    /// This API is used to grant pass to user, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace, otherwise ignore.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : user season data
    /// </summary>
    public class GrantUserPass : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserPassBuilder Builder = new GrantUserPassBuilder();

        public class GrantUserPassBuilder
        {
            
            
            public Model.UserPassGrant? Body { get; set; }
            
            internal GrantUserPassBuilder() { }



            public GrantUserPassBuilder SetBody(Model.UserPassGrant _body)
            {
                Body = _body;
                return this;
            }



            public GrantUserPass Build(
                string namespace_,
                string userId
            )
            {
                return new GrantUserPass(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GrantUserPass(GrantUserPassBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public GrantUserPass(
            string namespace_,            
            string userId,            
            Model.UserPassGrant body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserSeasonSummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}