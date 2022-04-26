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
    /// grantUserExp
    ///
    /// This API is used to grant exp to user, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace, otherwise ignore.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : user season data
    /// </summary>
    public class GrantUserExp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserExpBuilder Builder = new GrantUserExpBuilder();

        public class GrantUserExpBuilder
            : OperationBuilder<GrantUserExpBuilder>
        {
            
            
            public Model.UserExpGrant? Body { get; set; }
            
            internal GrantUserExpBuilder() { }



            public GrantUserExpBuilder SetBody(Model.UserExpGrant _body)
            {
                Body = _body;
                return this;
            }




            public GrantUserExp Build(
                string namespace_,
                string userId
            )
            {
                GrantUserExp op = new GrantUserExp(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GrantUserExp(GrantUserExpBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GrantUserExp(
            string namespace_,            
            string userId,            
            Model.UserExpGrant body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/exp";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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