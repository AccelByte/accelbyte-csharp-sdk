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
    /// CreateBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Create backfill ticket
    /// </summary>
    public class CreateBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateBackfillBuilder Builder { get => new CreateBackfillBuilder(); }

        public class CreateBackfillBuilder
            : OperationBuilder<CreateBackfillBuilder>
        {





            internal CreateBackfillBuilder() { }






            public CreateBackfill Build(
                ApiBackFillCreateRequest body,
                string namespace_
            )
            {
                CreateBackfill op = new CreateBackfill(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateBackfill(CreateBackfillBuilder builder,
            ApiBackFillCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateBackfill(
            string namespace_,            
            Model.ApiBackFillCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill";

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