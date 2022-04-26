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
    /// publicBulkIncUserStatItem_1
    ///
    /// Public bulk update user's statitems value.
    /// Other detail info:
    ///               *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    ///               *  Returns : bulk updated result
    /// </summary>
    public class PublicBulkIncUserStatItem1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkIncUserStatItem1Builder Builder = new PublicBulkIncUserStatItem1Builder();

        public class PublicBulkIncUserStatItem1Builder
            : OperationBuilder<PublicBulkIncUserStatItem1Builder>
        {
            
            
            public List<Model.BulkStatItemInc>? Body { get; set; }
            
            internal PublicBulkIncUserStatItem1Builder() { }



            public PublicBulkIncUserStatItem1Builder SetBody(List<Model.BulkStatItemInc> _body)
            {
                Body = _body;
                return this;
            }




            public PublicBulkIncUserStatItem1 Build(
                string namespace_,
                string userId
            )
            {
                PublicBulkIncUserStatItem1 op = new PublicBulkIncUserStatItem1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicBulkIncUserStatItem1(PublicBulkIncUserStatItem1Builder builder,
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

        public PublicBulkIncUserStatItem1(
            string namespace_,            
            string userId,            
            List<Model.BulkStatItemInc> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.BulkStatItemOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}