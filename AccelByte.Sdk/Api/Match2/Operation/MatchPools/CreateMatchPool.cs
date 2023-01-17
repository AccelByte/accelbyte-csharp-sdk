// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// CreateMatchPool
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:POOL [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Creates a new matchmaking pool.
    /// 
    /// A pool is isolated from other pools (i.e. tickets may be matched with other tickets in the same pool, but not with tickets in other pools).
    /// Each pool has its own matchmaking rules and/or logic.
    /// 
    /// ticket_expiration_seconds and backfill_ticket_expiration_seconds will be set to 300 seconds (5 minutes) by default if not filled.
    /// 
    /// Match Function holds information about the name of the match logic server that matchmaking can refers to. By default we provide ("default" and "basic").
    /// Match Function will be used as reference value for Match Function Overrides if not set.
    /// In case Customer would like to use matchmaking service default match logic, then specify it in "match_function_overrides".
    /// This sample configuration will let matchmaking service will use "default" match logic for make matches, while validation will hit both "default" and "custom" match logics.
    /// e.g.
    /// {
    /// "match_function": "custom",
    /// "match_function_overrides": {
    /// "validation": []{"default","custom"},
    /// "make_matches": "default",
    /// }
    /// }
    /// </summary>
    public class CreateMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMatchPoolBuilder Builder = new CreateMatchPoolBuilder();

        public class CreateMatchPoolBuilder
            : OperationBuilder<CreateMatchPoolBuilder>
        {





            internal CreateMatchPoolBuilder() { }






            public CreateMatchPool Build(
                ApiMatchPool body,
                string namespace_
            )
            {
                CreateMatchPool op = new CreateMatchPool(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateMatchPool(CreateMatchPoolBuilder builder,
            ApiMatchPool body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMatchPool(
            string namespace_,            
            Model.ApiMatchPool body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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